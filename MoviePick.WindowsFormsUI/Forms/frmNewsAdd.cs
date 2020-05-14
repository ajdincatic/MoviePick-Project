using eProdaja.WinUI;
using MoviePick.Data.Model;
using MoviePick.Data.Request;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace MoviePick.WindowsFormsUI.Forms
{
    public partial class frmNewsAdd : Form
    {
        APIService _serviceNews = new APIService("News");
        APIService _serviceUser = new APIService("User");

        private News _news;

        public frmNewsAdd(News news = null)
        {
            _news = news;
            InitializeComponent();
        }

        NewsUpsertRequest request = new NewsUpsertRequest();

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            request.Content = txtContent.Text;
            request.Title = txtTitle.Text;
            request.DateTimeOfNews = DateTime.Now;
            var x = await _serviceUser.GetAll<List<User>>(new UserSearchRequest { Username = APIService.username, UserTypeId = 1 });
            request.AuthorId = x.FirstOrDefault().Id;

            if (_news == null)
                await _serviceNews.Insert<News>(request);
            else
                await _serviceNews.Update<News>(_news.Id, request);
            MessageBox.Show("Operation successfully completed!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            var result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                var fileName = openFileDialog.FileName;
                var file = File.ReadAllBytes(fileName);
                request.CoverPhoto = file;
                txtImage.Text = fileName;

                Image img = Image.FromFile(fileName);
                pictureBox1.Image = img;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private static Image GetImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return (Image.FromStream(ms));
            }
        }

        private void frmNewsAdd_Load(object sender, EventArgs e)
        {
            if(_news != null)
            {
                txtContent.Text = _news.Content;
                txtTitle.Text = _news.Title;
                if (_news.CoverPhoto != null && _news.CoverPhoto.Length > 0)
                {
                    pictureBox1.Image = GetImage(_news.CoverPhoto);
                    request.CoverPhoto = _news.CoverPhoto;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }
    }
}

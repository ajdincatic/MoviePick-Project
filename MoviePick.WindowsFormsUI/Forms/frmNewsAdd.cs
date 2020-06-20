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
            if (this.ValidateChildren())
            {
                request.Content = txtContent.Text;
                request.Title = txtTitle.Text;
                request.DateTimeOfNews = DateTime.Now;
                var x = await _serviceUser.GetAll<List<User>>(new UserSearchRequest { Username = APIService.username, UserTypeId = 1 });
                request.AuthorId = x.FirstOrDefault().Id;

                News temp = null;
                if (_news == null)
                    temp = await _serviceNews.Insert<News>(request);
                else
                    temp = await _serviceNews.Update<News>(_news.Id, request);

                if (temp == default(News))
                    return;

                MessageBox.Show("Operation successfully completed!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
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
                button1.Visible = true;
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await _serviceNews.Delete<User>(_news.Id);
            MessageBox.Show("Operation successfully completed!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void txtImage_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void txtTitle_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                errorProvider.SetError(txtTitle, "Required");
                //e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtTitle, null);
            }
        }

        private void txtContent_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtContent.Text))
            {
                errorProvider.SetError(txtContent, "Required");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtContent, null);
            }
        }
    }
}

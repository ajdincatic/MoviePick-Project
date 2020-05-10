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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoviePick.WindowsFormsUI.Forms
{
    public partial class frmMovieTvShowAdd : Form
    {
        APIService _serviceGenre = new APIService("Genre");
        APIService _serviceProductionCompany = new APIService("ProductionCompany");
        APIService _serviceMovieAndTvShow = new APIService("MovieAndTvShow");

        public frmMovieTvShowAdd()
        {
            InitializeComponent();
        }

        protected async override void OnLoad(EventArgs e)
        {
            await LoadGenres();
            await LoadProductionCompany();
        }

        private async Task LoadGenres()
        {
            var uloge = await _serviceGenre.GetAll<List<Genre>>();
            clbGenre.DataSource = uloge;
            clbGenre.DisplayMember = "GenreName";
        }

        private async Task LoadProductionCompany()
        {
            var list = await _serviceProductionCompany.GetAll<List<ProductionCompany>>();
            cmbProductionComp.DataSource = list;
            list.Insert(0, new ProductionCompany());
            cmbProductionComp.ValueMember = "Id";
            cmbProductionComp.DisplayMember = "ProductionCompanyName";
        }

        MovieAndTvshowUpsertRequest request = new MovieAndTvshowUpsertRequest();

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var genreList = clbGenre.CheckedItems.Cast<Genre>();
            var genreIdList = genreList.Select(x => x.Id).ToList();

            request.Title = txtTitle.Text;
            request.Budget = double.Parse(txtBudget.Text);
            request.Description = rtxtDescription.Text;
            request.Finished = chkFinished.Checked;
            request.Language = txtLang.Text;
            request.NumberOfRatings = 0;
            request.ReleaseDate = dtRelaseDate.Value;
            request.RunningTime = txtRtime.Text;
            request.GenreIds = genreIdList;

            var idProductionComp = cmbProductionComp.SelectedValue;

            if (int.TryParse(idProductionComp.ToString(), out int idProductionCompany))
            {
                request.ProductionCompanyId = idProductionCompany;
            }

            var mtvs = await _serviceMovieAndTvShow.Insert<MovieAndTvshow>(request);

            MessageBox.Show("Operation successfully completed, now assign cast !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtBudget.Text = "";
            txtTitle.Text = "";
            txtRtime.Text = "";
            txtPoster.Text = "";
            txtLang.Text = "";
            rtxtDescription.Text = null;
            dtRelaseDate.Value = DateTime.Now;
            chkFinished.Checked = false;
            clbGenre.ClearSelected();

            if (chkTvShow.Checked)
            {
                frmCastAdd frm = new frmCastAdd(mtvs, true);
                frm.ShowDialog();
            }
            else
            {
                frmCastAdd frm = new frmCastAdd(mtvs);
                frm.ShowDialog();
            }
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            var result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                var fileName = openFileDialog.FileName;
                var file = File.ReadAllBytes(fileName);
                request.Poster = file;
                txtPoster.Text = fileName;

                Image img = Image.FromFile(fileName);
                pictureBox2.Image = img;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}

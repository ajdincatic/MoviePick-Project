using eProdaja.WinUI;
using MoviePick.Data.Model;
using MoviePick.Data.Request;
using MoviePick.Data.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoviePick.WindowsFormsUI.Forms
{
    public partial class frmMovieTvShowSearch : Form
    {
        APIService _serviceMTVS = new APIService("MovieAndTvShow");
        APIService _serviceGenre = new APIService("Genre");

        public frmMovieTvShowSearch()
        {
            InitializeComponent();
        }

        protected async override void OnLoad(EventArgs e)
        {
            rbMovie.Checked = true;
            await LoadMTVS();
            await LoadGenres();
        }

        private async Task LoadMTVS()
        {
            MovieAndTvshowSearchRequest request = new MovieAndTvshowSearchRequest();

            var idGenre = cmbGenre.SelectedValue;

            if (idGenre == null)
                request.GenreId = 0;
            else
            {
                if (int.TryParse(idGenre.ToString(), out int genreID))
                {
                    request.GenreId = genreID;
                }
            }

            request.Title = txtTitle.Text;
            request.isTvShow = rbTvShow.Checked;

            var list = await _serviceMTVS.GetAll<List<MovieAndTvshow>>(request);

            List<frmMovieTvShowSearchVM> vm = new List<frmMovieTvShowSearchVM>();
            foreach (var item in list)
            {
                frmMovieTvShowSearchVM ni = new frmMovieTvShowSearchVM
                {
                    Finished = item.Finished,
                    Id = item.Id,
                    ProductionCompany = item.ProductionCompany.ProductionCompanyName,
                    ReleaseDate = item.ReleaseDate,
                    RunningTime = item.RunningTime,
                    Title = item.Title,
                };

                foreach (var genre in item.MovieAndTvshowGenre)
                    ni.Genres += genre.Genre.GenreName.ToString() + " | ";

                vm.Add(ni);
            }
            dgvMTVS.DataSource = vm;
        }
        
        private async Task LoadGenres()
        {
            var list = await _serviceGenre.GetAll<List<Genre>>();
            cmbGenre.DataSource = list;
            list.Insert(0, new Genre());
            cmbGenre.ValueMember = "Id";
            cmbGenre.DisplayMember = "GenreName";
        }

        private async void dgvMTVS_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dgvMTVS.SelectedRows[0].DataBoundItem;
            var MTVS = await _serviceMTVS.GetById<MovieAndTvshow>((item as frmMovieTvShowSearchVM).Id);
            frmMovieAndTvShowDetails frm = new frmMovieAndTvShowDetails(MTVS);
            frm.WindowState = FormWindowState.Normal;
            frm.Show();
        }

        private async void btnSearch_Click_1(object sender, EventArgs e)
        {
            await LoadMTVS();
        }
    }
}

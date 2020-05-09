using eProdaja.WinUI;
using MoviePick.Data.Model;
using MoviePick.Data.Request;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoviePick.WindowsFormsUI.Forms
{
    public partial class frmMovieTvShowSearch : Form
    {
        APIService _serviceMTVS = new APIService("MovieAndTvShow");
        APIService _serviceGenre = new APIService("Genre");
        APIService _serviceMTVSGenre = new APIService("Genre", "MovieTvShow", -1);

        public frmMovieTvShowSearch()
        {
            InitializeComponent();
            dgvMTVS.AutoGenerateColumns = false;
            dgvMTVS.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        protected async override void OnLoad(EventArgs e)
        {
            await LoadMTVS();
            await LoadGenres();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            await LoadMTVS();
        }

        private async Task LoadMTVS()
        {
            var list = await _serviceMTVS.GetAll<List<MovieAndTvshow>>(new MovieAndTvshowSearchRequest()
            {
                Title = txtTitle.Text,
            });
            dgvMTVS.DataSource = list;
        }
        
        private async Task LoadGenres()
        {
            var list = await _serviceGenre.GetAll<List<Genre>>();
            cmbGenre.DataSource = list;
            list.Insert(0, new Genre());
            cmbGenre.ValueMember = "Id";
            cmbGenre.DisplayMember = "GenreName";
        }

        private async void cmbGenre_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _serviceMTVSGenre._value = cmbGenre.SelectedIndex;
            var list = await _serviceMTVSGenre.GetAll<List<MovieAndTvshow>>();
            dgvMTVS.DataSource = list;
        }

        private void dgvMTVS_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dgvMTVS.SelectedRows[0].DataBoundItem;
            frmMovieTvShowDetails frm = new frmMovieTvShowDetails(item as MovieAndTvshow);
            frm.Show();
        }
    }
}

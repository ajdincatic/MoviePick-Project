using eProdaja.WinUI;
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
    public partial class frmTvShowSeasonEpisodesAdd : Form
    {
        private APIService _serviceTvshowSeason = new APIService("TvshowSeason");
        private APIService _serviceTvshowSeasonEpisode = new APIService("TvshowSeasonEpisode");

        private int MTVSId;

        public frmTvShowSeasonEpisodesAdd(int MTVSId)
        {
            this.MTVSId = MTVSId;
            InitializeComponent();
        }

        protected async override void OnLoad(EventArgs e)
        {
            await LoadSeasons();
            await LoadSeasonsAdd();
            await LoadEpisodes();
        }

        private async void btnNewSeason_Click(object sender, EventArgs e)
        {
            TvshowSeasonUpsertRequest request = new TvshowSeasonUpsertRequest
            {
                Finished = chkFinished.Checked,
                MovieAndTvshowId = MTVSId,
                SeasonName = txtSeasonName.Text
            };
            await _serviceTvshowSeason.Insert<Data.Model.TvshowSeason>(request);
            await LoadSeasons();
            await LoadSeasonsAdd();
            await LoadEpisodes();
            txtSeasonName.Text = "";
        }

        private async Task LoadSeasons()
        {
            var list = await _serviceTvshowSeason.GetAll<List<Data.Model.TvshowSeason>>();
            cmbSeasons.ValueMember = "Id";
            cmbSeasons.DisplayMember = "SeasonName";
            cmbSeasons.DataSource = list; 
        }

        private async Task LoadSeasonsAdd()
        {
            var list = await _serviceTvshowSeason.GetAll<List<Data.Model.TvshowSeason>>();
            cmbSeasonAdd.ValueMember = "Id";
            cmbSeasonAdd.DisplayMember = "SeasonName";
            cmbSeasonAdd.DataSource = list;
        }

        private async Task LoadEpisodes()
        {
            TvshowSeasonEpisodeSearchRequest request = new TvshowSeasonEpisodeSearchRequest();
            var idSeason = cmbSeasons.SelectedValue;

            if (int.TryParse(idSeason.ToString(), out int SeasonId))
            {
                request.TvshowSeasonId = SeasonId;
            }

            var list = await _serviceTvshowSeasonEpisode.GetAll<List<Data.Model.TvshowSeasonEpisode>>(request);
            dgvEpisodes.DataSource = list;
        }

        private async void btnAddEpisode_Click(object sender, EventArgs e)
        {
            TvshowSeasonEpisodeUpsertRequest request = new TvshowSeasonEpisodeUpsertRequest
            {
                EpisodeName = txtEpisodeName.Text,
                AirDate = DateTime.Now
            };

            var idSeason = cmbSeasonAdd.SelectedValue;

            if(int.TryParse(idSeason.ToString(),out int SeasonId))
            {
                request.TvshowSeasonId = SeasonId;
            }

            await _serviceTvshowSeasonEpisode.Insert<Data.Model.TvshowSeasonEpisode>(request);
            await LoadSeasons();
            await LoadEpisodes();
            txtEpisodeName.Text = "";
        }

        private async void cmbSeasons_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            await LoadEpisodes();
        }
    }
}

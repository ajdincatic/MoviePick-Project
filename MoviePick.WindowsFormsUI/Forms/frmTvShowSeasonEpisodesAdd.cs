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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoviePick.WindowsFormsUI.Forms
{
    public partial class frmTvShowSeasonEpisodesAdd : Form
    {
        private APIService _serviceTvshowSeason = new APIService("TvshowSeason");
        private APIService _serviceTvshowSeasonEpisode = new APIService("TvshowSeasonEpisode");

        private MovieAndTvshow MTVS;

        public frmTvShowSeasonEpisodesAdd(MovieAndTvshow MTVS)
        {
            this.MTVS = MTVS;
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
                MovieAndTvshowId = MTVS.Id,
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
            var list = await _serviceTvshowSeason.GetAll<List<Data.Model.TvshowSeason>>(new TvshowSeasonSearchRequest
            {
                MovieAndTvshowId = MTVS.Id
            });
            cmbSeasons.ValueMember = "Id";
            cmbSeasons.DisplayMember = "SeasonName";
            cmbSeasons.DataSource = list; 
        }

        private async Task LoadSeasonsAdd()
        {
            var list = await _serviceTvshowSeason.GetAll<List<Data.Model.TvshowSeason>>(new TvshowSeasonSearchRequest
            {
                MovieAndTvshowId = MTVS.Id
            });
            cmbSeasonAdd.ValueMember = "Id";
            cmbSeasonAdd.DisplayMember = "SeasonName";
            cmbSeasonAdd.DataSource = list;
        }

        private async Task LoadEpisodes()
        {
            TvshowSeasonEpisodeSearchRequest request = new TvshowSeasonEpisodeSearchRequest();
            var idSeason = cmbSeasons.SelectedValue;
            if (idSeason != null)
            {

                if (int.TryParse(idSeason.ToString(), out int SeasonId))
                {
                    request.TvshowSeasonId = SeasonId;
                }

                var list = await _serviceTvshowSeasonEpisode.GetAll<List<Data.Model.TvshowSeasonEpisode>>(request);

                List<frmTvShowSeasonEpisodeVM> vm = new List<frmTvShowSeasonEpisodeVM>();
                var ctr = 0;
                foreach (var x in list)
                {
                    frmTvShowSeasonEpisodeVM nl = new frmTvShowSeasonEpisodeVM
                    {
                        Id = x.Id,
                        EpisodeName = x.EpisodeName,
                        AirDate = x.AirDate,
                        EpisodeNumber = ++ctr
                    };
                    vm.Add(nl);
                }

                dgvEpisodes.DataSource = vm;
            }
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

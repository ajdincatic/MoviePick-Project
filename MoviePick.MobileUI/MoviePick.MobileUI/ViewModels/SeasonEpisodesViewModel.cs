using eProdaja.Mobile;
using MoviePick.Data.Model;
using MoviePick.Data.Request;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MoviePick.MobileUI.ViewModels
{
    public class SeasonEpisodesViewModel
    {
        private readonly APIService _EpisodesService = new APIService("TvshowSeasonEpisode");
        public Data.Model.TvshowSeason TvshowSeason;

        public ObservableCollection<Data.Model.TvshowSeasonEpisode> EpisodesList { get; set; } = new ObservableCollection<Data.Model.TvshowSeasonEpisode>();

        public SeasonEpisodesViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }

        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            var listMTVS = await _EpisodesService.Get<List<TvshowSeasonEpisode>>(new TvshowSeasonEpisodeSearchRequest
            {
                TvshowId = TvshowSeason.MovieAndTvshowId,
                TvshowSeasonId = TvshowSeason.Id
            });

            EpisodesList.Clear();
            foreach (var mtvs in listMTVS)
            {
                EpisodesList.Add(mtvs);
            }
        }
    }
}

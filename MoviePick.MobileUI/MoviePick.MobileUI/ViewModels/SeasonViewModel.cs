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
    public class SeasonViewModel
    {
        private readonly APIService _SeasonService = new APIService("TvshowSeason");
        public int MTVSId;
        public ObservableCollection<Data.Model.TvshowSeason> SeasonsList { get; set; } = new ObservableCollection<Data.Model.TvshowSeason>();

        public SeasonViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }

        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            var listMTVS = await _SeasonService.Get<List<TvshowSeason>>(new TvshowSeasonSearchRequest
            {
                MovieAndTvshowId = MTVSId
            });

            SeasonsList.Clear();
            foreach (var mtvs in listMTVS)
            {
                SeasonsList.Add(mtvs);
            }
        }
    }
}

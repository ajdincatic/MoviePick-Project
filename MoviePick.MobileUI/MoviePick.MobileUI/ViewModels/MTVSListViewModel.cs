using eProdaja.Mobile;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using MoviePick.Data.Model;
using MoviePick.MobileUI.Models;
using MoviePick.Data.Request;

namespace MoviePick.MobileUI.ViewModels
{
    public class MTVSListViewModel
    {
        private readonly APIService _MTVSService = new APIService("MovieAndTvShow");
        private readonly APIService _RatingService = new APIService("Rating");

        public ObservableCollection<Data.Model.MovieAndTvshow> MTVSList { get; set; } = new ObservableCollection<Data.Model.MovieAndTvshow>();

        public MTVSListViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }

        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            var listMTVS = await _MTVSService.Get<List<MovieAndTvshow>>(new MovieAndTvshowSearchRequest
            {
                isTvShow = null
            });

            MTVSList.Clear();
            foreach (var mtvs in listMTVS)
            {
                MTVSList.Add(mtvs);
            }
        }
    }
}

using eProdaja.Mobile;
using MoviePick.Data.Model;
using MoviePick.Data.Request;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MoviePick.MobileUI.ViewModels
{
    public class HomeViewModel
    {
        private readonly APIService _MTVSService = new APIService("MovieAndTvShow");
        private readonly APIService _NewsService = new APIService("News");

        public ObservableCollection<Data.Model.MovieAndTvshow> MTVSList { get; set; } = new ObservableCollection<Data.Model.MovieAndTvshow>();
        public ObservableCollection<Data.Model.News> NewsList { get; set; } = new ObservableCollection<Data.Model.News>();

        public HomeViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }

        public string LoggedUser { get
            {
                return APIService.Username;
            }
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

            var ListNews = await _NewsService.Get<List<Data.Model.News>>(null);
            ListNews = ListNews.OrderByDescending(x => x.DateTimeOfNews).ToList();

            NewsList.Clear();
            foreach (var mtvs in ListNews)
            {
                NewsList.Add(mtvs);
            }
        }
    }
}

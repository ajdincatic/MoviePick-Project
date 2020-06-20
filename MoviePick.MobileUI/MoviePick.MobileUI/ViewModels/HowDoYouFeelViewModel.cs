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
    public class HowDoYouFeelViewModel : BaseViewModel
    {
        private readonly APIService _MTVSService = new APIService("MovieAndTvShow");

        public ObservableCollection<Data.Model.MovieAndTvshow> MTVSList { get; set; } = new ObservableCollection<Data.Model.MovieAndTvshow>();

        public HowDoYouFeelViewModel()
        {
            LoadCommand = new Command(async () => await Load());
        }

        string _actor = string.Empty;
        public string Actor
        {
            get { return _actor; }
            set { SetProperty(ref _actor, value); }
        }

        string _genre = string.Empty;
        public string Genre
        {
            get { return _genre; }
            set { SetProperty(ref _genre, value); }
        }

        string _releaseYear = string.Empty;
        public string ReleaseYear
        {
            get { return _releaseYear; }
            set { SetProperty(ref _releaseYear, value); }
        }

        string _keyWord = string.Empty;
        public string KeyWord
        {
            get { return _keyWord; }
            set { SetProperty(ref _keyWord, value); }
        }

        public ICommand LoadCommand { get; set; }

        public async Task Load()
        {
            if (string.IsNullOrWhiteSpace(Actor) && string.IsNullOrWhiteSpace(KeyWord) &&
                string.IsNullOrWhiteSpace(ReleaseYear) && string.IsNullOrWhiteSpace(Genre))
            {
                return;
            }
            var listMTVS = await _MTVSService.Get<List<MovieAndTvshow>>(new MovieAndTvshowSearchRequest
            {
                Actor = Actor,
                Genre = Genre,
                ReleaseYear = ReleaseYear,
                KeyWord = KeyWord
            });

            MTVSList.Clear();
            foreach (var item in listMTVS)
            {
                MTVSList.Add(item);
            }
        }
    }
}

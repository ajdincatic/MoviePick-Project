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
    public class MTVSDetailsViewModel : BaseViewModel
    {
        private readonly APIService _CastService = new APIService("Cast");

        public Data.Model.MovieAndTvshow mtvs { get; set; }

        public ObservableCollection<Data.Model.MovieAndTvshowPerson> ActorsList { get; set; } = new ObservableCollection<Data.Model.MovieAndTvshowPerson>();
        public ObservableCollection<Data.Model.MovieAndTvshowPerson> DirectorsList { get; set; } = new ObservableCollection<Data.Model.MovieAndTvshowPerson>();

        public MTVSDetailsViewModel()
        {
            LoadActorsCommand = new Command(async () => await LoadActors());
        }

        public string MTVSYear { 
            get {
                if (mtvs != null)
                    return mtvs.Title + "(" + mtvs.ReleaseDate.Year.ToString() + ")";
                return string.Empty;
            }
        }

        public string Genres
        {
            get
            {
                var str = string.Empty;
                if (mtvs != null)
                {
                    str += "|";
                    foreach (var item in mtvs.MovieAndTvshowGenre)
                        str += item.Genre.GenreName + "|";
                }
                return str;
            }
        }

        public string RunningTimeInMins
        {
            get
            {
                var str = string.Empty;
                if (mtvs != null)
                {
                    return mtvs.RunningTime + " min";
                }
                return str;
            }
        }

        public ICommand LoadActorsCommand { get; set; }

        public async Task LoadActors()
        {
            var listCast = await _CastService.Get<List<Data.Model.MovieAndTvshowPerson>>(new MovieAndTvshowPersonSearchRequest()
            {
                MovieAndTvshowId = mtvs.Id,
                RoleId = 1,
            });

            ActorsList.Clear();
            foreach (var person in listCast)
            {
                ActorsList.Add(person);
            }
        }

        public async Task LoadDirectors()
        {
            IEnumerable<MovieAndTvshowPerson> listCast = await _CastService.Get<List<Data.Model.MovieAndTvshowPerson>>(new MovieAndTvshowPersonSearchRequest()
            {
                MovieAndTvshowId = mtvs.Id,
                RoleId = 2,
            });

            DirectorsList.Clear();
            foreach (var person in listCast)
            {
                DirectorsList.Add(person);
            }
        }
    }
}

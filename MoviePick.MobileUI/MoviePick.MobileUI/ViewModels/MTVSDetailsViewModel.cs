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
        private readonly APIService _RatingService = new APIService("Rating");

        public Data.Model.MovieAndTvshow mtvs { get; set; }
        public string Rating { get; set; }

        public ObservableCollection<Data.Model.MovieAndTvshowPerson> ActorsList { get; set; } = new ObservableCollection<Data.Model.MovieAndTvshowPerson>();
        public ObservableCollection<Data.Model.MovieAndTvshowPerson> DirectorsList { get; set; } = new ObservableCollection<Data.Model.MovieAndTvshowPerson>();
        public ObservableCollection<Data.Model.MovieAndTvshowPerson> PersonsList { get; set; } = new ObservableCollection<Data.Model.MovieAndTvshowPerson>();

        public MTVSDetailsViewModel()
        {
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

        public async Task LoadPersons()
        {
            var listCast = await _CastService.Get<List<Data.Model.MovieAndTvshowPerson>>(new MovieAndTvshowPersonSearchRequest()
            {
                MovieAndTvshowId = mtvs.Id,
            });

            PersonsList.Clear();
            foreach (var person in listCast)
            {
                PersonsList.Add(person);
            }
            LoadActors();
            LoadDirectors();
        }

        public void LoadActors()
        {
            var listCast = PersonsList.Where(x => x.RoleId == 1).ToList();
            ActorsList.Clear();
            foreach (var person in listCast)
            {
                ActorsList.Add(person);
            }
        }

        public void LoadDirectors()
        {
            var listCast = PersonsList.Where(x => x.RoleId == 2).ToList();

            DirectorsList.Clear();
            foreach (var person in listCast)
            {
                DirectorsList.Add(person);
            }
        }
    }
}

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
        private readonly APIService _RatingService = new APIService("Rating");
        private readonly APIService _CastService = new APIService("Cast");

        public Data.Model.MovieAndTvshow mtvs { get; set; }

        public ObservableCollection<Data.Model.MovieAndTvshowPerson> ActorsList { get; set; } = new ObservableCollection<Data.Model.MovieAndTvshowPerson>();
        public ObservableCollection<Data.Model.MovieAndTvshowPerson> DirectorsList { get; set; } = new ObservableCollection<Data.Model.MovieAndTvshowPerson>();
        public ObservableCollection<Data.Model.MovieAndTvshowPerson> PersonsList { get; set; } = new ObservableCollection<Data.Model.MovieAndTvshowPerson>();

        public ICommand RatingCommand { get; set; }

        public MTVSDetailsViewModel()
        {
            RatingCommand = new Command(async () => await SetNewRating());
        }

        public string MTVSYear { 
            get {
                if (mtvs != null)
                    return mtvs.Title + "(" + mtvs.ReleaseDate.Year.ToString() + ")";
                return string.Empty;
            }
        }

        private string _userRating = string.Empty;
        public string UserRating
        {
            get { return _userRating; }
            set { SetProperty(ref _userRating, value); }
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

        public string Genres 
        {
            get
            {
                var str = string.Empty;
                if (mtvs != null)
                {
                    foreach (var item in mtvs.MovieAndTvshowGenre)
                        str += item.Genre.GenreName + ", ";
                    str = str.Substring(0, str.Length - 2);
                }
;               return str;
            }
        }

        public async Task SetNewRating()
        {
            bool answer = await Application.Current.MainPage.DisplayAlert("Alert", "Would you like to add rating?", "Yes", "No");
            if (answer)
            {
                if (int.TryParse(UserRating, out int val))
                {
                    if (val < 0 || val > 100)
                    {
                        await Application.Current.MainPage.DisplayAlert("Alert", "Range is from 0 to 100", "Try again");
                        return;
                    }
                    await _RatingService.Insert<Data.Model.Rating>(new RatingUpsertRequest
                    {
                        AppUserId = APIService.UserId,
                        MovieAndTvshowId = mtvs.Id,
                        RatingValue = int.Parse(UserRating)
                    });

                    await Application.Current.MainPage.DisplayAlert("Succesfull", "Succesfully rated title.", "OK");
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("Alert", "Wrong input!", "Try again");
                }
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

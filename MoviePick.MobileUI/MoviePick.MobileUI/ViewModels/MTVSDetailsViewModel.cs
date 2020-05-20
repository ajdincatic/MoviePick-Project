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
    public class MTVSDetailsViewModel : BaseViewModel
    {
        private readonly APIService _MTVSService = new APIService("MovieAndTvShow");
        private readonly APIService _CastService = new APIService("Cast");

        public Data.Model.MovieAndTvshow mtvs { get; set; }

        public ObservableCollection<Data.Model.MovieAndTvshowPerson> CastList { get; set; } = new ObservableCollection<Data.Model.MovieAndTvshowPerson>();

        public MTVSDetailsViewModel()
        {
            LoadActorsCommand = new Command(async () => await LoadActor());
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

        public ICommand LoadActorsCommand { get; set; }

        public async Task LoadActor()
        {
            var listCast = await _CastService.Get<List<Data.Model.MovieAndTvshowPerson>>(new MovieAndTvshowPersonSearchRequest()
            {
                MovieAndTvshowId = mtvs.Id,
                RoleId = 1,
            });

            CastList.Clear();
            foreach (var person in listCast)
            {
                CastList.Add(person);
            }
        }
    }
}

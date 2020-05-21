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

namespace MoviePick.MobileUI.ViewModels
{
    public class PersonDetailsViewModel
    {
        private readonly APIService _CastService = new APIService("Cast");

        public Data.Model.Person person { get; set; }

        public ObservableCollection<Data.Model.MovieAndTvshowPerson> MovieList { get; set; } = new ObservableCollection<Data.Model.MovieAndTvshowPerson>();

        public ICommand LoadMTVSCommand { get; set; }

        public string FullName { 
            get
            {
                if(person!= null)
                {
                    return person.FirstName + " " + person.LastName;
                }
                return string.Empty;
            }
        }
        
        public string PersonDates { 
            get
            {
                if(person!= null)
                {
                    return "(" + person.DateOfBirth.Year.ToString() + " - " + person.DateOfDeath?.Year.ToString() + ")";
                }
                return string.Empty;
            }
        }

        public async Task LoadMTVS(string sortType = "desc")
        {
            List<MovieAndTvshowPerson> listCast = await _CastService.Get<List<Data.Model.MovieAndTvshowPerson>>(new MovieAndTvshowPersonSearchRequest()
            {
                PersonId = person.Id,
            });

            if (sortType == "desc")
            {
                listCast = listCast.GroupBy(p => p.MovieAndTvshowId)
                    .Select(g => g.First()).OrderByDescending(x => x.MovieAndTvshow.ReleaseDate).ToList();
            }
            else
            {
                listCast = listCast.GroupBy(p => p.MovieAndTvshowId)
                    .Select(g => g.First()).OrderBy(x => x.MovieAndTvshow.ReleaseDate).ToList();
            }

            MovieList.Clear();
            foreach (var person in listCast)
            {
                MovieList.Add(person);
            }
        }
    }
}

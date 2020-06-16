using eProdaja.Mobile;
using MoviePick.Data.Model;
using MoviePick.Data.Request;
using MoviePick.MobileUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MoviePick.MobileUI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonDetailsPage : ContentPage
    {
        private readonly APIService _RatingService = new APIService("Rating");

        PersonDetailsViewModel model = null;

        public PersonDetailsPage(Person p)
        {
            InitializeComponent();
            BindingContext = model = new PersonDetailsViewModel()
            {
                person = p
            };
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.LoadMTVS();
        }

        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var item = e.Item as Data.Model.MovieAndTvshowPerson;

            var temp = await _RatingService.Get<List<Data.Model.Rating>>(new RatingSearchRequest()
            {
                MovieAndTvshowId = item.MovieAndTvshow.Id,
                AppUserId = APIService.UserId
            });
            var UserRating = temp.Select(x => x.RatingValue).FirstOrDefault().ToString();
            item.MovieAndTvshow.CalculatedRating = Math.Ceiling(item.MovieAndTvshow.Rating.Average(x => x.RatingValue)).ToString();
            await Navigation.PushAsync(new MTVSDetailsPage(item.MovieAndTvshow, UserRating));
        }

        private async void btnOrderType_Clicked(object sender, EventArgs e)
        {
            if(btnOrderType.Text == "Order by : desc")
            {
                btnOrderType.Text = "Order by : asc";
                await model.LoadMTVS("asc");
            }
            else
            {
                btnOrderType.Text = "Order by : desc";
                await model.LoadMTVS();
            }
        }
    }
}
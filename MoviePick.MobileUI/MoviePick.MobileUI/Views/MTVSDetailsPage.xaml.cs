using eProdaja.Mobile;
using MoviePick.Data.Model;
using MoviePick.Data.Request;
using MoviePick.MobileUI.Models;
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
    public partial class MTVSDetailsPage : ContentPage
    {
        private readonly APIService _RatingService = new APIService("Rating");

        MTVSDetailsViewModel model = null;
        public MTVSDetailsPage(Data.Model.MovieAndTvshow movieAndTvshow, string UserRating)
        {
            InitializeComponent();
            BindingContext = model = new MTVSDetailsViewModel()
            {
                mtvs = movieAndTvshow,
                UserRating = UserRating
            };
            if(model.mtvs.TvshowSeason.Count() == 0)
            {
                btnEpisodes.IsVisible = false;
            }
            
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.LoadPersons();
        }

        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var item = e.Item as Data.Model.MovieAndTvshowPerson;

            await Navigation.PushAsync(new PersonDetailsPage(item.Person));
        }

        private async void btnMovieChat_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MovieChatPage(model.mtvs));
        }

        private async void btnFullCast_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FullCastPage(model.PersonsList));
        }

        private async void btnEpisodes_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SeasonPage(model.mtvs.Id));
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            bool answer = await DisplayAlert("Alert", "Would you like to add rating?", "Yes", "No");
            if (answer)
            {
                if (int.TryParse(UserRating.Text, out int val))
                {
                    if (val < 0 || val > 100)
                    {
                        await DisplayAlert("Alert", "Range is from 0 to 100", "Try again");
                        return;
                    }
                    await _RatingService.Insert<Data.Model.Rating>(new RatingUpsertRequest
                    {
                        AppUserId = APIService.UserId,
                        MovieAndTvshowId = model.mtvs.Id,
                        RatingValue = int.Parse(UserRating.Text)
                    });
                    await Application.Current.MainPage.DisplayAlert("Succesfull", "Succesfully rated title.", "OK");
                }
                else
                {
                    await DisplayAlert("Alert", "Wrong input!", "Try again");
                }
            }
        }
    }
}
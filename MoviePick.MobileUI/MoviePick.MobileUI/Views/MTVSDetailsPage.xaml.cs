using eProdaja.Mobile;
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
        public MTVSDetailsPage(Data.Model.MovieAndTvshow movieAndTvshow)
        {
            InitializeComponent();
            BindingContext = model = new MTVSDetailsViewModel()
            {
                mtvs = movieAndTvshow,
            };
            if(model.mtvs.TvshowSeason.Count() == 0)
            {
                btnEpisodes.IsVisible = false;
            }
        }

        protected async override void OnAppearing()
        {
            await model.LoadPersons();
            base.OnAppearing();
        }

        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var item = e.Item as Data.Model.MovieAndTvshowPerson;

            await Navigation.PushAsync(new PersonDetailsPage(item.Person));
        }

        private void btnMovieChat_Clicked(object sender, EventArgs e)
        {
        }

        private async void btnFullCast_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FullCastPage(model.PersonsList));
        }

        private async void btnEpisodes_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SeasonEpisodesPage(model.mtvs.Id));
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
                        AppUserId = 6,
                        MovieAndTvshowId = model.mtvs.Id,
                        RatingValue = int.Parse(UserRating.Text)
                    });
                }
                else
                {
                    await DisplayAlert("Alert", "Wrong input!", "Try again");
                }
            }
        }
    }
}
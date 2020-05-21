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
        MTVSDetailsViewModel model = null;
        public MTVSDetailsPage(Data.Model.MovieAndTvshow movieAndTvshow)
        {
            InitializeComponent();
            BindingContext = model = new MTVSDetailsViewModel()
            {
                mtvs = movieAndTvshow
            };
        }

        protected async override void OnAppearing()
        {
            await model.LoadActors();
            await model.LoadDirectors();
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

        private void btnFullCast_Clicked(object sender, EventArgs e)
        {

        }
    }
}
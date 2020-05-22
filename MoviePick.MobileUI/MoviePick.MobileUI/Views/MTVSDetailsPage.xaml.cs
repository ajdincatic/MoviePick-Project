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
            await model.LoadPersons();
            base.OnAppearing();
        }

        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var item = e.Item as Data.Model.MovieAndTvshowPerson;

            await Navigation.PushAsync(new PersonDetailsPage(item.Person));
        }

        private async void btnMovieChat_Clicked(object sender, EventArgs e)
        {
        }

        private async void btnFullCast_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FullCastPage(model.PersonsList));
        }
    }
}
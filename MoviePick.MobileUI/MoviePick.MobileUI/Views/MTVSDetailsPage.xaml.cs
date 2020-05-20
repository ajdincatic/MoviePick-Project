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
            base.OnAppearing();
            await model.LoadActor();
        }
    }
}
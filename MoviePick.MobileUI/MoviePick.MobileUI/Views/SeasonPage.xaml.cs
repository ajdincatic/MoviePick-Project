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
    public partial class SeasonPage : ContentPage
    {
        SeasonViewModel model = null;

        public SeasonPage(int mtvsId)
        {
            InitializeComponent();
            BindingContext = model = new SeasonViewModel
            {
                MTVSId = mtvsId
            };
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var item = e.Item as Data.Model.TvshowSeason;

            await Navigation.PushAsync(new SeasonEpisodesPage(item));
        }
    }
}
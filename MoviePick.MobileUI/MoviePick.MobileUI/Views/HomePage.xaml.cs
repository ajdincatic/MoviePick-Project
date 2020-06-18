using eProdaja.Mobile;
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
    public partial class Home : ContentPage
    {
        public HomeViewModel model = null;
        private readonly APIService _RatingService = new APIService("Rating");

        public Home()
        {
            InitializeComponent();
            BindingContext = model = new HomeViewModel();

            NewsPlace.GestureRecognizers.Add(new TapGestureRecognizer
            {
                Command = new Command(async () => await ClickNewsPlace())
            });

            MoviesList.GestureRecognizers.Add(new TapGestureRecognizer
            {
                Command = new Command(async () => await ClickMTVSList())
            });
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }
        
        private async Task ClickNewsPlace()
        {
            await Navigation.PushAsync(new NewsPage());
        }

        private async Task ClickMTVSList()
        {
            await Navigation.PushAsync(new MTVSListPage());
        }

        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var item = e.Item as Data.Model.News;

            await Navigation.PushAsync(new NewsDetailsPage(item));
        }

        private async void ListView_ItemTapped_1(object sender, ItemTappedEventArgs e)
        {
            var item = e.Item as Data.Model.MovieAndTvshow;

            var temp = await _RatingService.Get<List<Data.Model.Rating>>(new RatingSearchRequest()
            {
                MovieAndTvshowId = item.Id,
                AppUserId = APIService.UserId
            });
            var UserRating = temp.Select(x => x.RatingValue).FirstOrDefault().ToString();

            await Navigation.PushAsync(new MTVSDetailsPage(item, UserRating));
        }
    }
}
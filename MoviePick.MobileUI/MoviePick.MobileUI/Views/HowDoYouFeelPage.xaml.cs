using eProdaja.Mobile;
using MoviePick.Data.Model;
using MoviePick.Data.Request;
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
    public partial class HowDoYouFeelPage : ContentPage
    {
        private readonly APIService _RatingService = new APIService("Rating");

        public HowDoYouFeelPage()
        {
            InitializeComponent();
        }

        private async void Lista_ItemTapped(object sender, ItemTappedEventArgs e)
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
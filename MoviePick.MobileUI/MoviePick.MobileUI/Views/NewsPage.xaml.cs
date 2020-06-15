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
    public partial class NewsPage : ContentPage
    {
        NewsViewModel model = null;

        public NewsPage()
        {
            InitializeComponent();
            BindingContext = model = new NewsViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var item = e.Item as Data.Model.News;

            await Navigation.PushAsync(new NewsDetailsPage(item));
        }
    }
}
using MoviePick.Data.Model;
using MoviePick.MobileUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MoviePick.MobileUI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FullCastPage : ContentPage
    {
        public FullCastViewModel model = null;

        public FullCastPage(ObservableCollection<Data.Model.MovieAndTvshowPerson> movieAndTvshowPerson)
        {
            InitializeComponent();
            BindingContext = model = new FullCastViewModel()
            {
                Cast = movieAndTvshowPerson
            };
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.LoadRoles();
        }

        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var item = e.Item as Data.Model.MovieAndTvshowPerson;

            await Navigation.PushAsync(new PersonDetailsPage(item.Person));
        }

    }
}
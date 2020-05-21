using MoviePick.Data.Model;
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
    public partial class PersonDetailsPage : ContentPage
    {
        PersonDetailsViewModel model = null;

        public PersonDetailsPage(Person p)
        {
            InitializeComponent();
            BindingContext = model = new PersonDetailsViewModel()
            {
                person = p
            };
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.LoadMTVS();
        }

        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var item = e.Item as Data.Model.MovieAndTvshowPerson;

            await Navigation.PushAsync(new MTVSDetailsPage(item.MovieAndTvshow));
        }

        private async void btnOrderType_Clicked(object sender, EventArgs e)
        {
            if(btnOrderType.Text == "Order by : desc")
            {
                btnOrderType.Text = "Order by : asc";
                await model.LoadMTVS("asc");
            }
            else
            {
                btnOrderType.Text = "Order by : desc";
                await model.LoadMTVS();
            }
        }
    }
}
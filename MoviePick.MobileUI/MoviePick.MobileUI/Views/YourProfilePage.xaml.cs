using eProdaja.Mobile;
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
    public partial class YoutProfilePage : ContentPage
    {
        private readonly APIService _serviceUser = new APIService("User");

        public YoutProfilePage()
        {
            InitializeComponent();
            Username.Text = APIService.User.Username;
            FirstName.Text = APIService.User.FirstName;
            LastName.Text = APIService.User.LastName;
            Email.Text = APIService.User.Email;
            Phone.Text = APIService.User.Phone;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EditUserInformationsPage());
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewPasswordPage());
        }
    }
}
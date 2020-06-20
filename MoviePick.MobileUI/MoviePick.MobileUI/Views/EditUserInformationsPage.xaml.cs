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
    public partial class EditUserInformationsPage : ContentPage
    {
        private readonly APIService _serviceUser = new APIService("User");

        public EditUserInformationsPage()
        {
            InitializeComponent();
            FirstName.Text = APIService.User.FirstName;
            LastName.Text = APIService.User.LastName;
            Email.Text = APIService.User.Email;
            Phone.Text = APIService.User.Phone;
            Username.Text = APIService.User.Username;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(FirstName.Text) || string.IsNullOrWhiteSpace(LastName.Text) ||
                   string.IsNullOrWhiteSpace(Email.Text) || string.IsNullOrWhiteSpace(Phone.Text)
                   || string.IsNullOrWhiteSpace(Username.Text))
                {
                    await Application.Current.MainPage.DisplayAlert("Error", "All fields are required.", "Try again");
                    return;
                }

                if (Username.Text.Length < 4)
                {
                    await Application.Current.MainPage.DisplayAlert("Error", "Username must have minimum 4 characthers.", "Try again");
                    return;
                }

                var listUsers = await _serviceUser.Get<List<Data.Model.User>>(null);
                foreach (var item in listUsers)
                {
                    if (Username.Text == item.Username && APIService.Username != item.Username)
                    {
                        await Application.Current.MainPage.DisplayAlert("Error", "Username already exist.", "Try again");
                        return;
                    }
                }

                var newUser = await _serviceUser.Update<User>(APIService.UserId, new UserUpsertRequest
                {
                    Username = Username.Text,
                    FirstName = FirstName.Text,
                    LastName = LastName.Text,
                    Email = Email.Text,
                    Phone = Phone.Text,
                    UserTypeId = 2
                });


                if(newUser == default(User))
                    return;

                APIService.Password = Username.Text;
                await Application.Current.MainPage.DisplayAlert("Succesfull", "Succesfully changed, please log in to confirm changes.", "OK");
                await Navigation.PushAsync(new LoginPage());
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Something went wrong.", "Try again");
            }
        }
    }
}
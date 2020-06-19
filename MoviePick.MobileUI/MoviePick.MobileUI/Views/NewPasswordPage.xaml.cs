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
    public partial class NewPasswordPage : ContentPage
    {
        private readonly APIService _serviceUser = new APIService("User");

        public NewPasswordPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                if(OldPassword.Text != APIService.Password)
                {
                    await Application.Current.MainPage.DisplayAlert("Error", "Wrong old password.", "Try again");
                    return;
                }

                if(ConfirmPassword.Text != NewPassword.Text)
                {
                    await Application.Current.MainPage.DisplayAlert("Error", "Passwords are not matched.", "Try again");
                    return;
                }

                if (NewPassword.Text.Length < 4)
                {
                    await Application.Current.MainPage.DisplayAlert("Error", "Password must have minimum 4 characthers.", "Try again");
                    return;
                }

                await _serviceUser.Update<User>(APIService.UserId, new UserUpsertRequest
                {
                    Password = NewPassword.Text,
                    PasswordConfirm = ConfirmPassword.Text
                });

                APIService.Password = NewPassword.Text;
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
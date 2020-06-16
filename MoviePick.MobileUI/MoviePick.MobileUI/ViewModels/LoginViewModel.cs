using eProdaja.Mobile;
using MoviePick.Data.Request;
using MoviePick.MobileUI.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MoviePick.MobileUI.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private readonly APIService _service = new APIService("Comment");
        private readonly APIService _serviceUser = new APIService("User");

        public LoginViewModel()
        {
            LoginCommand = new Command(async () => await Login());
        }

        string _username = string.Empty;
        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }

        string _password = string.Empty;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }

        public ICommand LoginCommand { get; set; }

        async Task Login()
        {
            IsBusy = true;
            APIService.Username = Username;
            APIService.Password = Password;

            try
            {
                await _service.Get<dynamic>(null);
                List<Data.Model.User> temp = await _serviceUser.Get<List<Data.Model.User>>(new UserSearchRequest
                {
                    Username = Username
                });
                APIService.UserId = temp.Select(x => x.Id).FirstOrDefault();
                Application.Current.MainPage = new MainPage();
            }
            catch (Exception ex)
            {
                
            }
        }
    }
}

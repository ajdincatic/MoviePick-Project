using eProdaja.Mobile;
using MoviePick.Data.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MoviePick.MobileUI.ViewModels
{
    public class FullCastViewModel :BaseViewModel
    {
        private readonly APIService _RoleService = new APIService("Role");

        public FullCastViewModel()
        {
            InitCommand = new Command(async () => await LoadRoles());
        }

        public ObservableCollection<Data.Model.MovieAndTvshowPerson> Cast { get; set; }
        public ObservableCollection<Data.Model.Role> RolesList { get; set; } = new ObservableCollection<Role>();

        Role _selectedRole = null;
        public Role SelectedRole
        {
            get { return _selectedRole; }
            set
            {
                SetProperty(ref _selectedRole, value);
                if (value != null)
                {
                    InitCommand.Execute(null);
                }

            }
        }

        public ICommand InitCommand { get; set; }

        public async Task LoadRoles()
        {
            List<Role> roles = await _RoleService.Get<List<Role>>(null);
            RolesList.Clear();
            foreach (var item in roles)
            {
                RolesList.Add(item);
            }
        }
    }
}

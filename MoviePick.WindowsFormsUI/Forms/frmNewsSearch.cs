using eProdaja.WinUI;
using MoviePick.Data.Model;
using MoviePick.Data.Request;
using MoviePick.Data.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoviePick.WindowsFormsUI.Forms
{
    public partial class frmNewsSearch : Form
    {
        APIService _serviceNews = new APIService("News");
        APIService _serviceUser = new APIService("User");

        public frmNewsSearch()
        {
            InitializeComponent();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            await LoadNews();
        }

        private async void frmNewsSearch_Load(object sender, EventArgs e)
        {
            await LoadNews();
            await LoadUserNews();
        }

        private async Task LoadNews()
        {
            NewsSearchRequest request = new NewsSearchRequest
            {
                Title = txtTitle.Text
            };
            var list = await _serviceNews.GetAll<List<News>>(request);

            List<frmNewsSearchVM> vm = new List<frmNewsSearchVM>();

            foreach (var item in list)
            {
                frmNewsSearchVM ni = new frmNewsSearchVM
                {
                    Author = item.Author.Username,
                    Content = item.Content,
                    DateTimeOfNews = item.DateTimeOfNews,
                    Id = item.Id,
                    Title = item.Title
                };
                vm.Add(ni);
            }

            dgvNews.DataSource = vm;
        }

        private async Task LoadUserNews()
        {
            NewsSearchRequest request = new NewsSearchRequest();

            var x = await _serviceUser.GetAll<List<User>>(new UserSearchRequest { Username = APIService.username, UserTypeId = 1 });

            request.AuthorId = x.FirstOrDefault().Id;
            
            var list = await _serviceNews.GetAll<List<News>>(request);

            List<frmNewsSearchVM> vm = new List<frmNewsSearchVM>();

            foreach (var item in list)
            {
                frmNewsSearchVM ni = new frmNewsSearchVM
                {
                    Author = x.FirstOrDefault().Username,
                    Content = item.Content,
                    DateTimeOfNews = item.DateTimeOfNews,
                    Id = item.Id,
                    Title = item.Title
                };
                vm.Add(ni);
            }

            dgvUserNews.DataSource = vm;
        }

        private async void dgvUserNews_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmNewsSearchVM item = dgvUserNews.SelectedRows[0].DataBoundItem as frmNewsSearchVM;
            var x = await _serviceNews.GetById<News>(item.Id);
            frmNewsAdd frm = new frmNewsAdd(x);
            frm.WindowState = FormWindowState.Normal;
            frm.Show();
        }
    }
}

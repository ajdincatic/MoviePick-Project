using eProdaja.WinUI;
using MoviePick.Data.Model;
using MoviePick.Data.Request;
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
    public partial class frmCastAdd : Form
    {
        private APIService _serviceRole = new APIService("Role");
        private APIService _servicePersonMTVS;
        private APIService _servicePerson = new APIService("Person");

        private bool isTvShow;
        private int MTVSId;

        public frmCastAdd(int MTVSId, bool isTvShow = false)
        {
            this.isTvShow = isTvShow;
            this.MTVSId = MTVSId;
            _servicePersonMTVS = new APIService("MovieTvShow", "Person", MTVSId);
            InitializeComponent();
            dgvCast.AutoGenerateColumns = false;
        }

        protected async override void OnLoad(EventArgs e)
        {
            await LoadRoles();
            await LoadPersons();
            await LoadAllPersons();
        }

        protected override void OnClosed(EventArgs e)
        {
            if (isTvShow == true)
            {
                MessageBox.Show("Now add seasons and episodes for this TV Show !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmTvShowSeasonEpisodesAdd frm = new frmTvShowSeasonEpisodesAdd(MTVSId);
                frm.ShowDialog();
            }
        }

        private void cmbRole_SelectionChangeCommitted(object sender, EventArgs e)
        {
        }

        private async Task LoadRoles()
        {
            var list = await _serviceRole.GetAll<List<Role>>();
            cmbRole.ValueMember = "Id";
            cmbRoleSearch.ValueMember = "Id";
            cmbRole.DisplayMember = "RoleName";
            cmbRoleSearch.DisplayMember = "RoleName";
            cmbRole.DataSource = list;
            cmbRoleSearch.DataSource = list;
        }

        private async Task LoadPersons()
        {
            MovieAndTvshowPersonSearchRequest request = new MovieAndTvshowPersonSearchRequest();

            var idRoleTemp = cmbRoleSearch.SelectedValue;

            if (int.TryParse(idRoleTemp.ToString(), out int idRole))
            {
                request.RoleId = idRole;
            }

            var list = await _servicePersonMTVS.GetAll<List<Person>>(request);
            dgvCast.DataSource = list;
        }

        private async Task LoadAllPersons()
        {
            var list = await _servicePerson.GetAll<List<Person>>(null);
            list.Insert(0, new Person());
            cmbPerson.ValueMember = "Id";
            cmbPerson.DisplayMember = "LastName";
            cmbPerson.DataSource = list;
        }

        private async void btnAddCast_Click(object sender, EventArgs e)
        {
            MovieAndTvshowPersonUpsertRequest request = new MovieAndTvshowPersonUpsertRequest()
            {
                NameInMovie=txtName.Text,
            };

            var idPerson = cmbPerson.SelectedValue;

            if (int.TryParse(idPerson.ToString(), out int personId))
            {
                request.PersonId = personId;
            }

            var idRole = cmbRole.SelectedValue;

            if (int.TryParse(idRole.ToString(), out int id))
            {
                request.RoleId = id;
            }

            await _servicePersonMTVS.Insert<Data.Model.MovieAndTvshowPerson>(request);

            MessageBox.Show("Operation successfully completed");
            txtName.Text = "";

            await LoadPersons();
        }

        private async void cmbRoleSearch_SelectionChangeCommitted(object sender, EventArgs e)
        {
            await LoadPersons();
        }

        private async void dgvCast_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //Person item = dgvCast.SelectedRows[0].DataBoundItem as Person;
            //MovieAndTvshowDeleteRequest request = new MovieAndTvshowDeleteRequest
            //{
            //    PersonId = item.Id,
            //};

            //var idRole = cmbRole.SelectedValue;

            //if (int.TryParse(idRole.ToString(), out int id))
            //{
            //    request.RoleId = id;
            //}

            //await _servicePerson.Delete<MovieAndTvshowPerson>(item.Id, request);
            //await LoadPersons();
        }
    }
}

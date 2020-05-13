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
    public partial class frmPersonSearch : Form
    {
        APIService _servicePerson = new APIService("Person");

        public frmPersonSearch()
        {
            InitializeComponent();
        }

        protected async override void OnLoad(EventArgs e)
        {
            dgvPersons.AutoGenerateColumns = false;
            await LoadPerson();
        }

        private async Task LoadPerson()
        {
            PersonSearchRequest request = new PersonSearchRequest()
            {
                FirstName=txtFirstName.Text,
                LastName=txtLastName.Text,
            };

            if (chkMale.Checked)
                request.Gender = "M";
            else if (chkFemale.Checked)
                request.Gender = "F";
            else
                request.Gender = null;

            var list =await _servicePerson.GetAll<List<Person>>(request);

            dgvPersons.DataSource = list;
        }

        private void dgvPersons_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var item = dgvPersons.SelectedRows[0].DataBoundItem;
            frmPersonDetails frm = new frmPersonDetails(item as Person);
            frm.WindowState = FormWindowState.Normal;
            frm.Show();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            await LoadPerson();
        }
    }
}

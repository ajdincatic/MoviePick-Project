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
    public partial class frmUserAdd : Form
    {
        APIService _serviceUser = new APIService("User");
        APIService _serviceUserType = new APIService("UserType");

        private User _user;

        public frmUserAdd(User user = null)
        {
            InitializeComponent();
            _user = user;
        }

        private async void frmUserAdd_Load(object sender, EventArgs e)
        {
            await LoadTypes();
            if(_user != null)
            {
                txtUsername.Text = _user.Username;
                txtEmail.Text = _user.Email;
                txtFirstName.Text = _user.FirstName;
                txtLastName.Text = _user.LastName;
                txtPhone.Text = _user.Phone;
                cmbType.SelectedValue = _user.UserTypeId;
                btnSave.Visible = false;
                txtPassword.ReadOnly = true;
                txtPasswordConfirm.ReadOnly = true;
                chkShow.Visible = false;
                chkGenerate.Visible = false;
                btnDelete.Visible = true;
            }
        }

        private async Task LoadTypes()
        {
            var list = await _serviceUserType.GetAll<List<UserType>>();
            cmbType.ValueMember = "Id";
            cmbType.DisplayMember = "Type";
            cmbType.DataSource = list;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            UserUpsertRequest request = new UserUpsertRequest
            {
                Username = txtUsername.Text,
                Email = txtEmail.Text,
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Password = txtPassword.Text,
                PasswordConfirm = txtPasswordConfirm.Text,
                Phone = txtPhone.Text,
            };

            var idType = cmbType.SelectedValue;

            if (int.TryParse(idType.ToString(), out int typeId))
            {
                request.UserTypeId = typeId;
            }

            if (_user == null)
            {
                var mtvs = await _serviceUser.Insert<User>(request);
            }

            MessageBox.Show("Operation successfully completed, now assign cast !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void chkGenerate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGenerate.Checked)
            {
                var guid = Guid.NewGuid().ToString().Substring(0, 8);
                txtPassword.Text = guid;
                txtPasswordConfirm.Text = guid;
            }
            else
            {
                txtPassword.Text = "";
                txtPasswordConfirm.Text = "";
            }
        }

        private void chkShow_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShow.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtPasswordConfirm.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
                txtPasswordConfirm.PasswordChar = '*';
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want do delete this record?", "Warining", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var MTVS = await _serviceUser.Delete<User>(_user.Id);
                this.Close();
            }
        }
    }
}

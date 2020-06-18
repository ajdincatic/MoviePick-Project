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

        private List<User> Users = null;

        public frmUserAdd(User user = null)
        {
            InitializeComponent();
            _user = user;
        }

        private async void frmUserAdd_Load(object sender, EventArgs e)
        {
            await LoadTypes();
            await LoadUsers();
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
                txtPassword.Enabled = false;
                txtPasswordConfirm.ReadOnly = true;
                txtPasswordConfirm.Enabled = false;
                chkShow.Visible = false;
                chkGenerate.Visible = false;
            }
        }

        private async Task LoadTypes()
        {
            var list = await _serviceUserType.GetAll<List<UserType>>();
            list.Insert(0, new UserType());
            cmbType.ValueMember = "Id";
            cmbType.DisplayMember = "Type";
            cmbType.DataSource = list;
        }

        private async Task LoadUsers()
        {
            Users = await _serviceUser.GetAll<List<User>>();
        }


        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
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

                MessageBox.Show("Operation successfully completed!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
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

        //private async void btnDelete_Click(object sender, EventArgs e)
        //{
        //    DialogResult result = MessageBox.Show("Do you want do delete this record?", "Warining", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        //    if (result == DialogResult.Yes)
        //    {
        //        var MTVS = await _serviceUser.Delete<User>(_user.Id);
        //        this.Close();
        //    }
        //}

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                errorProvider.SetError(txtFirstName, "Required");
                //e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtFirstName, null);
            }
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                errorProvider.SetError(txtLastName, "Required");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtLastName, null);
            }
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            bool flag = false;
            foreach (var item in Users)
            {
                if (item.Username == txtUsername.Text)
                {
                    flag = true;
                    break;
                }
            }
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                errorProvider.SetError(txtUsername, "Required");
                e.Cancel = true;
            }
            else if (flag)
            {
                errorProvider.SetError(txtUsername, "Username already exists");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtUsername, null);
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                errorProvider.SetError(txtPassword, "Required");
                e.Cancel = true;
            }
            else if(txtPassword.Text.Length < 4)
            {
                errorProvider.SetError(txtPassword, "You must have minimum 4 characters.");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtPassword, null);
            }
        }

        private void txtPasswordConfirm_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPasswordConfirm.Text))
            {
                errorProvider.SetError(txtPasswordConfirm, "Required");
                e.Cancel = true;
            }
            else if(txtPassword.Text != txtPasswordConfirm.Text)
            {
                errorProvider.SetError(txtPasswordConfirm, "Passwords not matched.");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtPasswordConfirm, null);
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProvider.SetError(txtEmail, "Required");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtEmail, null);
            }
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                errorProvider.SetError(txtPhone, "Required");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtPhone, null);
            }
        }

        private void cmbType_Validating(object sender, CancelEventArgs e)
        {
            if (cmbType.SelectedIndex == 0)
            {
                errorProvider.SetError(cmbType, "Required");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(cmbType, null);
            }
        }
    }
}

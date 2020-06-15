using eProdaja.WinUI;
using MoviePick.Data.Model;
using MoviePick.Data.Request;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoviePick.WindowsFormsUI.Forms
{
    public partial class frmPersonAdd : Form
    {
        APIService _servicePerson = new APIService("Person");

        public frmPersonAdd()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
        }

        PersonUpsertRequest request = new PersonUpsertRequest();

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                request.Biography = rtxtBio.Text;
                request.DateOfBirth = dtDateOfBirth.Value;
                request.PlaceOfBirth = txtPlaceBirth.Text;
                request.FirstName = txtFirstName.Text;
                request.LastName = txtLastName.Text;
                request.Gender = txtGender.Text;
                if (!chkDead.Checked)
                    request.DateOfDeath = dtpDateOfDeath.Value;

                await _servicePerson.Insert<Data.Model.Person>(request);

                MessageBox.Show("Operation successfully completed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            var result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                var fileName = openFileDialog.FileName;
                var file = File.ReadAllBytes(fileName);
                request.Photo = file;
                txtPhoto.Text = fileName;

                Image img = Image.FromFile(fileName);
                pictureBox1.Image = img;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void txtPhoto_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPhoto.Text))
            {
                errorProvider.SetError(txtPhoto, "Required");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtPhoto, null);
            }
        }

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

        private void rtxtBio_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rtxtBio.Text))
            {
                errorProvider.SetError(rtxtBio, "Required");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(rtxtBio, null);
            }
        }

        private void txtGender_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGender.Text))
            {
                errorProvider.SetError(txtGender, "Required");
                e.Cancel = true;
            }
            else if(txtGender.Text != "M" && txtGender.Text != "F")
            {
                errorProvider.SetError(txtGender, "Value must be F or M.");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtGender, null);
            }
        }

        private void txtPlaceBirth_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPlaceBirth.Text))
            {
                errorProvider.SetError(txtPlaceBirth, "Required");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtPlaceBirth, null);
            }
        }
    }
}

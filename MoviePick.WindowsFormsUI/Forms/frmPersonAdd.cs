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
            request.Biography = rtxtBio.Text;
            request.DateOfBirth = dtDateOfBirth.Value;
            request.PlaceOfBirth = txtPlaceBirth.Text;
            request.FirstName = txtFirstName.Text;
            request.LastName = txtLastName.Text;
            request.Gender = txtGender.Text;

            await _servicePerson.Insert<Data.Model.Person>(request);

            MessageBox.Show("Operation successfully completed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
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
    }
}

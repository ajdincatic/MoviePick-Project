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

        private Person _person;

        public frmPersonAdd(Person person = null)
        {
            _person = person;
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            if(_person != null)
            {
                rtxtBio.Text = _person.Biography;
                dtDateOfBirth.Value = _person.DateOfBirth;
                txtPlaceBirth.Text = _person.PlaceOfBirth;
                txtFirstName.Text = _person.FirstName;
                txtLastName.Text = _person.LastName;
                txtGender.Text = _person.Gender;
                if (_person.Photo != null && _person.Photo.Length > 0)
                {
                    pictureBox1.Image = GetImage(_person.Photo);
                    request.Photo = _person.Photo;
                }
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
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

            if (_person == null)
                await _servicePerson.Insert<Data.Model.Person>(request);
            else
                await _servicePerson.Update<Data.Model.Person>(_person.Id, request);

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

        private static Image GetImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return (Image.FromStream(ms));
            }
        }
    }
}

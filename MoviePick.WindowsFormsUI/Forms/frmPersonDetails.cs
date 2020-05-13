using eProdaja.WinUI;
using MoviePick.Data.Model;
using MoviePick.Data.Request;
using MoviePick.Data.ViewModel;
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
    public partial class frmPersonDetails : Form
    {
        APIService _servicePerson = new APIService("Person");
        APIService _serviceCast = new APIService("Cast");
        APIService _serviceMTVS = new APIService("MovieAndTvShow");

        private Person _person;

        public frmPersonDetails(Person person = null)
        {
            _person = person;
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            if (_person != null)
            {
                rtxtBio.Text = _person.Biography;
                dtDateOfBirth.Value = _person.DateOfBirth;
                txtPlaceBirth.Text = _person.PlaceOfBirth;
                txtFirstName.Text = _person.FirstName;
                txtLastName.Text = _person.LastName;
                txtGender.Text = _person.Gender;
                if (_person.DateOfDeath != null)
                {
                    dtpDateOfDeath.Value = (DateTime)_person.DateOfDeath;
                    chkDisable.Checked = false;
                }
                if (_person.Photo != null && _person.Photo.Length > 0)
                {
                    pictureBox1.Image = GetImage(_person.Photo);
                    request.Photo = _person.Photo;
                }
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                LoadRoles();
            }
        }

        private void LoadRoles()
        {
            List<frmPersonDetailsVM> vm = new List<frmPersonDetailsVM>();
            foreach (var item in _person.MovieAndTvshowPerson)
            {
                frmPersonDetailsVM ni = new frmPersonDetailsVM
                {
                    Id = item.MovieAndTvshowId,
                    NameInMovie = item.NameInMovie,
                    ReleaseDate = item.MovieAndTvshow.ReleaseDate,
                    RoleName = item.Role.RoleName,
                    Title = item.MovieAndTvshow.Title
                };
                vm.Add(ni);
            }
            vm = vm.OrderByDescending(x => x.ReleaseDate).ToList();
            dgvMTVS.DataSource = vm;
        }

        PersonUpsertRequest request = new PersonUpsertRequest();

        private async void btnSave_Click(object sender, EventArgs e)
        {
            request.Biography = rtxtBio.Text;
            request.DateOfBirth = dtDateOfBirth.Value;
            request.DateOfDeath = dtDateOfBirth.Value;
            request.PlaceOfBirth = txtPlaceBirth.Text;
            request.FirstName = txtFirstName.Text;
            request.LastName = txtLastName.Text;
            request.Gender = txtGender.Text;
            if (!chkDisable.Checked)
                request.DateOfDeath = dtpDateOfDeath.Value;

            await _servicePerson.Update<Data.Model.Person>(_person.Id, request);

            MessageBox.Show("Operation successfully completed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private static Image GetImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return (Image.FromStream(ms));
            }
        }

        private async void dgvMTVS_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dgvMTVS.SelectedRows[0].DataBoundItem;
            var MTVS = await _serviceMTVS.GetById<MovieAndTvshow>((item as frmPersonDetailsVM).Id);
            frmMovieAndTvShowDetails frm = new frmMovieAndTvShowDetails(MTVS);
            frm.WindowState = FormWindowState.Normal;
            frm.Show();
        }

        private void btnImage_Click_1(object sender, EventArgs e)
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

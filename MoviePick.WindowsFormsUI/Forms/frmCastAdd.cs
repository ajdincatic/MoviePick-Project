﻿using eProdaja.WinUI;
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
    public partial class frmCastAdd : Form
    {
        private APIService _serviceRole = new APIService("Role");
        private APIService _servicePerson = new APIService("Person");
        private APIService _serviceCast = new APIService("Cast");

        private MovieAndTvshow MTVS;
        private bool isTvShow;

        public frmCastAdd(MovieAndTvshow MTVS, bool isTvShow = false)
        {
            this.isTvShow = isTvShow;
            this.MTVS = MTVS;
            InitializeComponent();
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
                frmTvShowSeasonEpisodesAdd frm = new frmTvShowSeasonEpisodesAdd(MTVS);
                frm.ShowDialog();
            }
        }

        private void cmbRole_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if(cmbRole.SelectedIndex != 0)
            {
                txtName.Visible = false;
            }
            else
            {
                txtName.Visible = true;
            }
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
            request.MovieAndTvshowId = MTVS.Id;

            var list = await _serviceCast.GetAll<List<MovieAndTvshowPerson>>(request);

            List<frmCastAddPersonListVM> vm = new List<frmCastAddPersonListVM>();
            foreach (var x in list)
            {
                frmCastAddPersonListVM nl = new frmCastAddPersonListVM
                {
                    MTVSPId = x.Id,
                    PersonId = x.PersonId,
                    Name = x.Person.FirstName + " " + x.Person.LastName,
                    Gender = x.Person.Gender,
                    NameInMovie = x.NameInMovie,
                    DateOfBirth = x.Person.DateOfBirth
                };
                vm.Add(nl);
            }

            dgvCast.DataSource = vm;
        }

        private async Task LoadAllPersons()
        {
            var list = await _servicePerson.GetAll<List<Person>>(null);
            //foreach (var x in list)
            //{
            //    lvPerson.Items.Add(new ListViewItem(x));
            //}
        }

        private async void btnAddCast_Click(object sender, EventArgs e)
        {
            MovieAndTvshowPersonUpsertRequest request = new MovieAndTvshowPersonUpsertRequest()
            {
                NameInMovie = txtName.Text,
                MovieAndTvshowId = MTVS.Id
            };

            //var idPerson = cmbPerson.SelectedValue;

            //if (int.TryParse(idPerson.ToString(), out int personId))
            //{
            //    request.PersonId = personId;
            //}
            request.PersonId = 1;

            var idRole = cmbRole.SelectedValue;

            if (int.TryParse(idRole.ToString(), out int id))
            {
                request.RoleId = id;
            }

            await _serviceCast.Insert<Data.Model.MovieAndTvshowPerson>(request);

            MessageBox.Show("Operation successfully completed");
            txtName.Text = "";

            await LoadPersons();
        }

        private async void cmbRoleSearch_SelectionChangeCommitted(object sender, EventArgs e)
        {
            await LoadPersons();
        }

    }
}
using eProdaja.WinUI;
using MoviePick.Data.Model;
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
        APIService _serviceRole = new APIService("Role");

        private bool isTvShow;

        public frmCastAdd(bool isTvShow = false)
        {
            this.isTvShow = isTvShow;
            InitializeComponent();
        }

        protected async override void OnLoad(EventArgs e)
        {
            await LoadRoles();
        }

        protected override void OnClosed(EventArgs e)
        {
            if (isTvShow == true)
            {
                MessageBox.Show("Now add seasons and episodes for this TV Show !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmTvShowSeasonEpisodesAdd frm = new frmTvShowSeasonEpisodesAdd();
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
            cmbRole.DisplayMember = "RoleName";
            cmbRole.DataSource = list;
        }

        private void btnAddCast_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Operation successfully completed");
        }
    }
}

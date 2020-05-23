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
    public partial class frmIndex : Form
    {
        private int childFormNumber = 0;

        public frmIndex()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            frmHome childForm = new frmHome();
            childForm.MdiParent = this;
            childForm.Text = "Home";
            childForm.Show();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }


        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMovieTvShowSearch frm = new frmMovieTvShowSearch();
            frm.MdiParent = this;
            frm.Show();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMovieTvShowAdd frm = new frmMovieTvShowAdd();
            frm.MdiParent = this;
            frm.Show();
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPersonAdd frm = new frmPersonAdd();
            frm.MdiParent = this;
            frm.Show();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHome frm = new frmHome();
            frm.MdiParent = this;
            frm.Show();
        }

        private void searchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPersonSearch frm = new frmPersonSearch();
            frm.MdiParent = this;
            frm.Show();
        }

        private void addToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmUserAdd frm = new frmUserAdd();
            frm.MdiParent = this;
            frm.Show();
        }

        private void searchToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmUserSearch frm = new frmUserSearch();
            frm.MdiParent = this;
            frm.Show();
        }

        private void addToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmNewsAdd frm = new frmNewsAdd();
            frm.MdiParent = this;
            frm.Show();
        }

        private void searchToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmNewsSearch frm = new frmNewsSearch();
            frm.MdiParent = this;
            frm.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout frm = new frmAbout();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}

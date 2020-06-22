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
    public partial class frmRptUser : Form
    {
        private List<frmUserSearchVM> _source;
        public frmRptUser(List<frmUserSearchVM> _source)
        {
            InitializeComponent();
            this._source = _source;
        }

        private void frmRptUser_Load(object sender, EventArgs e)
        {
            frmUserSearchVMBindingSource.DataSource = _source;
            this.reportViewer1.RefreshReport();
        }
    }
}

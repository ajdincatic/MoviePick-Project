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
    public partial class frmRptNews : Form
    {
        List<frmNewsSearchVM> _source;
        public frmRptNews(List<frmNewsSearchVM> source)
        {
            InitializeComponent();
            _source = source;
        }

        private void frmRptNews_Load(object sender, EventArgs e)
        {
            frmNewsSearchVMBindingSource.DataSource = _source;
            this.reportViewer1.RefreshReport();
        }
    }
}

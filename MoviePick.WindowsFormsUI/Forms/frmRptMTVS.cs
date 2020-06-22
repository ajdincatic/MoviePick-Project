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
    public partial class frmRptMTVS : Form
    {
        private List<frmMovieTvShowSearchVM> _source;
        
        public frmRptMTVS(List<frmMovieTvShowSearchVM> _source)
        {
            InitializeComponent();
            this._source = _source;
        }

        private void frmRptMTVS_Load(object sender, EventArgs e)
        {
            frmMovieTvShowSearchVMBindingSource.DataSource = _source;
            this.reportViewer1.RefreshReport();
        }
    }
}

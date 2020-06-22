using MoviePick.Data.Model;
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
    public partial class frmRptPerson : Form
    {
        private List<Person> _source;

        public frmRptPerson(List<Person> source)
        {
            InitializeComponent();
            _source = source;
        }

        private void frmRptPerson_Load(object sender, EventArgs e)
        {
            PersonBindingSource.DataSource = _source;
            this.reportViewer1.RefreshReport();
        }
    }
}

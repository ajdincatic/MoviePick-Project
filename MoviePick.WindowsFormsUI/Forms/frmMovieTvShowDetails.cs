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
    public partial class frmMovieTvShowDetails : Form
    {
        private MovieAndTvshow _movieAndTvshow;

        public frmMovieTvShowDetails(MovieAndTvshow movieAndTvshow = null)
        {
            InitializeComponent();
            _movieAndTvshow = movieAndTvshow;
        }
    }
}

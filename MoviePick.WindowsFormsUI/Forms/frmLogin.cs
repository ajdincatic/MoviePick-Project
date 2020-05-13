using eProdaja.WinUI;
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
    public partial class frmLogin : Form
    {
        APIService _service = new APIService("UserType");

        public frmLogin()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                APIService.username = textBox1.Text;
                APIService.password = textBox2.Text;
                await _service.GetAll<dynamic>(null);

                frmIndex frm = new frmIndex();
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wrong username or password.", "Warining", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

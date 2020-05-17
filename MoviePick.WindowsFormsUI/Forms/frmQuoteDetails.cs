using eProdaja.WinUI;
using MoviePick.Data.Model;
using MoviePick.Data.Request;
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
    public partial class frmQuoteDetails : Form
    {
        private APIService _serviceQuote = new APIService("Quote");

        private MovieAndTvshow _MTVS;

        public frmQuoteDetails(MovieAndTvshow MTVS)
        {
            _MTVS = MTVS;
            InitializeComponent();
        }

        protected async override void OnLoad(EventArgs e)
        {
            dgvQuotes.AutoGenerateColumns = false;
            await LoadQuotes();
        }

        private async Task LoadQuotes()
        {
            QuoteSearchRequest request = new QuoteSearchRequest
            {
                MovieAndTvshowId = _MTVS.Id
            };

            var list = await _serviceQuote.GetAll<List<Quote>>(request);
            dgvQuotes.DataSource = list;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                QuoteUpsertRequest request = new QuoteUpsertRequest
                {
                    MovieAndTvshowId = _MTVS.Id,
                    QuoteText = txtQuote.Text
                };
                await _serviceQuote.Insert<Quote>(request);
                await LoadQuotes();
            }
        }

        private async void dgvQuotes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Quote item = dgvQuotes.SelectedRows[0].DataBoundItem as Quote;
            DialogResult result = MessageBox.Show("Do you want do delete this record?", "Warining", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var MTVS = await _serviceQuote.Delete<Quote>(item.Id);
            }
            await LoadQuotes();
        }

        private void txtQuote_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtQuote.Text))
            {
                errorProvider.SetError(txtQuote, "Required");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtQuote, null);
            }
        }
    }
}

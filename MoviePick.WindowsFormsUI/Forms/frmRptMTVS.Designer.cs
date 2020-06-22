namespace MoviePick.WindowsFormsUI.Forms
{
    partial class frmRptMTVS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.frmMovieTvShowSearchVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.frmMovieTvShowSearchVMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // frmMovieTvShowSearchVMBindingSource
            // 
            this.frmMovieTvShowSearchVMBindingSource.DataSource = typeof(MoviePick.Data.ViewModel.frmMovieTvShowSearchVM);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = System.Windows.Forms.AnchorStyles.None;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.frmMovieTvShowSearchVMBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MoviePick.WindowsFormsUI.Reports.rptMTVS.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1284, 747);
            this.reportViewer1.TabIndex = 0;
            // 
            // frmRptMTVS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 747);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmRptMTVS";
            this.Text = "frmRptMTVS";
            this.Load += new System.EventHandler(this.frmRptMTVS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.frmMovieTvShowSearchVMBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource frmMovieTvShowSearchVMBindingSource;
    }
}
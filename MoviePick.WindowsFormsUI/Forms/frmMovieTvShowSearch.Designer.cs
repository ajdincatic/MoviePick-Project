namespace MoviePick.WindowsFormsUI.Forms
{
    partial class frmMovieTvShowSearch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMovieTvShowSearch));
            this.dgvMTVS = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbGenre = new System.Windows.Forms.ComboBox();
            this.Genre = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReleaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RunningTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Language = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Finished = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMTVS)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMTVS
            // 
            this.dgvMTVS.AllowUserToAddRows = false;
            this.dgvMTVS.AllowUserToDeleteRows = false;
            this.dgvMTVS.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMTVS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMTVS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMTVS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Title,
            this.ReleaseDate,
            this.RunningTime,
            this.Language,
            this.Finished});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMTVS.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMTVS.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvMTVS.Location = new System.Drawing.Point(12, 258);
            this.dgvMTVS.Name = "dgvMTVS";
            this.dgvMTVS.ReadOnly = true;
            this.dgvMTVS.RowHeadersWidth = 51;
            this.dgvMTVS.RowTemplate.Height = 30;
            this.dgvMTVS.Size = new System.Drawing.Size(1340, 470);
            this.dgvMTVS.TabIndex = 0;
            this.dgvMTVS.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMTVS_CellDoubleClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(877, 79);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(111, 36);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(546, 79);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(305, 34);
            this.txtTitle.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(374, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Title";
            // 
            // cmbGenre
            // 
            this.cmbGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGenre.FormattingEnabled = true;
            this.cmbGenre.Location = new System.Drawing.Point(546, 128);
            this.cmbGenre.Name = "cmbGenre";
            this.cmbGenre.Size = new System.Drawing.Size(305, 37);
            this.cmbGenre.TabIndex = 6;
            this.cmbGenre.SelectionChangeCommitted += new System.EventHandler(this.cmbGenre_SelectionChangeCommitted);
            // 
            // Genre
            // 
            this.Genre.AutoSize = true;
            this.Genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Genre.Location = new System.Drawing.Point(374, 136);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(80, 29);
            this.Genre.TabIndex = 7;
            this.Genre.Text = "Genre";
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.Frozen = true;
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 125;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 125;
            // 
            // ReleaseDate
            // 
            this.ReleaseDate.DataPropertyName = "ReleaseDate";
            this.ReleaseDate.HeaderText = "ReleaseDate";
            this.ReleaseDate.MinimumWidth = 6;
            this.ReleaseDate.Name = "ReleaseDate";
            this.ReleaseDate.ReadOnly = true;
            this.ReleaseDate.Width = 125;
            // 
            // RunningTime
            // 
            this.RunningTime.DataPropertyName = "RunningTime";
            this.RunningTime.HeaderText = "RunningTime";
            this.RunningTime.MinimumWidth = 6;
            this.RunningTime.Name = "RunningTime";
            this.RunningTime.ReadOnly = true;
            this.RunningTime.Width = 125;
            // 
            // Language
            // 
            this.Language.DataPropertyName = "Language";
            this.Language.HeaderText = "Language";
            this.Language.MinimumWidth = 6;
            this.Language.Name = "Language";
            this.Language.ReadOnly = true;
            this.Language.Width = 125;
            // 
            // Finished
            // 
            this.Finished.DataPropertyName = "Finished";
            this.Finished.HeaderText = "Finished";
            this.Finished.MinimumWidth = 6;
            this.Finished.Name = "Finished";
            this.Finished.ReadOnly = true;
            this.Finished.Width = 125;
            // 
            // frmMovieTvShowSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1364, 740);
            this.Controls.Add(this.Genre);
            this.Controls.Add(this.cmbGenre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvMTVS);
            this.Name = "frmMovieTvShowSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Search";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMTVS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMTVS;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbGenre;
        private System.Windows.Forms.Label Genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReleaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn RunningTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Language;
        private System.Windows.Forms.DataGridViewTextBoxColumn Finished;
    }
}
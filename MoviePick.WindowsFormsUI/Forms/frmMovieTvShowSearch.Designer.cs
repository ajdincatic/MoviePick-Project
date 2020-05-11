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
            this.dgvMTVS = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbGenre = new System.Windows.Forms.ComboBox();
            this.Genre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbMovie = new System.Windows.Forms.RadioButton();
            this.rbTvShow = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMTVS)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMTVS
            // 
            this.dgvMTVS.AllowUserToAddRows = false;
            this.dgvMTVS.AllowUserToDeleteRows = false;
            this.dgvMTVS.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMTVS.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMTVS.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvMTVS.Location = new System.Drawing.Point(12, 279);
            this.dgvMTVS.Name = "dgvMTVS";
            this.dgvMTVS.ReadOnly = true;
            this.dgvMTVS.RowHeadersWidth = 51;
            this.dgvMTVS.RowTemplate.Height = 30;
            this.dgvMTVS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMTVS.Size = new System.Drawing.Size(1340, 459);
            this.dgvMTVS.TabIndex = 0;
            this.dgvMTVS.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMTVS_CellDoubleClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(821, 111);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(111, 36);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(510, 39);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(305, 34);
            this.txtTitle.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(505, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Title";
            // 
            // cmbGenre
            // 
            this.cmbGenre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGenre.FormattingEnabled = true;
            this.cmbGenre.Location = new System.Drawing.Point(511, 197);
            this.cmbGenre.Name = "cmbGenre";
            this.cmbGenre.Size = new System.Drawing.Size(305, 37);
            this.cmbGenre.TabIndex = 6;
            this.cmbGenre.SelectionChangeCommitted += new System.EventHandler(this.cmbGenre_SelectionChangeCommitted);
            // 
            // Genre
            // 
            this.Genre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Genre.AutoSize = true;
            this.Genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Genre.Location = new System.Drawing.Point(505, 165);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(80, 29);
            this.Genre.TabIndex = 7;
            this.Genre.Text = "Genre";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(506, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Type";
            // 
            // rbMovie
            // 
            this.rbMovie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbMovie.AutoSize = true;
            this.rbMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMovie.Location = new System.Drawing.Point(513, 114);
            this.rbMovie.Name = "rbMovie";
            this.rbMovie.Size = new System.Drawing.Size(99, 33);
            this.rbMovie.TabIndex = 10;
            this.rbMovie.TabStop = true;
            this.rbMovie.Text = "Movie";
            this.rbMovie.UseVisualStyleBackColor = true;
            // 
            // rbTvShow
            // 
            this.rbTvShow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbTvShow.AutoSize = true;
            this.rbTvShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTvShow.Location = new System.Drawing.Point(618, 114);
            this.rbTvShow.Name = "rbTvShow";
            this.rbTvShow.Size = new System.Drawing.Size(128, 33);
            this.rbTvShow.TabIndex = 11;
            this.rbTvShow.TabStop = true;
            this.rbTvShow.Text = "Tv Show";
            this.rbTvShow.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(1130, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "* double click on record for details";
            // 
            // frmMovieTvShowSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1364, 760);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbTvShow);
            this.Controls.Add(this.rbMovie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Genre);
            this.Controls.Add(this.cmbGenre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvMTVS);
            this.Name = "frmMovieTvShowSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Search Movie and TV Show";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbMovie;
        private System.Windows.Forms.RadioButton rbTvShow;
        private System.Windows.Forms.Label label3;
    }
}
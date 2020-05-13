namespace MoviePick.WindowsFormsUI.Forms
{
    partial class frmTvShowSeasonEpisodesAdd
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
            this.dgvEpisodes = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EpisodeNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EpisodeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AirDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNewSeason = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSeasonName = new System.Windows.Forms.TextBox();
            this.chkFinished = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtEpNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpAirDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEpisodeName = new System.Windows.Forms.TextBox();
            this.cmbSeasonAdd = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddEpisode = new System.Windows.Forms.Button();
            this.cmbSeasons = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEpisodes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEpisodes
            // 
            this.dgvEpisodes.AllowUserToAddRows = false;
            this.dgvEpisodes.AllowUserToDeleteRows = false;
            this.dgvEpisodes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvEpisodes.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEpisodes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEpisodes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEpisodes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.EpisodeNumber,
            this.EpisodeName,
            this.AirDate});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEpisodes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEpisodes.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvEpisodes.Location = new System.Drawing.Point(114, 306);
            this.dgvEpisodes.Name = "dgvEpisodes";
            this.dgvEpisodes.ReadOnly = true;
            this.dgvEpisodes.RowHeadersWidth = 51;
            this.dgvEpisodes.RowTemplate.Height = 24;
            this.dgvEpisodes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEpisodes.Size = new System.Drawing.Size(1138, 419);
            this.dgvEpisodes.TabIndex = 3;
            this.dgvEpisodes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEpisodes_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 125;
            // 
            // EpisodeNumber
            // 
            this.EpisodeNumber.DataPropertyName = "EpisodeNumber";
            this.EpisodeNumber.HeaderText = "EpisodeNumber";
            this.EpisodeNumber.MinimumWidth = 6;
            this.EpisodeNumber.Name = "EpisodeNumber";
            this.EpisodeNumber.ReadOnly = true;
            this.EpisodeNumber.Width = 155;
            // 
            // EpisodeName
            // 
            this.EpisodeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EpisodeName.DataPropertyName = "EpisodeName";
            this.EpisodeName.HeaderText = "EpisodeName";
            this.EpisodeName.MinimumWidth = 6;
            this.EpisodeName.Name = "EpisodeName";
            this.EpisodeName.ReadOnly = true;
            // 
            // AirDate
            // 
            this.AirDate.DataPropertyName = "AirDate";
            this.AirDate.HeaderText = "AirDate";
            this.AirDate.MinimumWidth = 6;
            this.AirDate.Name = "AirDate";
            this.AirDate.ReadOnly = true;
            this.AirDate.Width = 125;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(436, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Season";
            // 
            // btnNewSeason
            // 
            this.btnNewSeason.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewSeason.Location = new System.Drawing.Point(384, 134);
            this.btnNewSeason.Name = "btnNewSeason";
            this.btnNewSeason.Size = new System.Drawing.Size(152, 38);
            this.btnNewSeason.TabIndex = 6;
            this.btnNewSeason.Text = "Add new season";
            this.btnNewSeason.UseVisualStyleBackColor = true;
            this.btnNewSeason.Click += new System.EventHandler(this.btnNewSeason_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Episodes";
            // 
            // txtSeasonName
            // 
            this.txtSeasonName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeasonName.Location = new System.Drawing.Point(206, 52);
            this.txtSeasonName.Name = "txtSeasonName";
            this.txtSeasonName.Size = new System.Drawing.Size(330, 27);
            this.txtSeasonName.TabIndex = 9;
            // 
            // chkFinished
            // 
            this.chkFinished.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkFinished.AutoSize = true;
            this.chkFinished.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkFinished.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFinished.Location = new System.Drawing.Point(426, 85);
            this.chkFinished.Name = "chkFinished";
            this.chkFinished.Size = new System.Drawing.Size(94, 24);
            this.chkFinished.TabIndex = 10;
            this.chkFinished.Text = "Finished";
            this.chkFinished.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkFinished.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Season name";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.txtSeasonName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnNewSeason);
            this.groupBox1.Controls.Add(this.chkFinished);
            this.groupBox1.Location = new System.Drawing.Point(123, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(564, 187);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add season";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.txtEpNumber);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dtpAirDate);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtEpisodeName);
            this.groupBox2.Controls.Add(this.cmbSeasonAdd);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnAddEpisode);
            this.groupBox2.Location = new System.Drawing.Point(693, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(564, 187);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add episode";
            // 
            // txtEpNumber
            // 
            this.txtEpNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEpNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEpNumber.Location = new System.Drawing.Point(502, 101);
            this.txtEpNumber.Name = "txtEpNumber";
            this.txtEpNumber.Size = new System.Drawing.Size(40, 27);
            this.txtEpNumber.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(376, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Episode Nr.";
            // 
            // dtpAirDate
            // 
            this.dtpAirDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAirDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAirDate.Location = new System.Drawing.Point(212, 99);
            this.dtpAirDate.Name = "dtpAirDate";
            this.dtpAirDate.Size = new System.Drawing.Size(148, 27);
            this.dtpAirDate.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Air date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Season";
            // 
            // txtEpisodeName
            // 
            this.txtEpisodeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEpisodeName.Location = new System.Drawing.Point(212, 66);
            this.txtEpisodeName.Name = "txtEpisodeName";
            this.txtEpisodeName.Size = new System.Drawing.Size(330, 27);
            this.txtEpisodeName.TabIndex = 9;
            // 
            // cmbSeasonAdd
            // 
            this.cmbSeasonAdd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSeasonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSeasonAdd.FormattingEnabled = true;
            this.cmbSeasonAdd.Location = new System.Drawing.Point(212, 32);
            this.cmbSeasonAdd.Name = "cmbSeasonAdd";
            this.cmbSeasonAdd.Size = new System.Drawing.Size(330, 28);
            this.cmbSeasonAdd.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Episode name";
            // 
            // btnAddEpisode
            // 
            this.btnAddEpisode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEpisode.Location = new System.Drawing.Point(390, 134);
            this.btnAddEpisode.Name = "btnAddEpisode";
            this.btnAddEpisode.Size = new System.Drawing.Size(152, 38);
            this.btnAddEpisode.TabIndex = 6;
            this.btnAddEpisode.Text = "Add new episode";
            this.btnAddEpisode.UseVisualStyleBackColor = true;
            this.btnAddEpisode.Click += new System.EventHandler(this.btnAddEpisode_Click);
            // 
            // cmbSeasons
            // 
            this.cmbSeasons.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbSeasons.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSeasons.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSeasons.FormattingEnabled = true;
            this.cmbSeasons.Location = new System.Drawing.Point(549, 250);
            this.cmbSeasons.Name = "cmbSeasons";
            this.cmbSeasons.Size = new System.Drawing.Size(330, 30);
            this.cmbSeasons.TabIndex = 15;
            this.cmbSeasons.SelectionChangeCommitted += new System.EventHandler(this.cmbSeasons_SelectionChangeCommitted_1);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(1037, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(215, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "* double click on record to delete";
            // 
            // frmTvShowSeasonEpisodesAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 740);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbSeasons);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvEpisodes);
            this.Name = "frmTvShowSeasonEpisodesAdd";
            this.Text = "frmTvShowSeasonEpisodesAdd";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEpisodes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEpisodes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNewSeason;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSeasonName;
        private System.Windows.Forms.CheckBox chkFinished;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEpisodeName;
        private System.Windows.Forms.ComboBox cmbSeasonAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddEpisode;
        private System.Windows.Forms.ComboBox cmbSeasons;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn EpisodeNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn EpisodeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AirDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpAirDate;
        private System.Windows.Forms.TextBox txtEpNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}
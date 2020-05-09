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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTvShowSeasonEpisodesAdd));
            this.dgvEpisodes = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNewSeason = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSeasonName = new System.Windows.Forms.TextBox();
            this.chkFinished = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEpisodeName = new System.Windows.Forms.TextBox();
            this.cmbSeasonAdd = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddEpisode = new System.Windows.Forms.Button();
            this.cmbSeasons = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEpisodes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEpisodes
            // 
            this.dgvEpisodes.AllowUserToAddRows = false;
            this.dgvEpisodes.AllowUserToDeleteRows = false;
            this.dgvEpisodes.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEpisodes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEpisodes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            this.dgvEpisodes.Size = new System.Drawing.Size(1138, 419);
            this.dgvEpisodes.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(418, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Season";
            // 
            // btnNewSeason
            // 
            this.btnNewSeason.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewSeason.Location = new System.Drawing.Point(315, 119);
            this.btnNewSeason.Name = "btnNewSeason";
            this.btnNewSeason.Size = new System.Drawing.Size(221, 42);
            this.btnNewSeason.TabIndex = 6;
            this.btnNewSeason.Text = "Add new season";
            this.btnNewSeason.UseVisualStyleBackColor = true;
            this.btnNewSeason.Click += new System.EventHandler(this.btnNewSeason_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Episodes";
            // 
            // txtSeasonName
            // 
            this.txtSeasonName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeasonName.Location = new System.Drawing.Point(206, 40);
            this.txtSeasonName.Name = "txtSeasonName";
            this.txtSeasonName.Size = new System.Drawing.Size(330, 34);
            this.txtSeasonName.TabIndex = 9;
            // 
            // chkFinished
            // 
            this.chkFinished.AutoSize = true;
            this.chkFinished.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkFinished.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFinished.Location = new System.Drawing.Point(408, 80);
            this.chkFinished.Name = "chkFinished";
            this.chkFinished.Size = new System.Drawing.Size(128, 33);
            this.chkFinished.TabIndex = 10;
            this.chkFinished.Text = "Finished";
            this.chkFinished.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkFinished.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "Season name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSeasonName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnNewSeason);
            this.groupBox1.Controls.Add(this.chkFinished);
            this.groupBox1.Location = new System.Drawing.Point(123, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(564, 183);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add season";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtEpisodeName);
            this.groupBox2.Controls.Add(this.cmbSeasonAdd);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnAddEpisode);
            this.groupBox2.Location = new System.Drawing.Point(693, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(564, 183);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add episode";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 29);
            this.label5.TabIndex = 15;
            this.label5.Text = "Season";
            // 
            // txtEpisodeName
            // 
            this.txtEpisodeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEpisodeName.Location = new System.Drawing.Point(212, 75);
            this.txtEpisodeName.Name = "txtEpisodeName";
            this.txtEpisodeName.Size = new System.Drawing.Size(330, 34);
            this.txtEpisodeName.TabIndex = 9;
            // 
            // cmbSeasonAdd
            // 
            this.cmbSeasonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSeasonAdd.FormattingEnabled = true;
            this.cmbSeasonAdd.Location = new System.Drawing.Point(212, 32);
            this.cmbSeasonAdd.Name = "cmbSeasonAdd";
            this.cmbSeasonAdd.Size = new System.Drawing.Size(330, 37);
            this.cmbSeasonAdd.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "Episode name";
            // 
            // btnAddEpisode
            // 
            this.btnAddEpisode.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEpisode.Location = new System.Drawing.Point(321, 115);
            this.btnAddEpisode.Name = "btnAddEpisode";
            this.btnAddEpisode.Size = new System.Drawing.Size(221, 42);
            this.btnAddEpisode.TabIndex = 6;
            this.btnAddEpisode.Text = "Add new episode";
            this.btnAddEpisode.UseVisualStyleBackColor = true;
            this.btnAddEpisode.Click += new System.EventHandler(this.btnAddEpisode_Click);
            // 
            // cmbSeasons
            // 
            this.cmbSeasons.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSeasons.FormattingEnabled = true;
            this.cmbSeasons.Location = new System.Drawing.Point(531, 248);
            this.cmbSeasons.Name = "cmbSeasons";
            this.cmbSeasons.Size = new System.Drawing.Size(330, 37);
            this.cmbSeasons.TabIndex = 15;
            this.cmbSeasons.SelectionChangeCommitted += new System.EventHandler(this.cmbSeasons_SelectionChangeCommitted_1);
            // 
            // frmTvShowSeasonEpisodesAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1355, 740);
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
    }
}
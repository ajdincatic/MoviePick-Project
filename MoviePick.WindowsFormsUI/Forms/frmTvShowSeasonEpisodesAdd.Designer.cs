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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTvShowSeasonEpisodesAdd));
            this.dgvEpisodes = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnNewSeason = new System.Windows.Forms.Button();
            this.btnNewFinSeason = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEpisodes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEpisodes
            // 
            this.dgvEpisodes.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvEpisodes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEpisodes.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvEpisodes.Location = new System.Drawing.Point(102, 207);
            this.dgvEpisodes.Name = "dgvEpisodes";
            this.dgvEpisodes.RowHeadersWidth = 51;
            this.dgvEpisodes.RowTemplate.Height = 24;
            this.dgvEpisodes.Size = new System.Drawing.Size(1150, 518);
            this.dgvEpisodes.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(210, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Seasons";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(206, 109);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(348, 37);
            this.comboBox1.TabIndex = 4;
            // 
            // btnNewSeason
            // 
            this.btnNewSeason.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewSeason.Location = new System.Drawing.Point(632, 105);
            this.btnNewSeason.Name = "btnNewSeason";
            this.btnNewSeason.Size = new System.Drawing.Size(221, 42);
            this.btnNewSeason.TabIndex = 6;
            this.btnNewSeason.Text = "Add new season";
            this.btnNewSeason.UseVisualStyleBackColor = true;
            // 
            // btnNewFinSeason
            // 
            this.btnNewFinSeason.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewFinSeason.Location = new System.Drawing.Point(872, 105);
            this.btnNewFinSeason.Name = "btnNewFinSeason";
            this.btnNewFinSeason.Size = new System.Drawing.Size(299, 42);
            this.btnNewFinSeason.TabIndex = 7;
            this.btnNewFinSeason.Text = "Add new finished season";
            this.btnNewFinSeason.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Episodes";
            // 
            // frmTvShowSeasonEpisodesAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1355, 740);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNewFinSeason);
            this.Controls.Add(this.btnNewSeason);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvEpisodes);
            this.Controls.Add(this.comboBox1);
            this.Name = "frmTvShowSeasonEpisodesAdd";
            this.Text = "frmTvShowSeasonEpisodesAdd";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEpisodes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEpisodes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnNewSeason;
        private System.Windows.Forms.Button btnNewFinSeason;
        private System.Windows.Forms.Label label1;
    }
}
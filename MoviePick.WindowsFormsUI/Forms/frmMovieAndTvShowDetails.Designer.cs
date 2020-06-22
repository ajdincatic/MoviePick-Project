namespace MoviePick.WindowsFormsUI.Forms
{
    partial class frmMovieAndTvShowDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMovieAndTvShowDetails));
            this.btnQuotes = new System.Windows.Forms.Button();
            this.btnEditCast = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.chkTvShow = new System.Windows.Forms.CheckBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnEditSeasons = new System.Windows.Forms.Button();
            this.txtBudget = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnImage = new System.Windows.Forms.Button();
            this.txtPoster = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRtime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLang = new System.Windows.Forms.TextBox();
            this.Language = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rtxtDescription = new System.Windows.Forms.RichTextBox();
            this.dtRelaseDate = new System.Windows.Forms.DateTimePicker();
            this.cmbProductionComp = new System.Windows.Forms.ComboBox();
            this.chkFinished = new System.Windows.Forms.CheckBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblRating = new System.Windows.Forms.Label();
            this.lblNumberOfRatings = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnQuotes
            // 
            this.btnQuotes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuotes.Location = new System.Drawing.Point(363, 609);
            this.btnQuotes.Name = "btnQuotes";
            this.btnQuotes.Size = new System.Drawing.Size(414, 44);
            this.btnQuotes.TabIndex = 66;
            this.btnQuotes.Text = "Quotes";
            this.btnQuotes.UseVisualStyleBackColor = true;
            this.btnQuotes.Visible = false;
            this.btnQuotes.Click += new System.EventHandler(this.btnQuotes_Click_1);
            // 
            // btnEditCast
            // 
            this.btnEditCast.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditCast.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCast.Location = new System.Drawing.Point(363, 559);
            this.btnEditCast.Name = "btnEditCast";
            this.btnEditCast.Size = new System.Drawing.Size(414, 44);
            this.btnEditCast.TabIndex = 64;
            this.btnEditCast.Text = "Edit cast";
            this.btnEditCast.UseVisualStyleBackColor = true;
            this.btnEditCast.Visible = false;
            this.btnEditCast.Click += new System.EventHandler(this.btnEditCast_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(957, 87);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(233, 333);
            this.pictureBox2.TabIndex = 63;
            this.pictureBox2.TabStop = false;
            // 
            // chkTvShow
            // 
            this.chkTvShow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkTvShow.AutoSize = true;
            this.chkTvShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTvShow.Location = new System.Drawing.Point(573, 465);
            this.chkTvShow.Name = "chkTvShow";
            this.chkTvShow.Size = new System.Drawing.Size(93, 24);
            this.chkTvShow.TabIndex = 62;
            this.chkTvShow.Text = "Tv show";
            this.chkTvShow.UseVisualStyleBackColor = true;
            this.chkTvShow.CheckedChanged += new System.EventHandler(this.chkTvShow_CheckedChanged_1);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // btnEditSeasons
            // 
            this.btnEditSeasons.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditSeasons.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditSeasons.Location = new System.Drawing.Point(363, 659);
            this.btnEditSeasons.Name = "btnEditSeasons";
            this.btnEditSeasons.Size = new System.Drawing.Size(414, 44);
            this.btnEditSeasons.TabIndex = 65;
            this.btnEditSeasons.Text = "Edit Seasons";
            this.btnEditSeasons.UseVisualStyleBackColor = true;
            this.btnEditSeasons.Visible = false;
            this.btnEditSeasons.Click += new System.EventHandler(this.btnEditSeasons_Click_1);
            // 
            // txtBudget
            // 
            this.txtBudget.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBudget.Location = new System.Drawing.Point(363, 415);
            this.txtBudget.Name = "txtBudget";
            this.txtBudget.Size = new System.Drawing.Size(414, 27);
            this.txtBudget.TabIndex = 61;
            this.txtBudget.Validating += new System.ComponentModel.CancelEventHandler(this.txtBudget_Validating);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 420);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 60;
            this.label3.Text = "Budget";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(363, 509);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(414, 44);
            this.btnSave.TabIndex = 59;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnImage
            // 
            this.btnImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImage.Location = new System.Drawing.Point(1014, 459);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(130, 34);
            this.btnImage.TabIndex = 58;
            this.btnImage.Text = "Add poster";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click_1);
            // 
            // txtPoster
            // 
            this.txtPoster.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPoster.Location = new System.Drawing.Point(869, 426);
            this.txtPoster.Name = "txtPoster";
            this.txtPoster.Size = new System.Drawing.Size(414, 27);
            this.txtPoster.TabIndex = 57;
            this.txtPoster.Visible = false;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(103, 389);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 20);
            this.label6.TabIndex = 56;
            this.label6.Text = "Production company";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(103, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 55;
            this.label5.Text = "Release date";
            // 
            // txtRtime
            // 
            this.txtRtime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRtime.Location = new System.Drawing.Point(363, 315);
            this.txtRtime.Name = "txtRtime";
            this.txtRtime.Size = new System.Drawing.Size(414, 27);
            this.txtRtime.TabIndex = 54;
            this.txtRtime.Validating += new System.ComponentModel.CancelEventHandler(this.txtRtime_Validating);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(103, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 53;
            this.label4.Text = "Running time";
            // 
            // txtLang
            // 
            this.txtLang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLang.Location = new System.Drawing.Point(363, 282);
            this.txtLang.Name = "txtLang";
            this.txtLang.Size = new System.Drawing.Size(414, 27);
            this.txtLang.TabIndex = 52;
            this.txtLang.Validating += new System.ComponentModel.CancelEventHandler(this.txtLang_Validating);
            // 
            // Language
            // 
            this.Language.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Language.AutoSize = true;
            this.Language.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Language.Location = new System.Drawing.Point(103, 287);
            this.Language.Name = "Language";
            this.Language.Size = new System.Drawing.Size(82, 20);
            this.Language.TabIndex = 51;
            this.Language.Text = "Language";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 50;
            this.label2.Text = "Description";
            // 
            // rtxtDescription
            // 
            this.rtxtDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtxtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtDescription.Location = new System.Drawing.Point(363, 120);
            this.rtxtDescription.Name = "rtxtDescription";
            this.rtxtDescription.Size = new System.Drawing.Size(414, 156);
            this.rtxtDescription.TabIndex = 49;
            this.rtxtDescription.Text = "";
            this.rtxtDescription.Validating += new System.ComponentModel.CancelEventHandler(this.rtxtDescription_Validating);
            // 
            // dtRelaseDate
            // 
            this.dtRelaseDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtRelaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtRelaseDate.Location = new System.Drawing.Point(363, 348);
            this.dtRelaseDate.Name = "dtRelaseDate";
            this.dtRelaseDate.Size = new System.Drawing.Size(414, 27);
            this.dtRelaseDate.TabIndex = 48;
            // 
            // cmbProductionComp
            // 
            this.cmbProductionComp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbProductionComp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductionComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProductionComp.FormattingEnabled = true;
            this.cmbProductionComp.Location = new System.Drawing.Point(363, 381);
            this.cmbProductionComp.Name = "cmbProductionComp";
            this.cmbProductionComp.Size = new System.Drawing.Size(414, 28);
            this.cmbProductionComp.TabIndex = 46;
            this.cmbProductionComp.Validating += new System.ComponentModel.CancelEventHandler(this.cmbProductionComp_Validating);
            // 
            // chkFinished
            // 
            this.chkFinished.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkFinished.AutoSize = true;
            this.chkFinished.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFinished.Location = new System.Drawing.Point(683, 465);
            this.chkFinished.Name = "chkFinished";
            this.chkFinished.Size = new System.Drawing.Size(94, 24);
            this.chkFinished.TabIndex = 45;
            this.chkFinished.Text = "Finished";
            this.chkFinished.UseVisualStyleBackColor = true;
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(363, 87);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(414, 27);
            this.txtTitle.TabIndex = 44;
            this.txtTitle.Validating += new System.ComponentModel.CancelEventHandler(this.txtTitle_Validating);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 43;
            this.label1.Text = "Title";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRating.Location = new System.Drawing.Point(923, 517);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(0, 29);
            this.lblRating.TabIndex = 67;
            // 
            // lblNumberOfRatings
            // 
            this.lblNumberOfRatings.AutoSize = true;
            this.lblNumberOfRatings.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfRatings.Location = new System.Drawing.Point(923, 559);
            this.lblNumberOfRatings.Name = "lblNumberOfRatings";
            this.lblNumberOfRatings.Size = new System.Drawing.Size(0, 29);
            this.lblNumberOfRatings.TabIndex = 68;
            // 
            // frmMovieAndTvShowDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 756);
            this.Controls.Add(this.lblNumberOfRatings);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.btnQuotes);
            this.Controls.Add(this.btnEditCast);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.chkTvShow);
            this.Controls.Add(this.btnEditSeasons);
            this.Controls.Add(this.txtBudget);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.txtPoster);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRtime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLang);
            this.Controls.Add(this.Language);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtxtDescription);
            this.Controls.Add(this.dtRelaseDate);
            this.Controls.Add(this.cmbProductionComp);
            this.Controls.Add(this.chkFinished);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label1);
            this.Name = "frmMovieAndTvShowDetails";
            this.Text = "Detail Movie And Tv Show";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuotes;
        private System.Windows.Forms.Button btnEditCast;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox chkTvShow;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnEditSeasons;
        private System.Windows.Forms.TextBox txtBudget;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.TextBox txtPoster;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRtime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLang;
        private System.Windows.Forms.Label Language;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtxtDescription;
        private System.Windows.Forms.DateTimePicker dtRelaseDate;
        private System.Windows.Forms.ComboBox cmbProductionComp;
        private System.Windows.Forms.CheckBox chkFinished;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Label lblNumberOfRatings;
    }
}
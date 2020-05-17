namespace MoviePick.WindowsFormsUI.Forms
{
    partial class frmPersonAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonAdd));
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Language = new System.Windows.Forms.Label();
            this.txtPhoto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnImage = new System.Windows.Forms.Button();
            this.dtDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtPlaceOfBirth = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlaceBirth = new System.Windows.Forms.TextBox();
            this.rtxtBio = new System.Windows.Forms.RichTextBox();
            this.dtpDateOfDeath = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.chkDead = new System.Windows.Forms.CheckBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // txtGender
            // 
            this.txtGender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGender.Location = new System.Drawing.Point(557, 255);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(55, 34);
            this.txtGender.TabIndex = 35;
            this.txtGender.Validating += new System.ComponentModel.CancelEventHandler(this.txtGender_Validating);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(297, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 29);
            this.label4.TabIndex = 34;
            this.label4.Text = "Gender";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(297, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 29);
            this.label5.TabIndex = 36;
            this.label5.Text = "Date of birth";
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(557, 197);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(414, 34);
            this.txtLastName.TabIndex = 33;
            this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.txtLastName_Validating);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(1165, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 333);
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // Language
            // 
            this.Language.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Language.AutoSize = true;
            this.Language.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Language.Location = new System.Drawing.Point(297, 202);
            this.Language.Name = "Language";
            this.Language.Size = new System.Drawing.Size(123, 29);
            this.Language.TabIndex = 32;
            this.Language.Text = "Last name";
            // 
            // txtPhoto
            // 
            this.txtPhoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoto.Location = new System.Drawing.Point(1082, 459);
            this.txtPhoto.Name = "txtPhoto";
            this.txtPhoto.Size = new System.Drawing.Size(414, 34);
            this.txtPhoto.TabIndex = 39;
            this.txtPhoto.Visible = false;
            this.txtPhoto.Validating += new System.ComponentModel.CancelEventHandler(this.txtPhoto_Validating);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(297, 479);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 29);
            this.label2.TabIndex = 31;
            this.label2.Text = "Biography";
            // 
            // btnImage
            // 
            this.btnImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImage.Location = new System.Drawing.Point(1227, 498);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(130, 34);
            this.btnImage.TabIndex = 40;
            this.btnImage.Text = "Add photo";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // dtDateOfBirth
            // 
            this.dtDateOfBirth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDateOfBirth.Location = new System.Drawing.Point(557, 309);
            this.dtDateOfBirth.Name = "dtDateOfBirth";
            this.dtDateOfBirth.Size = new System.Drawing.Size(207, 34);
            this.dtDateOfBirth.TabIndex = 29;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(835, 683);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(136, 44);
            this.btnSave.TabIndex = 41;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(557, 141);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(414, 34);
            this.txtFirstName.TabIndex = 25;
            this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txtFirstName_Validating);
            // 
            // txtPlaceOfBirth
            // 
            this.txtPlaceOfBirth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPlaceOfBirth.AutoSize = true;
            this.txtPlaceOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaceOfBirth.Location = new System.Drawing.Point(297, 420);
            this.txtPlaceOfBirth.Name = "txtPlaceOfBirth";
            this.txtPlaceOfBirth.Size = new System.Drawing.Size(153, 29);
            this.txtPlaceOfBirth.TabIndex = 42;
            this.txtPlaceOfBirth.Text = "Place of birth";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 29);
            this.label1.TabIndex = 24;
            this.label1.Text = "First name";
            // 
            // txtPlaceBirth
            // 
            this.txtPlaceBirth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPlaceBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaceBirth.Location = new System.Drawing.Point(557, 415);
            this.txtPlaceBirth.Name = "txtPlaceBirth";
            this.txtPlaceBirth.Size = new System.Drawing.Size(414, 34);
            this.txtPlaceBirth.TabIndex = 43;
            this.txtPlaceBirth.Validating += new System.ComponentModel.CancelEventHandler(this.txtPlaceBirth_Validating);
            // 
            // rtxtBio
            // 
            this.rtxtBio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtxtBio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtBio.Location = new System.Drawing.Point(557, 479);
            this.rtxtBio.Name = "rtxtBio";
            this.rtxtBio.Size = new System.Drawing.Size(414, 156);
            this.rtxtBio.TabIndex = 30;
            this.rtxtBio.Text = "";
            this.rtxtBio.Validating += new System.ComponentModel.CancelEventHandler(this.rtxtBio_Validating);
            // 
            // dtpDateOfDeath
            // 
            this.dtpDateOfDeath.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpDateOfDeath.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateOfDeath.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfDeath.Location = new System.Drawing.Point(557, 359);
            this.dtpDateOfDeath.Name = "dtpDateOfDeath";
            this.dtpDateOfDeath.Size = new System.Drawing.Size(207, 34);
            this.dtpDateOfDeath.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(297, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 29);
            this.label3.TabIndex = 45;
            this.label3.Text = "Date of death";
            // 
            // chkDead
            // 
            this.chkDead.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkDead.AutoSize = true;
            this.chkDead.Checked = true;
            this.chkDead.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDead.Location = new System.Drawing.Point(770, 366);
            this.chkDead.Name = "chkDead";
            this.chkDead.Size = new System.Drawing.Size(99, 29);
            this.chkDead.TabIndex = 46;
            this.chkDead.Text = "Disable";
            this.chkDead.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmPersonAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1768, 914);
            this.Controls.Add(this.chkDead);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDateOfDeath);
            this.Controls.Add(this.txtPlaceBirth);
            this.Controls.Add(this.txtPlaceOfBirth);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.txtPhoto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.Language);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtxtBio);
            this.Controls.Add(this.dtDateOfBirth);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label1);
            this.Name = "frmPersonAdd";
            this.Text = "Add person";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Language;
        private System.Windows.Forms.TextBox txtPhoto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.DateTimePicker dtDateOfBirth;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label txtPlaceOfBirth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPlaceBirth;
        private System.Windows.Forms.RichTextBox rtxtBio;
        private System.Windows.Forms.DateTimePicker dtpDateOfDeath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkDead;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonAdd));
            this.btnSave = new System.Windows.Forms.Button();
            this.btnImage = new System.Windows.Forms.Button();
            this.txtPhoto = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.Language = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rtxtBio = new System.Windows.Forms.RichTextBox();
            this.dtDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtPlaceOfBirth = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(629, 638);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(136, 44);
            this.btnSave.TabIndex = 41;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnImage
            // 
            this.btnImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImage.Location = new System.Drawing.Point(1021, 467);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(130, 34);
            this.btnImage.TabIndex = 40;
            this.btnImage.Text = "Add photo";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // txtPhoto
            // 
            this.txtPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoto.Location = new System.Drawing.Point(876, 428);
            this.txtPhoto.Name = "txtPhoto";
            this.txtPhoto.Size = new System.Drawing.Size(414, 34);
            this.txtPhoto.TabIndex = 39;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(962, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 333);
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(91, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 29);
            this.label5.TabIndex = 36;
            this.label5.Text = "Date of birth";
            // 
            // txtGender
            // 
            this.txtGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGender.Location = new System.Drawing.Point(351, 224);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(55, 34);
            this.txtGender.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(91, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 29);
            this.label4.TabIndex = 34;
            this.label4.Text = "Gender";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(351, 166);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(414, 34);
            this.txtLastName.TabIndex = 33;
            // 
            // Language
            // 
            this.Language.AutoSize = true;
            this.Language.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Language.Location = new System.Drawing.Point(91, 171);
            this.Language.Name = "Language";
            this.Language.Size = new System.Drawing.Size(123, 29);
            this.Language.TabIndex = 32;
            this.Language.Text = "Last name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 29);
            this.label2.TabIndex = 31;
            this.label2.Text = "Biography";
            // 
            // rtxtBio
            // 
            this.rtxtBio.Location = new System.Drawing.Point(351, 400);
            this.rtxtBio.Name = "rtxtBio";
            this.rtxtBio.Size = new System.Drawing.Size(414, 156);
            this.rtxtBio.TabIndex = 30;
            this.rtxtBio.Text = "";
            // 
            // dtDateOfBirth
            // 
            this.dtDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDateOfBirth.Location = new System.Drawing.Point(351, 278);
            this.dtDateOfBirth.Name = "dtDateOfBirth";
            this.dtDateOfBirth.Size = new System.Drawing.Size(414, 34);
            this.dtDateOfBirth.TabIndex = 29;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(351, 110);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(414, 34);
            this.txtFirstName.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 29);
            this.label1.TabIndex = 24;
            this.label1.Text = "First name";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(351, 336);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(414, 34);
            this.textBox1.TabIndex = 43;
            // 
            // txtPlaceOfBirth
            // 
            this.txtPlaceOfBirth.AutoSize = true;
            this.txtPlaceOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaceOfBirth.Location = new System.Drawing.Point(91, 341);
            this.txtPlaceOfBirth.Name = "txtPlaceOfBirth";
            this.txtPlaceOfBirth.Size = new System.Drawing.Size(153, 29);
            this.txtPlaceOfBirth.TabIndex = 42;
            this.txtPlaceOfBirth.Text = "Place of birth";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // frmPersonAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1337, 763);
            this.Controls.Add(this.textBox1);
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
            this.Text = "frmPersonAdd";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.TextBox txtPhoto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label Language;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtxtBio;
        private System.Windows.Forms.DateTimePicker dtDateOfBirth;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtPlaceOfBirth;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}
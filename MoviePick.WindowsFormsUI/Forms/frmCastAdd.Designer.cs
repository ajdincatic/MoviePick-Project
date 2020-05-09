namespace MoviePick.WindowsFormsUI.Forms
{
    partial class frmCastAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCastAdd));
            this.gbCast = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddCast = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.dgvCast = new System.Windows.Forms.DataGridView();
            this.gbCast.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCast)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCast
            // 
            this.gbCast.Controls.Add(this.label2);
            this.gbCast.Controls.Add(this.btnAddCast);
            this.gbCast.Controls.Add(this.label1);
            this.gbCast.Controls.Add(this.txtName);
            this.gbCast.Controls.Add(this.cmbRole);
            this.gbCast.Location = new System.Drawing.Point(323, 26);
            this.gbCast.Name = "gbCast";
            this.gbCast.Size = new System.Drawing.Size(719, 252);
            this.gbCast.TabIndex = 0;
            this.gbCast.TabStop = false;
            this.gbCast.Text = "Add cast";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name in show";
            // 
            // btnAddCast
            // 
            this.btnAddCast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCast.Location = new System.Drawing.Point(562, 188);
            this.btnAddCast.Name = "btnAddCast";
            this.btnAddCast.Size = new System.Drawing.Size(133, 46);
            this.btnAddCast.TabIndex = 3;
            this.btnAddCast.Text = "Add";
            this.btnAddCast.UseVisualStyleBackColor = true;
            this.btnAddCast.Click += new System.EventHandler(this.btnAddCast_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Role";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(90, 157);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(348, 30);
            this.txtName.TabIndex = 1;
            // 
            // cmbRole
            // 
            this.cmbRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Location = new System.Drawing.Point(90, 78);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(348, 33);
            this.cmbRole.TabIndex = 0;
            this.cmbRole.SelectionChangeCommitted += new System.EventHandler(this.cmbRole_SelectionChangeCommitted);
            // 
            // dgvCast
            // 
            this.dgvCast.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvCast.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCast.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgvCast.Location = new System.Drawing.Point(99, 310);
            this.dgvCast.Name = "dgvCast";
            this.dgvCast.RowHeadersWidth = 51;
            this.dgvCast.RowTemplate.Height = 24;
            this.dgvCast.Size = new System.Drawing.Size(1150, 426);
            this.dgvCast.TabIndex = 1;
            // 
            // frmCastAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1352, 748);
            this.Controls.Add(this.dgvCast);
            this.Controls.Add(this.gbCast);
            this.Name = "frmCastAdd";
            this.Text = "Cast add";
            this.gbCast.ResumeLayout(false);
            this.gbCast.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCast)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCast;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.DataGridView dgvCast;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddCast;
    }
}
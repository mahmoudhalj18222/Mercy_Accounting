
namespace Mercy_Accounting.Form
{
    partial class Add_Expansess_Details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Expansess_Details));
            this.btnAddEdit = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_name = new System.Windows.Forms.ComboBox();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.txt_zn = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_zn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddEdit
            // 
            this.btnAddEdit.Appearance.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btnAddEdit.Appearance.Options.UseFont = true;
            this.btnAddEdit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddEdit.ImageOptions.Image")));
            this.btnAddEdit.Location = new System.Drawing.Point(0, 705);
            this.btnAddEdit.Name = "btnAddEdit";
            this.btnAddEdit.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnAddEdit.Size = new System.Drawing.Size(699, 47);
            this.btnAddEdit.TabIndex = 5;
            this.btnAddEdit.Text = "Add";
            this.btnAddEdit.Click += new System.EventHandler(this.btnAddEdit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Controls.Add(this.txt_amount);
            this.groupBox1.Controls.Add(this.txt_zn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(30, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(640, 78);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // txt_name
            // 
            this.txt_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txt_name.FormattingEnabled = true;
            this.txt_name.Location = new System.Drawing.Point(179, 28);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(239, 28);
            this.txt_name.TabIndex = 4;
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(488, 28);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(126, 26);
            this.txt_amount.TabIndex = 3;
            // 
            // txt_zn
            // 
            this.txt_zn.Location = new System.Drawing.Point(39, 29);
            this.txt_zn.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.txt_zn.Name = "txt_zn";
            this.txt_zn.Size = new System.Drawing.Size(84, 26);
            this.txt_zn.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "SN";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(424, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 20);
            this.label12.TabIndex = 1;
            this.label12.Text = "Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(40, 96);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(630, 603);
            this.pictureEdit1.TabIndex = 10;
            // 
            // Add_Expansess_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 752);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAddEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Add_Expansess_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_zn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.SimpleButton btnAddEdit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.NumericUpDown txt_zn;
        public System.Windows.Forms.ComboBox txt_name;
        public System.Windows.Forms.TextBox txt_amount;
        public DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}
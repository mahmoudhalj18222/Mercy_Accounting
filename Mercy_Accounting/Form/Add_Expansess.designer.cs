
namespace Mercy_Accounting.Form
{
    partial class Add_Expansess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Expansess));
            this.btnAddEdit = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_date = new System.Windows.Forms.DateTimePicker();
            this.txt_name = new System.Windows.Forms.ComboBox();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.txt_type = new System.Windows.Forms.ComboBox();
            this.txt_project = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_Pos = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_note = new System.Windows.Forms.TextBox();
            this.btn_clear = new DevExpress.XtraEditors.SimpleButton();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Abut = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Pos.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddEdit
            // 
            this.btnAddEdit.Appearance.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btnAddEdit.Appearance.Options.UseFont = true;
            this.btnAddEdit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddEdit.ImageOptions.Image")));
            this.btnAddEdit.Location = new System.Drawing.Point(0, 496);
            this.btnAddEdit.Name = "btnAddEdit";
            this.btnAddEdit.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnAddEdit.Size = new System.Drawing.Size(873, 47);
            this.btnAddEdit.TabIndex = 5;
            this.btnAddEdit.Text = "Add";
            this.btnAddEdit.Click += new System.EventHandler(this.btnAddEdit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_date);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Controls.Add(this.txt_Abut);
            this.groupBox1.Controls.Add(this.txt_amount);
            this.groupBox1.Controls.Add(this.txt_type);
            this.groupBox1.Controls.Add(this.txt_project);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txt_Pos);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(30, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 264);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Suppliers";
            // 
            // txt_date
            // 
            this.txt_date.Location = new System.Drawing.Point(76, 191);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(255, 26);
            this.txt_date.TabIndex = 4;
            this.txt_date.Value = new System.DateTime(2021, 2, 9, 0, 0, 0, 0);
            // 
            // txt_name
            // 
            this.txt_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txt_name.FormattingEnabled = true;
            this.txt_name.Location = new System.Drawing.Point(76, 27);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(255, 28);
            this.txt_name.TabIndex = 4;
            this.txt_name.SelectedIndexChanged += new System.EventHandler(this.txt_name_SelectedIndexChanged);
            // 
            // txt_amount
            // 
            this.txt_amount.Location = new System.Drawing.Point(76, 127);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.Size = new System.Drawing.Size(255, 26);
            this.txt_amount.TabIndex = 3;
            // 
            // txt_type
            // 
            this.txt_type.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.txt_type.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_type.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txt_type.FormattingEnabled = true;
            this.txt_type.Location = new System.Drawing.Point(76, 223);
            this.txt_type.Name = "txt_type";
            this.txt_type.Size = new System.Drawing.Size(255, 28);
            this.txt_type.TabIndex = 4;
            // 
            // txt_project
            // 
            this.txt_project.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.txt_project.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_project.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txt_project.FormattingEnabled = true;
            this.txt_project.Location = new System.Drawing.Point(76, 93);
            this.txt_project.Name = "txt_project";
            this.txt_project.Size = new System.Drawing.Size(255, 28);
            this.txt_project.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 196);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "Date";
            // 
            // txt_Pos
            // 
            this.txt_Pos.Location = new System.Drawing.Point(76, 61);
            this.txt_Pos.Name = "txt_Pos";
            this.txt_Pos.Properties.Appearance.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Pos.Properties.Appearance.Options.UseFont = true;
            this.txt_Pos.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_Pos.Properties.Items.AddRange(new object[] {
            "Bank transfer fees",
            "warehouse medications",
            "Covid-19 Materials",
            "GFA Transportation from warehouse to distribution sites",
            "Handling casual Labour",
            "Cleaning and Kitchen supplies",
            "Prints and stationery",
            "Stoves and fuel",
            "Internet for warehouse",
            "Internet for the office",
            "Credit for Turkish phone SIM",
            "Plastic bags",
            "Battery",
            "Print and Flax",
            "Running cost",
            "Internet",
            "Medical Equipment",
            "Fuel for generator",
            "Running cost /  office project and RRTs ",
            "Stationery, printing materials",
            "Focus Group Dessicsion",
            "Stoves",
            "Office Equipment",
            "Rent Warehouse",
            "Plastic bags",
            "Transportation Cost for logistic",
            "Tables and chairs",
            "Meals for staff",
            "Office Supplies",
            "Stationery",
            "Banners",
            "Transportation Soap from the border to the warehouse",
            "Water tanks",
            "Isolation lines in the distribution points",
            "Communications"});
            this.txt_Pos.Size = new System.Drawing.Size(252, 26);
            this.txt_Pos.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Project";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Position";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 130);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 20);
            this.label12.TabIndex = 1;
            this.label12.Text = "Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // txt_note
            // 
            this.txt_note.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_note.Location = new System.Drawing.Point(30, 345);
            this.txt_note.Multiline = true;
            this.txt_note.Name = "txt_note";
            this.txt_note.Size = new System.Drawing.Size(349, 109);
            this.txt_note.TabIndex = 7;
            // 
            // btn_clear
            // 
            this.btn_clear.Appearance.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btn_clear.Appearance.Options.UseFont = true;
            this.btn_clear.Appearance.Options.UseForeColor = true;
            this.btn_clear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_clear.ImageOptions.Image")));
            this.btn_clear.Location = new System.Drawing.Point(30, 458);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_clear.Size = new System.Drawing.Size(123, 32);
            this.btn_clear.TabIndex = 8;
            this.btn_clear.Text = "Clear Data";
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Silver;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(349, 30);
            this.label13.TabIndex = 1;
            this.label13.Text = "Note";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label13);
            this.panel1.Location = new System.Drawing.Point(30, 309);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 30);
            this.panel1.TabIndex = 9;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(385, 12);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(476, 478);
            this.pictureEdit1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Abut";
            // 
            // txt_Abut
            // 
            this.txt_Abut.Location = new System.Drawing.Point(76, 159);
            this.txt_Abut.Name = "txt_Abut";
            this.txt_Abut.Size = new System.Drawing.Size(255, 26);
            this.txt_Abut.TabIndex = 3;
            // 
            // Add_Expansess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 543);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.txt_note);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAddEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Add_Expansess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Add_Expansess_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Pos.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraEditors.SimpleButton btnAddEdit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private DevExpress.XtraEditors.SimpleButton btn_clear;
        public DevExpress.XtraEditors.ComboBoxEdit txt_Pos;
        public System.Windows.Forms.TextBox txt_note;
        public System.Windows.Forms.ComboBox txt_name;
        public System.Windows.Forms.ComboBox txt_project;
        public System.Windows.Forms.TextBox txt_amount;
        public System.Windows.Forms.DateTimePicker txt_date;
        public System.Windows.Forms.ComboBox txt_type;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel1;
        public DevExpress.XtraEditors.PictureEdit pictureEdit1;
        public System.Windows.Forms.TextBox txt_Abut;
        private System.Windows.Forms.Label label2;
    }
}

namespace Mercy_Accounting.Form
{
    partial class Add_Salary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Salary));
            this.btnAddEdit = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_name = new System.Windows.Forms.ComboBox();
            this.txt_project = new System.Windows.Forms.ComboBox();
            this.txt_zoho = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Pos = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_net = new System.Windows.Forms.TextBox();
            this.txt_Dedu = new System.Windows.Forms.TextBox();
            this.txt_tran = new System.Windows.Forms.TextBox();
            this.txt_Gross = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_date = new System.Windows.Forms.DateTimePicker();
            this.txt_pay = new System.Windows.Forms.TextBox();
            this.txt_curr = new System.Windows.Forms.TextBox();
            this.txt_abut = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_note = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_add = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_zoho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Pos.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddEdit
            // 
            this.btnAddEdit.Appearance.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btnAddEdit.Appearance.Options.UseFont = true;
            this.btnAddEdit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAddEdit.ImageOptions.Image")));
            this.btnAddEdit.Location = new System.Drawing.Point(0, 444);
            this.btnAddEdit.Name = "btnAddEdit";
            this.btnAddEdit.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnAddEdit.Size = new System.Drawing.Size(731, 47);
            this.btnAddEdit.TabIndex = 5;
            this.btnAddEdit.Text = "Add";
            this.btnAddEdit.Click += new System.EventHandler(this.btnAddEdit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Controls.Add(this.txt_project);
            this.groupBox1.Controls.Add(this.txt_zoho);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_Pos);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 187);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee";
            // 
            // txt_name
            // 
            this.txt_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txt_name.FormattingEnabled = true;
            this.txt_name.Location = new System.Drawing.Point(76, 31);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(252, 28);
            this.txt_name.TabIndex = 4;
            this.txt_name.SelectedIndexChanged += new System.EventHandler(this.txt_name_SelectedIndexChanged);
            // 
            // txt_project
            // 
            this.txt_project.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_project.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txt_project.FormattingEnabled = true;
            this.txt_project.Location = new System.Drawing.Point(76, 129);
            this.txt_project.Name = "txt_project";
            this.txt_project.Size = new System.Drawing.Size(252, 28);
            this.txt_project.TabIndex = 4;
            // 
            // txt_zoho
            // 
            this.txt_zoho.Location = new System.Drawing.Point(76, 65);
            this.txt_zoho.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.txt_zoho.Name = "txt_zoho";
            this.txt_zoho.Size = new System.Drawing.Size(255, 26);
            this.txt_zoho.TabIndex = 3;
            this.txt_zoho.ValueChanged += new System.EventHandler(this.txt_zoho_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Zoho";
            // 
            // txt_Pos
            // 
            this.txt_Pos.Location = new System.Drawing.Point(76, 97);
            this.txt_Pos.Name = "txt_Pos";
            this.txt_Pos.Properties.Appearance.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Pos.Properties.Appearance.Options.UseFont = true;
            this.txt_Pos.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_Pos.Properties.Items.AddRange(new object[] {
            "Project Coordinator",
            "Project Manager",
            "Facility administrator ",
            "Field Emergency Respond coordinator",
            "Field Accountan",
            "Field FSL coordinator",
            "Information Management coordinator",
            "Communnication Officer",
            "Facility administrator ",
            "Logistic",
            "logistic Officer",
            "Field Accountant",
            "Field Finance Coordinator",
            "Finance Clerk",
            "Finance Assistant",
            "Field HR Officer",
            "HR Officer",
            "Media Officer",
            "MEAL Coordinator",
            "Monitoring & Evaluation",
            "MEAL Officer",
            "M&E",
            "Information Management Assisstant",
            "Data Entry",
            "Data Management",
            "Data Entry / OTP",
            "Reception and Data Entry",
            "Area coordinator",
            "Technical Engineer",
            "Distribution Officer",
            "Bread Distribution Officer",
            "Distribution staff",
            "Bread Distribution staff",
            "Pediatrician / GP",
            "Pediatrician",
            "General practitioner",
            "Gynaecologist",
            "Internal Doctor",
            "Midwife",
            "Visitor doctors",
            "P.S.S",
            "Pharmacist",
            "IPC officer",
            "IPC worker",
            "Lab technician",
            "Nutrition Supervisor",
            "Nutritionist",
            "Nutritionist / OTP",
            "Facility Nurse",
            "RRT Nurse",
            "Nurse",
            "Nurse / OTP",
            "CHW",
            "Complaint Officer",
            "Helpdesk Officer",
            "Warehouse Logistic Officer",
            "Werehouse Keeper",
            "Werehouse labor",
            "Werehouse Guard",
            "Maret Mesrin Office guard",
            "Guard",
            "Domestic Helper",
            "Cleaner",
            ""});
            this.txt_Pos.Size = new System.Drawing.Size(255, 26);
            this.txt_Pos.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Project";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Position";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_net);
            this.groupBox2.Controls.Add(this.txt_Dedu);
            this.groupBox2.Controls.Add(this.txt_add);
            this.groupBox2.Controls.Add(this.txt_tran);
            this.groupBox2.Controls.Add(this.txt_Gross);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(368, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(340, 187);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Salary";
            // 
            // txt_net
            // 
            this.txt_net.Location = new System.Drawing.Point(124, 156);
            this.txt_net.Name = "txt_net";
            this.txt_net.Size = new System.Drawing.Size(204, 26);
            this.txt_net.TabIndex = 3;
            this.txt_net.Text = "0";
            this.txt_net.TextChanged += new System.EventHandler(this.txt_Dedu_TextChanged);
            // 
            // txt_Dedu
            // 
            this.txt_Dedu.Location = new System.Drawing.Point(124, 124);
            this.txt_Dedu.Name = "txt_Dedu";
            this.txt_Dedu.Size = new System.Drawing.Size(204, 26);
            this.txt_Dedu.TabIndex = 3;
            this.txt_Dedu.Text = "0";
            this.txt_Dedu.TextChanged += new System.EventHandler(this.txt_Dedu_TextChanged);
            // 
            // txt_tran
            // 
            this.txt_tran.Location = new System.Drawing.Point(124, 93);
            this.txt_tran.Name = "txt_tran";
            this.txt_tran.Size = new System.Drawing.Size(204, 26);
            this.txt_tran.TabIndex = 3;
            this.txt_tran.Text = "0";
            this.txt_tran.TextChanged += new System.EventHandler(this.txt_tran_TextChanged);
            // 
            // txt_Gross
            // 
            this.txt_Gross.Location = new System.Drawing.Point(124, 31);
            this.txt_Gross.Name = "txt_Gross";
            this.txt_Gross.Size = new System.Drawing.Size(204, 26);
            this.txt_Gross.TabIndex = 3;
            this.txt_Gross.Text = "0";
            this.txt_Gross.TextAlignChanged += new System.EventHandler(this.txt_Gross_TextAlignChanged);
            this.txt_Gross.TextChanged += new System.EventHandler(this.txt_Gross_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Transportation";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Net Deu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Other Deduction";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Gross";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_date);
            this.groupBox3.Controls.Add(this.txt_pay);
            this.groupBox3.Controls.Add(this.txt_curr);
            this.groupBox3.Controls.Add(this.txt_abut);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(22, 228);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(340, 187);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Payroll";
            // 
            // txt_date
            // 
            this.txt_date.Location = new System.Drawing.Point(124, 97);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(200, 26);
            this.txt_date.TabIndex = 4;
            this.txt_date.Value = new System.DateTime(2021, 2, 9, 0, 0, 0, 0);
            // 
            // txt_pay
            // 
            this.txt_pay.Location = new System.Drawing.Point(124, 31);
            this.txt_pay.Name = "txt_pay";
            this.txt_pay.Size = new System.Drawing.Size(204, 26);
            this.txt_pay.TabIndex = 3;
            this.txt_pay.TextChanged += new System.EventHandler(this.txt_Dedu_TextChanged);
            // 
            // txt_curr
            // 
            this.txt_curr.Location = new System.Drawing.Point(124, 129);
            this.txt_curr.Name = "txt_curr";
            this.txt_curr.Size = new System.Drawing.Size(204, 26);
            this.txt_curr.TabIndex = 3;
            this.txt_curr.Text = "USA";
            this.txt_curr.TextChanged += new System.EventHandler(this.txt_Dedu_TextChanged);
            // 
            // txt_abut
            // 
            this.txt_abut.Location = new System.Drawing.Point(124, 64);
            this.txt_abut.Name = "txt_abut";
            this.txt_abut.Size = new System.Drawing.Size(204, 26);
            this.txt_abut.TabIndex = 3;
            this.txt_abut.TextChanged += new System.EventHandler(this.txt_Dedu_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "About a month";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Currency";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "Preparation Date";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 20);
            this.label12.TabIndex = 1;
            this.label12.Text = "Id Payroll";
            // 
            // txt_note
            // 
            this.txt_note.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_note.Location = new System.Drawing.Point(368, 268);
            this.txt_note.Multiline = true;
            this.txt_note.Name = "txt_note";
            this.txt_note.Size = new System.Drawing.Size(340, 109);
            this.txt_note.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Silver;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(340, 30);
            this.label13.TabIndex = 1;
            this.label13.Text = "Note";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(368, 383);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton1.Size = new System.Drawing.Size(123, 32);
            this.simpleButton1.TabIndex = 8;
            this.simpleButton1.Text = "Clear Data";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label13);
            this.panel1.Location = new System.Drawing.Point(368, 232);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 30);
            this.panel1.TabIndex = 9;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 65);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 20);
            this.label14.TabIndex = 1;
            this.label14.Text = "Add Additions";
            // 
            // txt_add
            // 
            this.txt_add.Location = new System.Drawing.Point(124, 62);
            this.txt_add.Name = "txt_add";
            this.txt_add.Size = new System.Drawing.Size(204, 26);
            this.txt_add.TabIndex = 3;
            this.txt_add.Text = "0";
            this.txt_add.TextChanged += new System.EventHandler(this.txt_add_TextChanged);
            // 
            // Add_Salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 491);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.txt_note);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAddEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Add_Salary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Add_Salary_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_zoho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Pos.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraEditors.SimpleButton btnAddEdit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.NumericUpDown txt_zoho;
        public DevExpress.XtraEditors.ComboBoxEdit txt_Pos;
        public System.Windows.Forms.TextBox txt_note;
        public System.Windows.Forms.ComboBox txt_name;
        public System.Windows.Forms.ComboBox txt_project;
        public System.Windows.Forms.TextBox txt_Dedu;
        public System.Windows.Forms.TextBox txt_tran;
        public System.Windows.Forms.TextBox txt_Gross;
        public System.Windows.Forms.TextBox txt_net;
        public System.Windows.Forms.TextBox txt_pay;
        public System.Windows.Forms.TextBox txt_curr;
        public System.Windows.Forms.TextBox txt_abut;
        public System.Windows.Forms.DateTimePicker txt_date;
        public System.Windows.Forms.TextBox txt_add;
        private System.Windows.Forms.Label label14;
    }
}
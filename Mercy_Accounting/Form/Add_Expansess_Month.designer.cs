
namespace Mercy_Accounting.Form
{
    partial class Add_Expansess_Month
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Expansess_Month));
            this.panel1 = new System.Windows.Forms.Panel();
            this.chec_paid = new System.Windows.Forms.RadioButton();
            this.btn_show = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.txt_Date = new System.Windows.Forms.DateTimePicker();
            this.txt_Note = new System.Windows.Forms.TextBox();
            this.txt_yaer = new System.Windows.Forms.TextBox();
            this.txt_About = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Amount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_project = new System.Windows.Forms.TextBox();
            this.txt_position = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPosition = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProject = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAbut_Month = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldetatils = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txt_sn = new System.Windows.Forms.NumericUpDown();
            this.txt_qb = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_qb)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_qb);
            this.panel1.Controls.Add(this.txt_sn);
            this.panel1.Controls.Add(this.chec_paid);
            this.panel1.Controls.Add(this.btn_show);
            this.panel1.Controls.Add(this.btn_Add);
            this.panel1.Controls.Add(this.txt_Date);
            this.panel1.Controls.Add(this.txt_Note);
            this.panel1.Controls.Add(this.txt_yaer);
            this.panel1.Controls.Add(this.txt_About);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txt_Amount);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_project);
            this.panel1.Controls.Add(this.txt_position);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txt_name);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_Id);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(726, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 542);
            this.panel1.TabIndex = 1;
            // 
            // chec_paid
            // 
            this.chec_paid.AutoSize = true;
            this.chec_paid.Checked = true;
            this.chec_paid.Location = new System.Drawing.Point(7, 334);
            this.chec_paid.Name = "chec_paid";
            this.chec_paid.Size = new System.Drawing.Size(54, 24);
            this.chec_paid.TabIndex = 4;
            this.chec_paid.TabStop = true;
            this.chec_paid.Text = "Paid";
            this.chec_paid.UseVisualStyleBackColor = true;
            // 
            // btn_show
            // 
            this.btn_show.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_show.Appearance.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_show.Appearance.Options.UseFont = true;
            this.btn_show.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_show.ImageOptions.Image")));
            this.btn_show.Location = new System.Drawing.Point(156, 491);
            this.btn_show.Name = "btn_show";
            this.btn_show.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_show.Size = new System.Drawing.Size(139, 39);
            this.btn_show.TabIndex = 3;
            this.btn_show.Text = "Show All Data";
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Add.Appearance.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Appearance.Options.UseFont = true;
            this.btn_Add.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Add.ImageOptions.Image")));
            this.btn_Add.Location = new System.Drawing.Point(11, 491);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_Add.Size = new System.Drawing.Size(139, 39);
            this.btn_Add.TabIndex = 3;
            this.btn_Add.Text = "Add To Report";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // txt_Date
            // 
            this.txt_Date.Enabled = false;
            this.txt_Date.Location = new System.Drawing.Point(97, 102);
            this.txt_Date.Name = "txt_Date";
            this.txt_Date.Size = new System.Drawing.Size(194, 26);
            this.txt_Date.TabIndex = 2;
            // 
            // txt_Note
            // 
            this.txt_Note.Location = new System.Drawing.Point(97, 365);
            this.txt_Note.Multiline = true;
            this.txt_Note.Name = "txt_Note";
            this.txt_Note.ReadOnly = true;
            this.txt_Note.Size = new System.Drawing.Size(194, 120);
            this.txt_Note.TabIndex = 1;
            // 
            // txt_yaer
            // 
            this.txt_yaer.Location = new System.Drawing.Point(97, 261);
            this.txt_yaer.Name = "txt_yaer";
            this.txt_yaer.ReadOnly = true;
            this.txt_yaer.Size = new System.Drawing.Size(194, 26);
            this.txt_yaer.TabIndex = 1;
            // 
            // txt_About
            // 
            this.txt_About.Location = new System.Drawing.Point(97, 293);
            this.txt_About.Name = "txt_About";
            this.txt_About.ReadOnly = true;
            this.txt_About.Size = new System.Drawing.Size(194, 26);
            this.txt_About.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 368);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Note";
            // 
            // txt_Amount
            // 
            this.txt_Amount.Location = new System.Drawing.Point(97, 165);
            this.txt_Amount.Name = "txt_Amount";
            this.txt_Amount.ReadOnly = true;
            this.txt_Amount.Size = new System.Drawing.Size(194, 26);
            this.txt_Amount.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "About Yaer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "About Month";
            // 
            // txt_project
            // 
            this.txt_project.Location = new System.Drawing.Point(97, 229);
            this.txt_project.Name = "txt_project";
            this.txt_project.ReadOnly = true;
            this.txt_project.Size = new System.Drawing.Size(194, 26);
            this.txt_project.TabIndex = 1;
            // 
            // txt_position
            // 
            this.txt_position.Location = new System.Drawing.Point(96, 197);
            this.txt_position.Name = "txt_position";
            this.txt_position.ReadOnly = true;
            this.txt_position.Size = new System.Drawing.Size(194, 26);
            this.txt_position.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Amount";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 235);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Project";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(97, 133);
            this.txt_name.Name = "txt_name";
            this.txt_name.ReadOnly = true;
            this.txt_name.Size = new System.Drawing.Size(194, 26);
            this.txt_name.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Position";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name";
            // 
            // txt_Id
            // 
            this.txt_Id.Location = new System.Drawing.Point(33, 37);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.ReadOnly = true;
            this.txt_Id.Size = new System.Drawing.Size(100, 26);
            this.txt_Id.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(92, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "QB";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(139, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "SN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(Mercy_Accounting.TB_Expensse);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(726, 542);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.coldate,
            this.colName,
            this.colAmount,
            this.colPosition,
            this.colProject,
            this.colAbut_Month,
            this.coldetatils});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // coldate
            // 
            this.coldate.FieldName = "date";
            this.coldate.Name = "coldate";
            this.coldate.Visible = true;
            this.coldate.VisibleIndex = 1;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 2;
            // 
            // colAmount
            // 
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 3;
            // 
            // colPosition
            // 
            this.colPosition.FieldName = "Position";
            this.colPosition.Name = "colPosition";
            this.colPosition.Visible = true;
            this.colPosition.VisibleIndex = 4;
            // 
            // colProject
            // 
            this.colProject.FieldName = "Project";
            this.colProject.Name = "colProject";
            this.colProject.Visible = true;
            this.colProject.VisibleIndex = 5;
            // 
            // colAbut_Month
            // 
            this.colAbut_Month.FieldName = "Abut_Month";
            this.colAbut_Month.Name = "colAbut_Month";
            this.colAbut_Month.Visible = true;
            this.colAbut_Month.VisibleIndex = 6;
            // 
            // coldetatils
            // 
            this.coldetatils.FieldName = "detatils";
            this.coldetatils.Name = "coldetatils";
            this.coldetatils.Visible = true;
            this.coldetatils.VisibleIndex = 7;
            // 
            // txt_sn
            // 
            this.txt_sn.Location = new System.Drawing.Point(170, 38);
            this.txt_sn.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txt_sn.Name = "txt_sn";
            this.txt_sn.Size = new System.Drawing.Size(120, 26);
            this.txt_sn.TabIndex = 5;
            // 
            // txt_qb
            // 
            this.txt_qb.Location = new System.Drawing.Point(126, 73);
            this.txt_qb.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txt_qb.Name = "txt_qb";
            this.txt_qb.Size = new System.Drawing.Size(120, 26);
            this.txt_qb.TabIndex = 5;
            // 
            // Add_Expansess_Month
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 542);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Name = "Add_Expansess_Month";
            this.Text = "Add_Credit_Month";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_qb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker txt_Date;
        private System.Windows.Forms.TextBox txt_Note;
        private System.Windows.Forms.TextBox txt_About;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Amount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_position;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.TextBox txt_yaer;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.SimpleButton btn_Add;
        private System.Windows.Forms.RadioButton chec_paid;
        private DevExpress.XtraEditors.SimpleButton btn_show;
        private System.Windows.Forms.TextBox txt_project;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn coldate;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colPosition;
        private DevExpress.XtraGrid.Columns.GridColumn colProject;
        private DevExpress.XtraGrid.Columns.GridColumn colAbut_Month;
        private DevExpress.XtraGrid.Columns.GridColumn coldetatils;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        public System.Windows.Forms.NumericUpDown txt_qb;
        public System.Windows.Forms.NumericUpDown txt_sn;
    }
}
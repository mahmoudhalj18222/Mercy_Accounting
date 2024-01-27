namespace Mercy_Accounting.Form_2
{
    partial class Export_Excel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Export_Excel));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btn_data = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btn_import_Excel_to_sql = new DevExpress.XtraEditors.SimpleButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_sheet = new DevExpress.XtraEditors.TextEdit();
            this.txt_path = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sheet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_path.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Location = new System.Drawing.Point(0, 130);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1320, 589);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 431;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsEditForm.PopupEditFormWidth = 933;
            // 
            // btn_data
            // 
            this.btn_data.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_data.ImageOptions.Image")));
            this.btn_data.Location = new System.Drawing.Point(555, 54);
            this.btn_data.Margin = new System.Windows.Forms.Padding(4);
            this.btn_data.Name = "btn_data";
            this.btn_data.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_data.Size = new System.Drawing.Size(99, 39);
            this.btn_data.TabIndex = 1;
            this.btn_data.Text = "Show Data";
            this.btn_data.Click += new System.EventHandler(this.btn_data_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1320, 122);
            this.panel1.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.comboBoxEdit1);
            this.panel4.Controls.Add(this.btn_import_Excel_to_sql);
            this.panel4.Location = new System.Drawing.Point(690, 14);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(399, 101);
            this.panel4.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tabel Name";
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Location = new System.Drawing.Point(142, 17);
            this.comboBoxEdit1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Properties.Items.AddRange(new object[] {
            "Project",
            "Supplier",
            "Report"});
            this.comboBoxEdit1.Size = new System.Drawing.Size(198, 22);
            this.comboBoxEdit1.TabIndex = 4;
            // 
            // btn_import_Excel_to_sql
            // 
            this.btn_import_Excel_to_sql.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_import_Excel_to_sql.ImageOptions.SvgImage")));
            this.btn_import_Excel_to_sql.Location = new System.Drawing.Point(142, 59);
            this.btn_import_Excel_to_sql.Margin = new System.Windows.Forms.Padding(4);
            this.btn_import_Excel_to_sql.Name = "btn_import_Excel_to_sql";
            this.btn_import_Excel_to_sql.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btn_import_Excel_to_sql.Size = new System.Drawing.Size(161, 28);
            this.btn_import_Excel_to_sql.TabIndex = 6;
            this.btn_import_Excel_to_sql.Text = "import Excel to sql";
            this.btn_import_Excel_to_sql.Click += new System.EventHandler(this.btn_import_Excel_to_sql_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txt_sheet);
            this.panel3.Controls.Add(this.txt_path);
            this.panel3.Controls.Add(this.btn_data);
            this.panel3.Controls.Add(this.labelControl1);
            this.panel3.Controls.Add(this.simpleButton1);
            this.panel3.Location = new System.Drawing.Point(13, 14);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(669, 100);
            this.panel3.TabIndex = 5;
            // 
            // txt_sheet
            // 
            this.txt_sheet.Location = new System.Drawing.Point(18, 62);
            this.txt_sheet.Margin = new System.Windows.Forms.Padding(4);
            this.txt_sheet.Name = "txt_sheet";
            this.txt_sheet.Size = new System.Drawing.Size(374, 22);
            this.txt_sheet.TabIndex = 4;
            // 
            // txt_path
            // 
            this.txt_path.Location = new System.Drawing.Point(18, 17);
            this.txt_path.Margin = new System.Windows.Forms.Padding(4);
            this.txt_path.Name = "txt_path";
            this.txt_path.Properties.ReadOnly = true;
            this.txt_path.Size = new System.Drawing.Size(374, 22);
            this.txt_path.TabIndex = 5;
            // 
            // labelControl1
            // 
            this.labelControl1.ImageOptions.Alignment = System.Drawing.ContentAlignment.TopLeft;
            this.labelControl1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("labelControl1.ImageOptions.Image")));
            this.labelControl1.Location = new System.Drawing.Point(399, 64);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(94, 16);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "      Name Sheet";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(399, 15);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton1.Size = new System.Drawing.Size(88, 28);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "Open File";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1320, 719);
            this.panel2.TabIndex = 8;
            // 
            // Export_Excel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 719);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Export_Excel";
            this.Text = "Export_Excel";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_sheet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_path.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btn_data;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraEditors.SimpleButton btn_import_Excel_to_sql;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.TextEdit txt_sheet;
        private DevExpress.XtraEditors.TextEdit txt_path;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Panel panel2;
    }
}

namespace Mercy_Accounting.Form
{
    partial class Employee
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEmp_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmp_Phone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmp_Zoho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmp_State = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmp_Name_Ar = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(Mercy_Accounting.TB_Employee);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(769, 393);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.GroupPanel.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.GroupPanel.Options.UseFont = true;
            this.gridView1.Appearance.GroupPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.GroupPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.GroupPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.Row.Options.UseTextOptions = true;
            this.gridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.Appearance.TopNewRow.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.TopNewRow.Options.UseFont = true;
            this.gridView1.Appearance.TopNewRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.TopNewRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.TopNewRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView1.Appearance.TopNewRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEmp_Name,
            this.colEmp_Phone,
            this.colEmp_Zoho,
            this.colEmp_State,
            this.colEmp_Name_Ar});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colEmp_Name
            // 
            this.colEmp_Name.Caption = "Name";
            this.colEmp_Name.FieldName = "Emp_Name";
            this.colEmp_Name.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colEmp_Name.ImageOptions.Image")));
            this.colEmp_Name.Name = "colEmp_Name";
            this.colEmp_Name.Visible = true;
            this.colEmp_Name.VisibleIndex = 0;
            // 
            // colEmp_Phone
            // 
            this.colEmp_Phone.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.colEmp_Phone.AppearanceCell.Options.UseForeColor = true;
            this.colEmp_Phone.Caption = "Phone";
            this.colEmp_Phone.FieldName = "Emp_Phone";
            this.colEmp_Phone.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colEmp_Phone.ImageOptions.Image")));
            this.colEmp_Phone.Name = "colEmp_Phone";
            this.colEmp_Phone.Visible = true;
            this.colEmp_Phone.VisibleIndex = 2;
            // 
            // colEmp_Zoho
            // 
            this.colEmp_Zoho.Caption = "ID";
            this.colEmp_Zoho.FieldName = "Emp_Zoho";
            this.colEmp_Zoho.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colEmp_Zoho.ImageOptions.Image")));
            this.colEmp_Zoho.Name = "colEmp_Zoho";
            this.colEmp_Zoho.Visible = true;
            this.colEmp_Zoho.VisibleIndex = 3;
            // 
            // colEmp_State
            // 
            this.colEmp_State.AppearanceCell.ForeColor = System.Drawing.Color.Blue;
            this.colEmp_State.AppearanceCell.Options.UseForeColor = true;
            this.colEmp_State.Caption = "State";
            this.colEmp_State.FieldName = "Emp_State";
            this.colEmp_State.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colEmp_State.ImageOptions.Image")));
            this.colEmp_State.Name = "colEmp_State";
            this.colEmp_State.Visible = true;
            this.colEmp_State.VisibleIndex = 4;
            // 
            // colEmp_Name_Ar
            // 
            this.colEmp_Name_Ar.Caption = "Name Arabic";
            this.colEmp_Name_Ar.FieldName = "Emp_Name_Ar";
            this.colEmp_Name_Ar.Name = "colEmp_Name_Ar";
            this.colEmp_Name_Ar.OptionsFilter.AllowFilter = false;
            this.colEmp_Name_Ar.Visible = true;
            this.colEmp_Name_Ar.VisibleIndex = 1;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Name = "Employee";
            this.Size = new System.Drawing.Size(769, 393);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.Columns.GridColumn colEmp_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colEmp_Phone;
        private DevExpress.XtraGrid.Columns.GridColumn colEmp_Zoho;
        private DevExpress.XtraGrid.Columns.GridColumn colEmp_State;
        public DevExpress.XtraGrid.GridControl gridControl1;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colEmp_Name_Ar;
    }
}

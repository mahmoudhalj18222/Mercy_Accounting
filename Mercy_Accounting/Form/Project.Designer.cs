
namespace Mercy_Accounting.Form
{
    partial class Project
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Project));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPro_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPro_Date_Start = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPro_Date_End = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPro_Des = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPro_URL = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(Mercy_Accounting.TB_Project);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(398, 322);
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
            this.colPro_Name,
            this.colPro_Date_Start,
            this.colPro_Date_End,
            this.colPro_Des,
            this.colPro_URL});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsPrint.PrintPreview = true;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colPro_Name, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // colPro_Name
            // 
            this.colPro_Name.AppearanceHeader.Options.UseImage = true;
            this.colPro_Name.Caption = "Name";
            this.colPro_Name.FieldName = "Pro_Name";
            this.colPro_Name.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colPro_Name.ImageOptions.Image")));
            this.colPro_Name.Name = "colPro_Name";
            this.colPro_Name.Visible = true;
            this.colPro_Name.VisibleIndex = 0;
            // 
            // colPro_Date_Start
            // 
            this.colPro_Date_Start.AppearanceHeader.Options.UseImage = true;
            this.colPro_Date_Start.Caption = "Date Start";
            this.colPro_Date_Start.FieldName = "Pro_Date_Start";
            this.colPro_Date_Start.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colPro_Date_Start.ImageOptions.Image")));
            this.colPro_Date_Start.Name = "colPro_Date_Start";
            this.colPro_Date_Start.Visible = true;
            this.colPro_Date_Start.VisibleIndex = 1;
            // 
            // colPro_Date_End
            // 
            this.colPro_Date_End.Caption = "Date End";
            this.colPro_Date_End.FieldName = "Pro_Date_End";
            this.colPro_Date_End.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colPro_Date_End.ImageOptions.Image")));
            this.colPro_Date_End.Name = "colPro_Date_End";
            this.colPro_Date_End.Visible = true;
            this.colPro_Date_End.VisibleIndex = 2;
            // 
            // colPro_Des
            // 
            this.colPro_Des.Caption = "Details";
            this.colPro_Des.FieldName = "Pro_Des";
            this.colPro_Des.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colPro_Des.ImageOptions.Image")));
            this.colPro_Des.Name = "colPro_Des";
            this.colPro_Des.Visible = true;
            this.colPro_Des.VisibleIndex = 3;
            // 
            // colPro_URL
            // 
            this.colPro_URL.AppearanceCell.ForeColor = System.Drawing.Color.Blue;
            this.colPro_URL.AppearanceCell.Options.UseForeColor = true;
            this.colPro_URL.Caption = "Link";
            this.colPro_URL.FieldName = "Pro_URL";
            this.colPro_URL.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colPro_URL.ImageOptions.Image")));
            this.colPro_URL.Name = "colPro_URL";
            this.colPro_URL.Visible = true;
            this.colPro_URL.VisibleIndex = 4;
            // 
            // Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Name = "Project";
            this.Size = new System.Drawing.Size(398, 322);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.Columns.GridColumn colPro_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colPro_Date_Start;
        private DevExpress.XtraGrid.Columns.GridColumn colPro_Date_End;
        private DevExpress.XtraGrid.Columns.GridColumn colPro_Des;
        private DevExpress.XtraGrid.Columns.GridColumn colPro_URL;
        public DevExpress.XtraGrid.GridControl gridControl1;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}

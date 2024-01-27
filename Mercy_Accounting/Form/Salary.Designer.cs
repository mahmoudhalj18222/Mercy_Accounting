
namespace Mercy_Accounting.Form
{
    partial class Salary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salary));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNet_Deu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProject = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPayroll = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFor_manth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPosition = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(Mercy_Accounting.TB_Salary);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(790, 440);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.Row.Options.UseTextOptions = true;
            this.gridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colName,
            this.colNet_Deu,
            this.colProject,
            this.colPayroll,
            this.colFor_manth,
            this.colPosition});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsMenu.ShowAddNewSummaryItem = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsMenu.ShowFooterItem = true;
            this.gridView1.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gridView1.OptionsMenu.ShowSummaryItemMode = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsPrint.PrintPreview = true;
            this.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colID
            // 
            this.colID.AppearanceCell.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.colID.AppearanceCell.ForeColor = System.Drawing.Color.Red;
            this.colID.AppearanceCell.Options.UseFont = true;
            this.colID.AppearanceCell.Options.UseForeColor = true;
            this.colID.AppearanceHeader.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.colID.AppearanceHeader.Options.UseFont = true;
            this.colID.Caption = "ID";
            this.colID.FieldName = "ID";
            this.colID.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colID.ImageOptions.Image")));
            this.colID.Name = "colID";
            this.colID.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, DevExpress.Data.SummaryMode.Selection, "Net_Deu", "SUM={0:0.##}")});
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 40;
            // 
            // colName
            // 
            this.colName.AppearanceCell.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.colName.AppearanceCell.Options.UseFont = true;
            this.colName.AppearanceHeader.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.colName.AppearanceHeader.Options.UseFont = true;
            this.colName.Caption = "Name";
            this.colName.FieldName = "Name";
            this.colName.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colName.ImageOptions.Image")));
            this.colName.Name = "colName";
            this.colName.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Name", "{0}")});
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            this.colName.Width = 90;
            // 
            // colNet_Deu
            // 
            this.colNet_Deu.AppearanceCell.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.colNet_Deu.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.colNet_Deu.AppearanceCell.Options.UseFont = true;
            this.colNet_Deu.AppearanceCell.Options.UseForeColor = true;
            this.colNet_Deu.AppearanceHeader.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.colNet_Deu.AppearanceHeader.Options.UseFont = true;
            this.colNet_Deu.Caption = "net_Deu";
            this.colNet_Deu.FieldName = "Net_Deu";
            this.colNet_Deu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colNet_Deu.ImageOptions.Image")));
            this.colNet_Deu.Name = "colNet_Deu";
            this.colNet_Deu.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Net_Deu", "SUM={0:0.##}")});
            this.colNet_Deu.Visible = true;
            this.colNet_Deu.VisibleIndex = 2;
            this.colNet_Deu.Width = 38;
            // 
            // colProject
            // 
            this.colProject.AppearanceCell.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.colProject.AppearanceCell.Options.UseFont = true;
            this.colProject.AppearanceHeader.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.colProject.AppearanceHeader.Options.UseFont = true;
            this.colProject.Caption = "Project";
            this.colProject.FieldName = "Project";
            this.colProject.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colProject.ImageOptions.Image")));
            this.colProject.Name = "colProject";
            this.colProject.Visible = true;
            this.colProject.VisibleIndex = 4;
            this.colProject.Width = 90;
            // 
            // colPayroll
            // 
            this.colPayroll.AppearanceCell.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.colPayroll.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.colPayroll.AppearanceCell.Options.UseFont = true;
            this.colPayroll.AppearanceCell.Options.UseForeColor = true;
            this.colPayroll.AppearanceHeader.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.colPayroll.AppearanceHeader.Options.UseFont = true;
            this.colPayroll.Caption = "Payroll";
            this.colPayroll.FieldName = "Payroll";
            this.colPayroll.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colPayroll.ImageOptions.Image")));
            this.colPayroll.Name = "colPayroll";
            this.colPayroll.Visible = true;
            this.colPayroll.VisibleIndex = 6;
            this.colPayroll.Width = 35;
            // 
            // colFor_manth
            // 
            this.colFor_manth.AppearanceCell.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.colFor_manth.AppearanceCell.Options.UseFont = true;
            this.colFor_manth.AppearanceHeader.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.colFor_manth.AppearanceHeader.Options.UseFont = true;
            this.colFor_manth.Caption = "Abuat a month";
            this.colFor_manth.FieldName = "For_manth";
            this.colFor_manth.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colFor_manth.ImageOptions.Image")));
            this.colFor_manth.Name = "colFor_manth";
            this.colFor_manth.Visible = true;
            this.colFor_manth.VisibleIndex = 5;
            this.colFor_manth.Width = 44;
            // 
            // colPosition
            // 
            this.colPosition.AppearanceCell.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.colPosition.AppearanceCell.Options.UseFont = true;
            this.colPosition.AppearanceHeader.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.colPosition.AppearanceHeader.Options.UseFont = true;
            this.colPosition.Caption = "Position";
            this.colPosition.FieldName = "Position";
            this.colPosition.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colPosition.ImageOptions.Image")));
            this.colPosition.Name = "colPosition";
            this.colPosition.Visible = true;
            this.colPosition.VisibleIndex = 3;
            this.colPosition.Width = 147;
            // 
            // Salary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Name = "Salary";
            this.Size = new System.Drawing.Size(790, 440);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colNet_Deu;
        private DevExpress.XtraGrid.Columns.GridColumn colProject;
        private DevExpress.XtraGrid.Columns.GridColumn colPayroll;
        private DevExpress.XtraGrid.Columns.GridColumn colFor_manth;
        private DevExpress.XtraGrid.Columns.GridColumn colPosition;
        public DevExpress.XtraGrid.GridControl gridControl1;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}

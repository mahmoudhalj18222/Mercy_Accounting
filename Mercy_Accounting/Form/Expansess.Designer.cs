
namespace Mercy_Accounting.Form
{
    partial class Expansess
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Expansess));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPosition = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProject = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAbut_Month = new DevExpress.XtraGrid.Columns.GridColumn();
            this.view = new Mercy_Accounting.View();
            this.viewexpansessBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_expansessTableAdapter = new Mercy_Accounting.ViewTableAdapters.View_expansessTableAdapter();
            this.view_DetalisTableAdapter1 = new Mercy_Accounting.ViewTableAdapters.View_DetalisTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewexpansessBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.viewexpansessBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.gridView2;
            gridLevelNode1.RelationName = "Detalis";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(806, 508);
            this.gridControl1.TabIndex = 9;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2,
            this.gridView1});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName1,
            this.colAmount1});
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowFooter = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colName1
            // 
            this.colName1.AppearanceCell.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.colName1.AppearanceCell.Options.UseFont = true;
            this.colName1.AppearanceHeader.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.colName1.AppearanceHeader.Options.UseFont = true;
            this.colName1.FieldName = "Name";
            this.colName1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colName1.ImageOptions.Image")));
            this.colName1.Name = "colName1";
            this.colName1.Visible = true;
            this.colName1.VisibleIndex = 0;
            // 
            // colAmount1
            // 
            this.colAmount1.AppearanceCell.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.colAmount1.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.colAmount1.AppearanceCell.Options.UseFont = true;
            this.colAmount1.AppearanceCell.Options.UseForeColor = true;
            this.colAmount1.AppearanceHeader.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.colAmount1.AppearanceHeader.Options.UseFont = true;
            this.colAmount1.FieldName = "Amount";
            this.colAmount1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colAmount1.ImageOptions.Image")));
            this.colAmount1.Name = "colAmount1";
            this.colAmount1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Amount", "SUM={0:0.##}")});
            this.colAmount1.Visible = true;
            this.colAmount1.VisibleIndex = 1;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.FocusedRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.Appearance.GroupRow.Options.UseTextOptions = true;
            this.gridView1.Appearance.GroupRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.Appearance.Row.Options.UseTextOptions = true;
            this.gridView1.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNumber,
            this.colName,
            this.colPosition,
            this.colProject,
            this.colAmount,
            this.coldate,
            this.colAbut_Month});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colNumber, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colNumber
            // 
            this.colNumber.AppearanceCell.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.colNumber.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.colNumber.AppearanceCell.Options.UseFont = true;
            this.colNumber.AppearanceCell.Options.UseForeColor = true;
            this.colNumber.AppearanceCell.Options.UseTextOptions = true;
            this.colNumber.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colNumber.AppearanceHeader.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.colNumber.AppearanceHeader.Options.UseFont = true;
            this.colNumber.Caption = "Number";
            this.colNumber.FieldName = "Number";
            this.colNumber.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colNumber.ImageOptions.Image")));
            this.colNumber.Name = "colNumber";
            this.colNumber.Visible = true;
            this.colNumber.VisibleIndex = 0;
            this.colNumber.Width = 62;
            // 
            // colName
            // 
            this.colName.AppearanceCell.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.colName.AppearanceCell.Options.UseFont = true;
            this.colName.AppearanceCell.Options.UseTextOptions = true;
            this.colName.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colName.AppearanceHeader.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.colName.AppearanceHeader.Options.UseFont = true;
            this.colName.AppearanceHeader.Options.UseTextOptions = true;
            this.colName.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colName.FieldName = "Name";
            this.colName.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colName.ImageOptions.Image")));
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            this.colName.Width = 126;
            // 
            // colPosition
            // 
            this.colPosition.AppearanceCell.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.colPosition.AppearanceCell.Options.UseFont = true;
            this.colPosition.AppearanceCell.Options.UseTextOptions = true;
            this.colPosition.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.colPosition.AppearanceHeader.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.colPosition.AppearanceHeader.Options.UseFont = true;
            this.colPosition.FieldName = "Position";
            this.colPosition.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colPosition.ImageOptions.Image")));
            this.colPosition.Name = "colPosition";
            this.colPosition.Visible = true;
            this.colPosition.VisibleIndex = 3;
            this.colPosition.Width = 229;
            // 
            // colProject
            // 
            this.colProject.AppearanceCell.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.colProject.AppearanceCell.Options.UseFont = true;
            this.colProject.AppearanceHeader.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.colProject.AppearanceHeader.Options.UseFont = true;
            this.colProject.FieldName = "Project";
            this.colProject.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colProject.ImageOptions.Image")));
            this.colProject.Name = "colProject";
            this.colProject.Visible = true;
            this.colProject.VisibleIndex = 4;
            this.colProject.Width = 185;
            // 
            // colAmount
            // 
            this.colAmount.AppearanceCell.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.colAmount.AppearanceCell.ForeColor = System.Drawing.Color.Red;
            this.colAmount.AppearanceCell.Options.UseFont = true;
            this.colAmount.AppearanceCell.Options.UseForeColor = true;
            this.colAmount.AppearanceCell.Options.UseTextOptions = true;
            this.colAmount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colAmount.AppearanceHeader.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.colAmount.AppearanceHeader.Options.UseFont = true;
            this.colAmount.FieldName = "Amount";
            this.colAmount.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colAmount.ImageOptions.Image")));
            this.colAmount.Name = "colAmount";
            this.colAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Amount", "SUM={0:0.##}")});
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 2;
            this.colAmount.Width = 83;
            // 
            // coldate
            // 
            this.coldate.AppearanceCell.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.coldate.AppearanceCell.Options.UseFont = true;
            this.coldate.AppearanceHeader.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.coldate.AppearanceHeader.Options.UseFont = true;
            this.coldate.FieldName = "date";
            this.coldate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("coldate.ImageOptions.Image")));
            this.coldate.Name = "coldate";
            // 
            // colAbut_Month
            // 
            this.colAbut_Month.AppearanceCell.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colAbut_Month.AppearanceCell.Options.UseFont = true;
            this.colAbut_Month.AppearanceHeader.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colAbut_Month.AppearanceHeader.Options.UseFont = true;
            this.colAbut_Month.Caption = "About Month";
            this.colAbut_Month.FieldName = "Abut_Month";
            this.colAbut_Month.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("colAbut_Month.ImageOptions.Image")));
            this.colAbut_Month.Name = "colAbut_Month";
            this.colAbut_Month.Visible = true;
            this.colAbut_Month.VisibleIndex = 5;
            // 
            // view
            // 
            this.view.DataSetName = "View";
            this.view.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewexpansessBindingSource
            // 
            this.viewexpansessBindingSource.DataMember = "View_expansess";
            this.viewexpansessBindingSource.DataSource = this.view;
            // 
            // view_expansessTableAdapter
            // 
            this.view_expansessTableAdapter.ClearBeforeFill = true;
            // 
            // view_DetalisTableAdapter1
            // 
            this.view_DetalisTableAdapter1.ClearBeforeFill = true;
            // 
            // Expansess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Name = "Expansess";
            this.Size = new System.Drawing.Size(806, 508);
            this.Load += new System.EventHandler(this.Expansess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewexpansessBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.BindingSource viewexpansessBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colName1;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount1;
        private DevExpress.XtraGrid.Columns.GridColumn colNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colPosition;
        private DevExpress.XtraGrid.Columns.GridColumn colProject;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn coldate;
        private DevExpress.XtraGrid.Columns.GridColumn colAbut_Month;
        public ViewTableAdapters.View_expansessTableAdapter view_expansessTableAdapter;
        public ViewTableAdapters.View_DetalisTableAdapter view_DetalisTableAdapter1;
        public DevExpress.XtraGrid.GridControl gridControl1;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        public View view;
    }
}

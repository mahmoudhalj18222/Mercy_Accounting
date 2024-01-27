
namespace Mercy_Accounting.Form
{
    partial class Supplier
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.entityInstantFeedbackSource2 = new DevExpress.Data.Linq.EntityInstantFeedbackSource();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategorie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDetalies = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategoire = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIBAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colALICI_PTT_MUSTERI_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colALICI_PTT_HESAP_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.entityInstantFeedbackSource1 = new DevExpress.Data.Linq.EntityInstantFeedbackSource();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.entityInstantFeedbackSource2;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1231, 670);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // entityInstantFeedbackSource2
            // 
            this.entityInstantFeedbackSource2.DefaultSorting = "ID ASC";
            this.entityInstantFeedbackSource2.DesignTimeElementType = typeof(Mercy_Accounting.Supplier);
            this.entityInstantFeedbackSource2.KeyExpression = "ID";
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
            this.colID,
            this.colName,
            this.colPhone,
            this.colEmail,
            this.colAddress,
            this.colCategorie,
            this.colDetalies,
            this.colCategoire,
            this.colIBAN,
            this.colALICI_PTT_MUSTERI_NO,
            this.colALICI_PTT_HESAP_NO});
            this.gridView1.DetailHeight = 431;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsEditForm.PopupEditFormWidth = 933;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colID, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.MinWidth = 25;
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 107;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.MinWidth = 25;
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            this.colName.Width = 354;
            // 
            // colPhone
            // 
            this.colPhone.FieldName = "Phone";
            this.colPhone.MinWidth = 25;
            this.colPhone.Name = "colPhone";
            this.colPhone.Visible = true;
            this.colPhone.VisibleIndex = 2;
            this.colPhone.Width = 271;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.MinWidth = 25;
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 3;
            this.colEmail.Width = 345;
            // 
            // colAddress
            // 
            this.colAddress.FieldName = "Address";
            this.colAddress.MinWidth = 25;
            this.colAddress.Name = "colAddress";
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 4;
            this.colAddress.Width = 383;
            // 
            // colCategorie
            // 
            this.colCategorie.FieldName = "Categorie";
            this.colCategorie.MinWidth = 25;
            this.colCategorie.Name = "colCategorie";
            this.colCategorie.Width = 239;
            // 
            // colDetalies
            // 
            this.colDetalies.FieldName = "Detalies";
            this.colDetalies.MinWidth = 25;
            this.colDetalies.Name = "colDetalies";
            this.colDetalies.Visible = true;
            this.colDetalies.VisibleIndex = 5;
            this.colDetalies.Width = 380;
            // 
            // colCategoire
            // 
            this.colCategoire.FieldName = "Categoire";
            this.colCategoire.MinWidth = 25;
            this.colCategoire.Name = "colCategoire";
            this.colCategoire.Width = 178;
            // 
            // colIBAN
            // 
            this.colIBAN.FieldName = "IBAN";
            this.colIBAN.MinWidth = 25;
            this.colIBAN.Name = "colIBAN";
            this.colIBAN.Visible = true;
            this.colIBAN.VisibleIndex = 6;
            this.colIBAN.Width = 433;
            // 
            // colALICI_PTT_MUSTERI_NO
            // 
            this.colALICI_PTT_MUSTERI_NO.FieldName = "ALICI_PTT_MUSTERI_NO";
            this.colALICI_PTT_MUSTERI_NO.MinWidth = 25;
            this.colALICI_PTT_MUSTERI_NO.Name = "colALICI_PTT_MUSTERI_NO";
            this.colALICI_PTT_MUSTERI_NO.Visible = true;
            this.colALICI_PTT_MUSTERI_NO.VisibleIndex = 7;
            this.colALICI_PTT_MUSTERI_NO.Width = 297;
            // 
            // colALICI_PTT_HESAP_NO
            // 
            this.colALICI_PTT_HESAP_NO.FieldName = "ALICI_PTT_HESAP_NO";
            this.colALICI_PTT_HESAP_NO.MinWidth = 25;
            this.colALICI_PTT_HESAP_NO.Name = "colALICI_PTT_HESAP_NO";
            this.colALICI_PTT_HESAP_NO.Visible = true;
            this.colALICI_PTT_HESAP_NO.VisibleIndex = 8;
            this.colALICI_PTT_HESAP_NO.Width = 612;
            // 
            // entityInstantFeedbackSource1
            // 
            this.entityInstantFeedbackSource1.DefaultSorting = "ID ASC";
            this.entityInstantFeedbackSource1.DesignTimeElementType = typeof(Mercy_Accounting.Categoire);
            this.entityInstantFeedbackSource1.KeyExpression = "ID";
            // 
            // Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Supplier";
            this.Size = new System.Drawing.Size(1231, 670);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public DevExpress.XtraGrid.GridControl gridControl1;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.Data.Linq.EntityInstantFeedbackSource entityInstantFeedbackSource1;
        private DevExpress.Data.Linq.EntityInstantFeedbackSource entityInstantFeedbackSource2;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colCategorie;
        private DevExpress.XtraGrid.Columns.GridColumn colDetalies;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoire;
        private DevExpress.XtraGrid.Columns.GridColumn colIBAN;
        private DevExpress.XtraGrid.Columns.GridColumn colALICI_PTT_MUSTERI_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colALICI_PTT_HESAP_NO;
    }
}

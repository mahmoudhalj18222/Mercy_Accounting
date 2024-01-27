namespace Mercy_Accounting.Form
{
    partial class Payment_Request
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
            this.entityInstantFeedbackSource1 = new DevExpress.Data.Linq.EntityInstantFeedbackSource();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDue_Date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProject_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFunded_By = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPR_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBudget_line = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrency = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReference_Number = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPayment_method = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransfer_to = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPTT_Bank_Info = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMUSTERI_NO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIBAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPayment_Date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNotes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLink_for_details = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReporting = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdd_By = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.entityInstantFeedbackSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1157, 635);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // entityInstantFeedbackSource1
            // 
            this.entityInstantFeedbackSource1.DefaultSorting = null;
            this.entityInstantFeedbackSource1.DesignTimeElementType = typeof(Mercy_Accounting.TB_Payment_Request);
            this.entityInstantFeedbackSource1.KeyExpression = "Id";
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.Appearance.Preview.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Preview.Options.UseFont = true;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.Row.Options.UseTextOptions = true;
            this.gridView1.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colDate,
            this.colDue_Date,
            this.colProject_Name,
            this.colFunded_By,
            this.colPR_NO,
            this.colBudget_line,
            this.colType,
            this.colCurrency,
            this.colAmount,
            this.colReference_Number,
            this.colPayment_method,
            this.colTransfer_to,
            this.colPTT_Bank_Info,
            this.colMUSTERI_NO,
            this.colIBAN,
            this.colStatus,
            this.colPayment_Date,
            this.colNotes,
            this.colLink_for_details,
            this.colReporting,
            this.colAdd_By});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsPrint.PrintDetails = true;
            this.gridView1.OptionsPrint.PrintFilterInfo = true;
            this.gridView1.OptionsPrint.PrintSelectedRowsOnly = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colId, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.MinWidth = 25;
            this.colId.Name = "colId";
            this.colId.Width = 94;
            // 
            // colDate
            // 
            this.colDate.FieldName = "Date";
            this.colDate.MinWidth = 25;
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 0;
            this.colDate.Width = 94;
            // 
            // colDue_Date
            // 
            this.colDue_Date.FieldName = "Due_Date";
            this.colDue_Date.MinWidth = 25;
            this.colDue_Date.Name = "colDue_Date";
            this.colDue_Date.Visible = true;
            this.colDue_Date.VisibleIndex = 1;
            this.colDue_Date.Width = 94;
            // 
            // colProject_Name
            // 
            this.colProject_Name.FieldName = "Project_Name";
            this.colProject_Name.MinWidth = 25;
            this.colProject_Name.Name = "colProject_Name";
            this.colProject_Name.Visible = true;
            this.colProject_Name.VisibleIndex = 2;
            this.colProject_Name.Width = 159;
            // 
            // colFunded_By
            // 
            this.colFunded_By.FieldName = "Funded_By";
            this.colFunded_By.MinWidth = 25;
            this.colFunded_By.Name = "colFunded_By";
            this.colFunded_By.Visible = true;
            this.colFunded_By.VisibleIndex = 3;
            this.colFunded_By.Width = 94;
            // 
            // colPR_NO
            // 
            this.colPR_NO.FieldName = "PR_NO";
            this.colPR_NO.MinWidth = 25;
            this.colPR_NO.Name = "colPR_NO";
            this.colPR_NO.Visible = true;
            this.colPR_NO.VisibleIndex = 4;
            this.colPR_NO.Width = 142;
            // 
            // colBudget_line
            // 
            this.colBudget_line.FieldName = "Budget_line";
            this.colBudget_line.MinWidth = 25;
            this.colBudget_line.Name = "colBudget_line";
            this.colBudget_line.Visible = true;
            this.colBudget_line.VisibleIndex = 5;
            this.colBudget_line.Width = 86;
            // 
            // colType
            // 
            this.colType.FieldName = "Type";
            this.colType.MinWidth = 25;
            this.colType.Name = "colType";
            this.colType.Visible = true;
            this.colType.VisibleIndex = 6;
            this.colType.Width = 94;
            // 
            // colCurrency
            // 
            this.colCurrency.FieldName = "Currency";
            this.colCurrency.MinWidth = 25;
            this.colCurrency.Name = "colCurrency";
            this.colCurrency.Visible = true;
            this.colCurrency.VisibleIndex = 7;
            this.colCurrency.Width = 76;
            // 
            // colAmount
            // 
            this.colAmount.FieldName = "Amount";
            this.colAmount.MinWidth = 25;
            this.colAmount.Name = "colAmount";
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 8;
            this.colAmount.Width = 94;
            // 
            // colReference_Number
            // 
            this.colReference_Number.FieldName = "Reference_Number";
            this.colReference_Number.MinWidth = 25;
            this.colReference_Number.Name = "colReference_Number";
            this.colReference_Number.Visible = true;
            this.colReference_Number.VisibleIndex = 9;
            this.colReference_Number.Width = 89;
            // 
            // colPayment_method
            // 
            this.colPayment_method.FieldName = "Payment_method";
            this.colPayment_method.MinWidth = 25;
            this.colPayment_method.Name = "colPayment_method";
            this.colPayment_method.Visible = true;
            this.colPayment_method.VisibleIndex = 10;
            this.colPayment_method.Width = 112;
            // 
            // colTransfer_to
            // 
            this.colTransfer_to.FieldName = "Transfer_to";
            this.colTransfer_to.MinWidth = 25;
            this.colTransfer_to.Name = "colTransfer_to";
            this.colTransfer_to.Visible = true;
            this.colTransfer_to.VisibleIndex = 11;
            this.colTransfer_to.Width = 163;
            // 
            // colPTT_Bank_Info
            // 
            this.colPTT_Bank_Info.FieldName = "PTT_Bank_Info";
            this.colPTT_Bank_Info.MinWidth = 25;
            this.colPTT_Bank_Info.Name = "colPTT_Bank_Info";
            this.colPTT_Bank_Info.Visible = true;
            this.colPTT_Bank_Info.VisibleIndex = 12;
            this.colPTT_Bank_Info.Width = 164;
            // 
            // colMUSTERI_NO
            // 
            this.colMUSTERI_NO.FieldName = "MUSTERI_NO";
            this.colMUSTERI_NO.MinWidth = 25;
            this.colMUSTERI_NO.Name = "colMUSTERI_NO";
            this.colMUSTERI_NO.Visible = true;
            this.colMUSTERI_NO.VisibleIndex = 13;
            this.colMUSTERI_NO.Width = 203;
            // 
            // colIBAN
            // 
            this.colIBAN.FieldName = "IBAN";
            this.colIBAN.MinWidth = 25;
            this.colIBAN.Name = "colIBAN";
            this.colIBAN.Visible = true;
            this.colIBAN.VisibleIndex = 14;
            this.colIBAN.Width = 299;
            // 
            // colStatus
            // 
            this.colStatus.FieldName = "Status";
            this.colStatus.MinWidth = 25;
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 15;
            this.colStatus.Width = 138;
            // 
            // colPayment_Date
            // 
            this.colPayment_Date.FieldName = "Payment_Date";
            this.colPayment_Date.MinWidth = 25;
            this.colPayment_Date.Name = "colPayment_Date";
            this.colPayment_Date.Visible = true;
            this.colPayment_Date.VisibleIndex = 16;
            this.colPayment_Date.Width = 94;
            // 
            // colNotes
            // 
            this.colNotes.FieldName = "Notes";
            this.colNotes.MinWidth = 25;
            this.colNotes.Name = "colNotes";
            this.colNotes.Visible = true;
            this.colNotes.VisibleIndex = 17;
            this.colNotes.Width = 293;
            // 
            // colLink_for_details
            // 
            this.colLink_for_details.FieldName = "Link_for_details";
            this.colLink_for_details.MinWidth = 25;
            this.colLink_for_details.Name = "colLink_for_details";
            this.colLink_for_details.Visible = true;
            this.colLink_for_details.VisibleIndex = 18;
            this.colLink_for_details.Width = 111;
            // 
            // colReporting
            // 
            this.colReporting.FieldName = "Reporting";
            this.colReporting.MinWidth = 25;
            this.colReporting.Name = "colReporting";
            this.colReporting.Visible = true;
            this.colReporting.VisibleIndex = 19;
            this.colReporting.Width = 94;
            // 
            // colAdd_By
            // 
            this.colAdd_By.FieldName = "Add_By";
            this.colAdd_By.MinWidth = 25;
            this.colAdd_By.Name = "colAdd_By";
            this.colAdd_By.Visible = true;
            this.colAdd_By.VisibleIndex = 20;
            this.colAdd_By.Width = 94;
            // 
            // Payment_Request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Name = "Payment_Request";
            this.Size = new System.Drawing.Size(1157, 635);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.Data.Linq.EntityInstantFeedbackSource entityInstantFeedbackSource1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colDue_Date;
        private DevExpress.XtraGrid.Columns.GridColumn colProject_Name;
        private DevExpress.XtraGrid.Columns.GridColumn colFunded_By;
        private DevExpress.XtraGrid.Columns.GridColumn colPR_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colBudget_line;
        private DevExpress.XtraGrid.Columns.GridColumn colType;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrency;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colReference_Number;
        private DevExpress.XtraGrid.Columns.GridColumn colPayment_method;
        private DevExpress.XtraGrid.Columns.GridColumn colTransfer_to;
        private DevExpress.XtraGrid.Columns.GridColumn colPTT_Bank_Info;
        private DevExpress.XtraGrid.Columns.GridColumn colMUSTERI_NO;
        private DevExpress.XtraGrid.Columns.GridColumn colIBAN;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colPayment_Date;
        private DevExpress.XtraGrid.Columns.GridColumn colNotes;
        private DevExpress.XtraGrid.Columns.GridColumn colLink_for_details;
        private DevExpress.XtraGrid.Columns.GridColumn colReporting;
        private DevExpress.XtraGrid.Columns.GridColumn colAdd_By;
    }
}

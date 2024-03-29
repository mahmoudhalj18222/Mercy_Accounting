﻿using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using DevExpress.XtraGrid.Views.Grid;

namespace Mercy_Accounting.Form
{
    public partial class Report_monthly : DevExpress.XtraEditors.XtraUserControl
    {
        DB_MercyEntities DB = new DB_MercyEntities();
        string monthly;
        string annual;
        public Report_monthly()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            Mercy_Accounting.DB_MercyEntities dbContext = new Mercy_Accounting.DB_MercyEntities();
            // Call the Load method to get the data for the given DbSet from the database.
            dbContext.TB_Monthly_Report.Load();
            // This line of code is generated by Data Source Configuration Wizard
            tB_Monthly_ReportBindingSource.DataSource = dbContext.TB_Monthly_Report.Local.ToBindingList();
        }

        private void btn_January_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            monthly = "January";
            Properties.Settings.Default.Report_monthly = monthly;
            Refresh_grid_control();
            btn_January.Appearance.ForeColor = Color.Red;
            btn_February.Appearance.ForeColor = Color.Black;
            btn_March.Appearance.ForeColor = Color.Black;
            btn_April.Appearance.ForeColor = Color.Black;
            btn_May.Appearance.ForeColor = Color.Black;
            btn_June.Appearance.ForeColor = Color.Black;
            btn_July.Appearance.ForeColor = Color.Black;
            btn_August.Appearance.ForeColor = Color.Black;
            btn_September.Appearance.ForeColor = Color.Black;
            btn_October.Appearance.ForeColor = Color.Black;
            btn_November.Appearance.ForeColor = Color.Black;
            btn_December.Appearance.ForeColor = Color.Black;
        }

        private void Refresh_grid_control()
        {
            DB = new DB_MercyEntities();
            gridControl1.DataSource = DB.TB_Monthly_Report.Where(x => x.Monthly == monthly && x.Annual == annual).ToList();
        }

        private void Report_monthly_Load(object sender, EventArgs e)
        {
            monthly = "January";
            Properties.Settings.Default.Report_monthly = monthly;
            Refresh_grid_control();
            btn_January.Appearance.ForeColor = Color.Red;
            btn_February.Appearance.ForeColor = Color.Black;
            btn_March.Appearance.ForeColor = Color.Black;
            btn_April.Appearance.ForeColor = Color.Black;
            btn_May.Appearance.ForeColor = Color.Black;
            btn_June.Appearance.ForeColor = Color.Black;
            btn_July.Appearance.ForeColor = Color.Black;
            btn_August.Appearance.ForeColor = Color.Black;
            btn_September.Appearance.ForeColor = Color.Black;
            btn_October.Appearance.ForeColor = Color.Black;
            btn_November.Appearance.ForeColor = Color.Black;
            btn_December.Appearance.ForeColor = Color.Black;
            annual = comboBox1.Text;
            Properties.Settings.Default.Report_annual = comboBox1.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            annual = comboBox1.Text;
            Properties.Settings.Default.Report_annual = comboBox1.Text;
            DB = new DB_MercyEntities();
            gridControl1.DataSource = DB.TB_Monthly_Report.Where(x => x.Annual == annual).ToList();
        }

        private void btn_February_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            monthly = "February";
            Properties.Settings.Default.Report_monthly = monthly;
            Refresh_grid_control();
            btn_January.Appearance.ForeColor = Color.Black;
            btn_February.Appearance.ForeColor = Color.Red;
            btn_March.Appearance.ForeColor = Color.Black;
            btn_April.Appearance.ForeColor = Color.Black;
            btn_May.Appearance.ForeColor = Color.Black;
            btn_June.Appearance.ForeColor = Color.Black;
            btn_July.Appearance.ForeColor = Color.Black;
            btn_August.Appearance.ForeColor = Color.Black;
            btn_September.Appearance.ForeColor = Color.Black;
            btn_October.Appearance.ForeColor = Color.Black;
            btn_November.Appearance.ForeColor = Color.Black;
            btn_December.Appearance.ForeColor = Color.Black;
        }

        private void btn_March_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            monthly = "March";
            Properties.Settings.Default.Report_monthly = monthly;
            Refresh_grid_control();
            btn_January.Appearance.ForeColor = Color.Black;
            btn_February.Appearance.ForeColor = Color.Black;
            btn_March.Appearance.ForeColor = Color.Red;
            btn_April.Appearance.ForeColor = Color.Black;
            btn_May.Appearance.ForeColor = Color.Black;
            btn_June.Appearance.ForeColor = Color.Black;
            btn_July.Appearance.ForeColor = Color.Black;
            btn_August.Appearance.ForeColor = Color.Black;
            btn_September.Appearance.ForeColor = Color.Black;
            btn_October.Appearance.ForeColor = Color.Black;
            btn_November.Appearance.ForeColor = Color.Black;
            btn_December.Appearance.ForeColor = Color.Black;
        }

        private void btn_April_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            monthly = "April";
            Properties.Settings.Default.Report_monthly = monthly;
            Refresh_grid_control();
            btn_January.Appearance.ForeColor = Color.Black;
            btn_February.Appearance.ForeColor = Color.Black;
            btn_March.Appearance.ForeColor = Color.Black;
            btn_April.Appearance.ForeColor = Color.Red;
            btn_May.Appearance.ForeColor = Color.Black;
            btn_June.Appearance.ForeColor = Color.Black;
            btn_July.Appearance.ForeColor = Color.Black;
            btn_August.Appearance.ForeColor = Color.Black;
            btn_September.Appearance.ForeColor = Color.Black;
            btn_October.Appearance.ForeColor = Color.Black;
            btn_November.Appearance.ForeColor = Color.Black;
            btn_December.Appearance.ForeColor = Color.Black;
        }

        private void btn_May_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            monthly = "May";
            Properties.Settings.Default.Report_monthly = monthly;
            Refresh_grid_control();
            btn_January.Appearance.ForeColor = Color.Black;
            btn_February.Appearance.ForeColor = Color.Black;
            btn_March.Appearance.ForeColor = Color.Black;
            btn_April.Appearance.ForeColor = Color.Black;
            btn_May.Appearance.ForeColor = Color.Red;
            btn_June.Appearance.ForeColor = Color.Black;
            btn_July.Appearance.ForeColor = Color.Black;
            btn_August.Appearance.ForeColor = Color.Black;
            btn_September.Appearance.ForeColor = Color.Black;
            btn_October.Appearance.ForeColor = Color.Black;
            btn_November.Appearance.ForeColor = Color.Black;
            btn_December.Appearance.ForeColor = Color.Black;
        }

        private void btn_June_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            monthly = "June";
            Properties.Settings.Default.Report_monthly = monthly;
            Refresh_grid_control();
            btn_January.Appearance.ForeColor = Color.Black;
            btn_February.Appearance.ForeColor = Color.Black;
            btn_March.Appearance.ForeColor = Color.Black;
            btn_April.Appearance.ForeColor = Color.Black;
            btn_May.Appearance.ForeColor = Color.Black;
            btn_June.Appearance.ForeColor = Color.Red;
            btn_July.Appearance.ForeColor = Color.Black;
            btn_August.Appearance.ForeColor = Color.Black;
            btn_September.Appearance.ForeColor = Color.Black;
            btn_October.Appearance.ForeColor = Color.Black;
            btn_November.Appearance.ForeColor = Color.Black;
            btn_December.Appearance.ForeColor = Color.Black;
        }

        private void btn_July_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            monthly = "July";
            Properties.Settings.Default.Report_monthly = monthly;
            Refresh_grid_control();
            btn_January.Appearance.ForeColor = Color.Black;
            btn_February.Appearance.ForeColor = Color.Black;
            btn_March.Appearance.ForeColor = Color.Black;
            btn_April.Appearance.ForeColor = Color.Black;
            btn_May.Appearance.ForeColor = Color.Black;
            btn_June.Appearance.ForeColor = Color.Black;
            btn_July.Appearance.ForeColor = Color.Red;
            btn_August.Appearance.ForeColor = Color.Black;
            btn_September.Appearance.ForeColor = Color.Black;
            btn_October.Appearance.ForeColor = Color.Black;
            btn_November.Appearance.ForeColor = Color.Black;
            btn_December.Appearance.ForeColor = Color.Black;
        }

        private void btn_August_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            monthly = "August";
            Properties.Settings.Default.Report_monthly = monthly;
            Refresh_grid_control();
            btn_January.Appearance.ForeColor = Color.Black;
            btn_February.Appearance.ForeColor = Color.Black;
            btn_March.Appearance.ForeColor = Color.Black;
            btn_April.Appearance.ForeColor = Color.Black;
            btn_May.Appearance.ForeColor = Color.Black;
            btn_June.Appearance.ForeColor = Color.Black;
            btn_July.Appearance.ForeColor = Color.Black;
            btn_August.Appearance.ForeColor = Color.Red;
            btn_September.Appearance.ForeColor = Color.Black;
            btn_October.Appearance.ForeColor = Color.Black;
            btn_November.Appearance.ForeColor = Color.Black;
            btn_December.Appearance.ForeColor = Color.Black;
        }

        private void btn_September_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            monthly = "September";
            Properties.Settings.Default.Report_monthly = monthly;
            Refresh_grid_control();
            btn_January.Appearance.ForeColor = Color.Black;
            btn_February.Appearance.ForeColor = Color.Black;
            btn_March.Appearance.ForeColor = Color.Black;
            btn_April.Appearance.ForeColor = Color.Black;
            btn_May.Appearance.ForeColor = Color.Black;
            btn_June.Appearance.ForeColor = Color.Black;
            btn_July.Appearance.ForeColor = Color.Black;
            btn_August.Appearance.ForeColor = Color.Black;
            btn_September.Appearance.ForeColor = Color.Red;
            btn_October.Appearance.ForeColor = Color.Black;
            btn_November.Appearance.ForeColor = Color.Black;
            btn_December.Appearance.ForeColor = Color.Black;
        }

        private void btn_October_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            monthly = "October";
            Properties.Settings.Default.Report_monthly = monthly;
            Refresh_grid_control();
            btn_January.Appearance.ForeColor = Color.Black;
            btn_February.Appearance.ForeColor = Color.Black;
            btn_March.Appearance.ForeColor = Color.Black;
            btn_April.Appearance.ForeColor = Color.Black;
            btn_May.Appearance.ForeColor = Color.Black;
            btn_June.Appearance.ForeColor = Color.Black;
            btn_July.Appearance.ForeColor = Color.Black;
            btn_August.Appearance.ForeColor = Color.Black;
            btn_September.Appearance.ForeColor = Color.Black;
            btn_October.Appearance.ForeColor = Color.Red;
            btn_November.Appearance.ForeColor = Color.Black;
            btn_December.Appearance.ForeColor = Color.Black;
        }

        private void btn_November_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            monthly = "November";
            Properties.Settings.Default.Report_monthly = monthly;
            Refresh_grid_control();
            btn_January.Appearance.ForeColor = Color.Black;
            btn_February.Appearance.ForeColor = Color.Black;
            btn_March.Appearance.ForeColor = Color.Black;
            btn_April.Appearance.ForeColor = Color.Black;
            btn_May.Appearance.ForeColor = Color.Black;
            btn_June.Appearance.ForeColor = Color.Black;
            btn_July.Appearance.ForeColor = Color.Black;
            btn_August.Appearance.ForeColor = Color.Black;
            btn_September.Appearance.ForeColor = Color.Black;
            btn_October.Appearance.ForeColor = Color.Black;
            btn_November.Appearance.ForeColor = Color.Red;
            btn_December.Appearance.ForeColor = Color.Black;
        }

        private void btn_December_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            monthly = "December";
            Properties.Settings.Default.Report_monthly = monthly;
            Refresh_grid_control();
            btn_January.Appearance.ForeColor = Color.Black;
            btn_February.Appearance.ForeColor = Color.Black;
            btn_March.Appearance.ForeColor = Color.Black;
            btn_April.Appearance.ForeColor = Color.Black;
            btn_May.Appearance.ForeColor = Color.Black;
            btn_June.Appearance.ForeColor = Color.Black;
            btn_July.Appearance.ForeColor = Color.Black;
            btn_August.Appearance.ForeColor = Color.Black;
            btn_September.Appearance.ForeColor = Color.Black;
            btn_October.Appearance.ForeColor = Color.Black;
            btn_November.Appearance.ForeColor = Color.Black;
            btn_December.Appearance.ForeColor = Color.Red;
        }

        private void btn_Salary_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            DB = new DB_MercyEntities();
            gridControl1.DataSource = DB.TB_Monthly_Report.Where(x => x.Monthly == monthly && x.Annual == annual && x.Type == "Salary").ToList();
        }

        private void btn_Expansess_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            DB = new DB_MercyEntities();
            gridControl1.DataSource = DB.TB_Monthly_Report.Where(x => x.Monthly == monthly && x.Annual == annual && x.Type == "Expansess").ToList();
        }

        private void btn_Credit_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            DB = new DB_MercyEntities();
            gridControl1.DataSource = DB.TB_Monthly_Report.Where(x => x.Monthly == monthly && x.Annual == annual && x.Type == "Credit").ToList();
        }

        private void gridView1_RowStyle(object sender, RowStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.RowHandle >= 0)
            {
                string Descripation = view.GetRowCellDisplayText(e.RowHandle, view.Columns["Postion"]);
                if (Descripation == "Deposit")
                {
                    e.Appearance.BackColor = Color.SkyBlue;
                    e.Appearance.BackColor2 = Color.SeaGreen;
                }
                if (Descripation.Contains("Carryover from"))
                {
                    e.Appearance.BackColor = Color.SkyBlue;
                    e.Appearance.BackColor2 = Color.SeaGreen;
                }

            }
        }

        private void gridView1_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.Column.FieldName == "Name")
            {
                string paid = view.GetRowCellDisplayText(e.RowHandle, view.Columns["Caught"]);
                if (paid == "False")
                {
                    e.Appearance.BackColor = Color.DeepSkyBlue;
                    e.Appearance.BackColor2 = Color.LightCyan;
                }
            }
        }
    }
}

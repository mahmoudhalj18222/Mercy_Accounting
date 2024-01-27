using DevExpress.XtraEditors;
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

namespace Mercy_Accounting.Form
{
    public partial class Add_Payroll_Report : DevExpress.XtraEditors.XtraForm
    {
        DB_MercyEntities db = new DB_MercyEntities();
        TB_Monthly_Report report;
        TB_Salary[] pay;
        public Add_Payroll_Report()
        {
            InitializeComponent();
           
        }

        string month;
        private string retAfterMonth(string mo)
        {
            if (mo == "February")
            {
                return "January";
            }
            else if (mo == "March")
            {
                return "February";
            }
            else if (mo == "April")
            {
                return "March";
            }
            else if (mo == "May")
            {
                return "April";
            }
            else if (mo == "June")
            {
                return "May";
            }
            else if (mo == "July")
            {
                return "June";
            }
            else if (mo == "August")
            {
                return "July";
            }
            else if (mo == "September")
            {
                return "August";
            }
            else if (mo == "October")
            {
                return "September";
            }
            else if (mo == "November")
            {
                return "October";
            }
            else if (mo == "December")
            {
                return "November";
            }
            else if (mo == "December")
            {
                return "December";
            }
            else
            {
                return "-1";
            }
        }
        private void Add_Payroll_Report_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
            month = retAfterMonth(Properties.Settings.Default.Report_monthly);
            db = new DB_MercyEntities();
            List<string> a = new List<string>();
            string[] pay = db.TB_Salary.Where(x=>x.For_manth == month).Select(x => x.Payroll).ToArray();
            int lengt = pay.Length;
            for (int i = 0; i < lengt; i++)
            {
                if (!a.Contains(pay[i]))
                {
                    a.Add(pay[i]);

                }
            }
            ComPay.Items.AddRange(a.ToArray());
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (ComPay.Text != "")
            {
                
                gridControl1.DataSource = db.TB_Salary.Where(x => x.For_manth == month && x.Payroll == ComPay.Text).ToList();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (gridView1.DataSource != null)
            {
                db = new DB_MercyEntities();
                
                pay = db.TB_Salary.Where(x => x.For_manth == month && x.Payroll == ComPay.Text).ToArray();
                int sn = Convert.ToInt32(txt_sn.Value);
                int qb = Convert.ToInt32(txt_qb.Value);
                foreach (TB_Salary p in pay)
                {
                    
                    report = new TB_Monthly_Report();
                    report.ID_Salary = p.ID;
                    report.SN = "SN" + sn;
                    report.QB = "A" + qb;
                    report.Date = dateTimePicker1.Value;
                    report.Name = p.Name;
                    report.Debit = p.Net_Deu;
                    report.Postion = p.Position;
                    report.Project = p.Project;
                    report.Caught = "False";
                    report.Type = "Salary";
                    report.Zoho = p.Zoho;
                    report.Payroll = p.Payroll;
                    report.Monthly = Properties.Settings.Default.Report_monthly;
                    report.Annual = Properties.Settings.Default.Report_annual;
                    db.TB_Monthly_Report.Add(report);
                    db.SaveChanges();
                    sn += 1;
                    qb += 1;

                }
            }
        }

        private void ComPay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComPay.Text != "")
            {

                gridControl1.DataSource = db.TB_Salary.Where(x => x.For_manth == month && x.Payroll == ComPay.Text).ToList();
            }
        }
    }
}
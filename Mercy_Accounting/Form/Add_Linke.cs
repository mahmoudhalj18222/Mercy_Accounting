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
    public partial class Add_Linke : DevExpress.XtraEditors.XtraForm
    {
        public int id;
        public Add_Linke()
        {
            InitializeComponent();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri(textEdit1.EditValue.ToString());
        }

        private void btn_Add_Report_Click(object sender, EventArgs e)
        {
            DB_MercyEntities db = new DB_MercyEntities();
            TB_Monthly_Report rep = new TB_Monthly_Report();
            rep = db.TB_Monthly_Report.Where(x => x.ID == id).FirstOrDefault();
            if (rep != null)
            {
                try
                {
                    rep.ID = id;
                    rep.ID_Credit = rep.ID_Credit;
                    rep.ID_Expansess = rep.ID_Expansess;
                    rep.ID_Salary = rep.ID_Salary;
                    rep.SN = rep.SN;
                    rep.QB = rep.QB;
                    rep.Date = rep.Date;
                    rep.Name = rep.Name;
                    rep.Debit = rep.Debit;
                    rep.Credit = rep.Credit;
                    rep.Postion = rep.Postion;
                    rep.Project = rep.Project;
                    rep.Caught = rep.Caught;
                    rep.Type = rep.Type;
                    rep.Zoho = rep.Zoho;
                    rep.Payroll = rep.Payroll;
                    rep.Monthly = rep.Monthly;
                    rep.Annual = rep.Annual;
                    rep.Link = textEdit1.EditValue.ToString();
                    rep.Note = rep.Note;
                    db.Entry(rep).State = EntityState.Modified;
                    db.SaveChanges();
                    Close();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }
}
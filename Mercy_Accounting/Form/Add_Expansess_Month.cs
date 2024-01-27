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
    public partial class Add_Expansess_Month : DevExpress.XtraEditors.XtraForm
    {
        DB_MercyEntities db;
        TB_Expensse _Expensse;
        TB_Monthly_Report _Report;
        int id;
        public int QB;
        public int SN;
        public Add_Expansess_Month()
        {
            InitializeComponent();
        }



        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            db = new DB_MercyEntities();
            id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
            _Expensse = db.TB_Expensse.Where(x => x.ID == id).FirstOrDefault();
            txt_Id.Text = _Expensse.ID.ToString();
            txt_Date.Value = Convert.ToDateTime(_Expensse.date);
            txt_name.Text = _Expensse.Name;
            txt_Amount.Text = _Expensse.Amount.ToString();
            txt_position.Text = _Expensse.Position;
            txt_project.Text = _Expensse.Project;
            txt_yaer.Text = Convert.ToDateTime(_Expensse.date).Year.ToString();
            txt_About.Text = _Expensse.Abut_Month;
            txt_Note.Text = _Expensse.detatils;



        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            
            if (txt_Id.Text != "")
            {
                db = new DB_MercyEntities();
                _Report = new TB_Monthly_Report();
                _Report.ID_Expansess = Convert.ToInt32(txt_Id.Text);
                _Report.SN = "MP" + txt_sn.Value.ToString();
                _Report.QB = "A" + txt_qb.Value.ToString();
                _Report.Date = txt_Date.Value;
                _Report.Name = txt_name.Text;
                _Report.Debit = Convert.ToDouble(txt_Amount.Text);
                _Report.Postion = txt_position.Text;
                _Report.Project = txt_project.Text;
                _Report.Type = "Expansess";
                _Report.Monthly = txt_About.Text;
                _Report.Annual = txt_yaer.Text;
                _Report.Note = txt_Note.Text;
                if (chec_paid.Checked)
                {
                    _Report.Caught = "True";
                }
                else
                {
                    _Report.Caught = "False";
                }
                db.TB_Monthly_Report.Add(_Report);
                db.SaveChanges();
                Close();

            }
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            db = new DB_MercyEntities();
            gridControl1.DataSource = db.TB_Expensse.ToList();
        }
    }
}
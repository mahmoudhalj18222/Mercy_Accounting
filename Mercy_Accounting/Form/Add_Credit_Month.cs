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
    public partial class Add_Credit_Month : DevExpress.XtraEditors.XtraForm
    {
        DB_MercyEntities db;
        TB_Credit _Credit;
        TB_Monthly_Report _Report;
        int id;
        public Add_Credit_Month()
        {
            InitializeComponent();

      
        }



        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            db = new DB_MercyEntities();
            id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
            _Credit = db.TB_Credit.Where(x => x.ID == id).FirstOrDefault();
            txt_Id.Text = id.ToString();
            if (_Credit.Date != null)
            {
                txt_Date.Value = Convert.ToDateTime(_Credit.Date);
            }
            txt_name.Text = _Credit.Name;
            txt_Amount.Text = _Credit.Amount.ToString();
            txt_About.Text = _Credit.Abut_Month;
            txt_Note.Text = _Credit.Note;
            txt_yaer.Text = Properties.Settings.Default.Report_annual;
            txt_source.Text = _Credit.Source;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            
            if (txt_Id.Text != "")
            {
                db = new DB_MercyEntities();
                _Report = new TB_Monthly_Report();
                _Report.Annual = txt_yaer.Text;
                _Report.ID_Credit = Convert.ToInt32(txt_Id.Text);
                _Report.Monthly = txt_About.Text;
                _Report.Type = "Credit";
                if (txt_source.Text == "PTT")
                {
                    _Report.Postion = "Deposit";
                    _Report.Date = txt_Date.Value;
                }
                else
                {
                    _Report.Postion = _Credit.Name;
                }
                
                _Report.Credit = Convert.ToDouble(txt_Amount.Text);
                db.TB_Monthly_Report.Add(_Report);
                db.SaveChanges();
                Close();

            }
        }
    }
}
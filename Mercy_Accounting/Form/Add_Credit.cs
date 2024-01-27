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
    public partial class Add_Credit : DevExpress.XtraEditors.XtraForm
    {

        DB_MercyEntities db;
        TB_Credit _Credit;
        public int id;

        public Add_Credit()
        {
            InitializeComponent();
        }

        private void btnAddEdit_Click(object sender, EventArgs e)
        {
            db = new DB_MercyEntities();
            
            if (txt_name.Text == "")
            {
                MessageBox.Show("Cells the name empty", "waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {

                    if (id == 0)
                    {
                        if (radioButton1.Checked)
                        {
                            _Credit = new TB_Credit();
                            _Credit.Source = "PTT";
                            _Credit.Name = txt_name.Text;
                            _Credit.Note = txt_note.Text;
                            _Credit.Date = date.Value;
                            _Credit.Amount = Convert.ToDouble(txt_amount.Text);
                            _Credit.Abut_Month = txt_Abut.Text;
                            db.TB_Credit.Add(_Credit);
                            db.SaveChanges();
                            this.Close();
                        }
                        else
                        {
                            _Credit = new TB_Credit();
                            _Credit.Source = "From Month";
                            _Credit.Name = txt_name.Text;
                            _Credit.Note = txt_note.Text;
                            _Credit.Abut_Month = txt_Abut.Text;
                            _Credit.Amount = Convert.ToDouble(txt_amount.Text);
                            db.TB_Credit.Add(_Credit);
                            db.SaveChanges();
                            this.Close();
                        }

                    }
                    else
                    {
                        if (radioButton1.Checked)
                        {
                            _Credit = new TB_Credit();
                            _Credit.Source = "PTT";
                            _Credit.Name = txt_name.Text;
                            _Credit.Note = txt_note.Text;
                            _Credit.Abut_Month = txt_Abut.Text;
                            _Credit.Date = date.Value;
                            _Credit.Amount = Convert.ToDouble(txt_amount.Text);
                            _Credit.ID = id;
                            db.Entry(_Credit).State = EntityState.Modified;
                            db.SaveChanges();
                            this.Close();
                        }
                        else
                        {
                            _Credit = new TB_Credit();
                            _Credit.Source = "From Month";
                            _Credit.Name = txt_name.Text;
                            _Credit.Note = txt_note.Text;
                            _Credit.Abut_Month = txt_Abut.Text;
                            _Credit.Amount = Convert.ToDouble(txt_amount.Text);
                            _Credit.ID = id;
                            db.Entry(_Credit).State = EntityState.Modified;
                            db.SaveChanges();
                            this.Close();
                        }

                    }
                }
                catch 
                {

                    MessageBox.Show("Error in connication Data base", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Add_Credit_Load(object sender, EventArgs e)
        {
            check();
        }

        private void check()
        {
            if (radioButton1.Checked)
            {
                date.Visible = true;
            }
            else
            {
                date.Visible = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            check();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            check();
        }


    }
}
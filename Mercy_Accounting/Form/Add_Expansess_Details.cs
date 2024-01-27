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
    public partial class Add_Expansess_Details : DevExpress.XtraEditors.XtraForm
    {
        //init
        DB_MercyEntities db;
        TB_Expensse _Expensse;
        Class.Method ma = new Class.Method();
        public int id;
        public int number_invoice;
        Tb_expansess Details;

        public Add_Expansess_Details()
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
                        Details = new Tb_expansess();
                        pictureEdit1.Image.Save(ma.ma, System.Drawing.Imaging.ImageFormat.Jpeg);
                        Details.Image = ma.convert_byte();
                        Details.Name = txt_name.Text;
                        Details.Amount = Convert.ToDouble(txt_amount.Text);
                        Details.Id_expanses = number_invoice;
                        db.Tb_expansess.Add(Details);
                        db.SaveChanges();
                        this.Close();
                    }
                    else
                    {
                        Details = new Tb_expansess();
                        pictureEdit1.Image.Save(ma.ma, System.Drawing.Imaging.ImageFormat.Jpeg);
                        Details.Image = ma.convert_byte();
                        Details.Name = txt_name.Text;
                        Details.Amount = Convert.ToDouble(txt_amount.Text);
                        Details.Id_expanses = number_invoice;
                        Details.ID = id;
                        db.Entry(Details).State = EntityState.Modified;
                        db.SaveChanges();
                        Close();
                      
                    }
                }
                catch
                {

                    MessageBox.Show("Error in connication Data base", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


    }
}
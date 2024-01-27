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
using Mercy_Accounting.Class;

namespace Mercy_Accounting.Form
{
    public partial class Add_Categreis : DevExpress.XtraEditors.XtraForm
    {

        DB_MercyEntities db;
        Categoire cat;
        public int id;
        Method ma = new Method();

        public Add_Categreis()
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
                        cat = db.Categoires.Where(x => x.Cat_Name == txt_name.Text).FirstOrDefault();
                        if (cat != null)
                        {
                            MessageBox.Show("Data cannot duplicate", "Duplicate data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            cat = new Categoire();
                            cat.Cat_Name = txt_name.Text;
                            cat.Cat_Des = Txt_Des.Text;
                            pictureEdit1.Image.Save(ma.ma, System.Drawing.Imaging.ImageFormat.Jpeg);
                            cat.Image = ma.convert_byte();
                            db.Categoires.Add(cat);
                            db.SaveChanges();
                            toastNotificationsManager1.GetNotificationByID("d2ad8e2f-47f2-411e-bdce-42e8ed15b37a");
                            this.Close();
                        }
                    }
                    else 
                    {
                        cat = new Categoire();
                        cat.Cat_Name = txt_name.Text;
                        cat.Cat_Des = Txt_Des.Text;
                        pictureEdit1.Image.Save(ma.ma, System.Drawing.Imaging.ImageFormat.Jpeg);
                        cat.Image = ma.convert_byte();
                        cat.ID = id;
                        db.Entry(cat).State = EntityState.Modified;
                        db.SaveChanges();
                        toastNotificationsManager1.GetNotificationByID("8c2e9da1-921e-4455-bc2b-40e66dfc3c94");
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
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
    public partial class Add_Project : DevExpress.XtraEditors.XtraForm
    {

        DB_MercyEntities db;
        TB_Project _Project;
        public int id;

        public Add_Project()
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
                        _Project = db.TB_Project.Where(x => x.Pro_Name == txt_name.Text).FirstOrDefault();
                        if (_Project != null)
                        {
                            MessageBox.Show("Data cannot duplicate", "Duplicate data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            _Project = new TB_Project();
                            _Project.Pro_Name = txt_name.Text;
                            _Project.Pro_Des = Txt_Des.Text;
                            _Project.Pro_Date_Start = start_date.Value;
                            _Project.Pro_Date_End = end_date.Value;
                            _Project.Pro_URL = txt_url.Text;
                            db.TB_Project.Add(_Project);
                            db.SaveChanges();
                            toastNotificationsManager1.GetNotificationByID("d2ad8e2f-47f2-411e-bdce-42e8ed15b37a");
                            this.Close();
                        }
                    }
                    else 
                    {
                        _Project = new TB_Project();
                        _Project.Pro_Name = txt_name.Text;
                        _Project.Pro_Des = Txt_Des.Text;
                        _Project.Pro_Date_Start = start_date.Value;
                        _Project.Pro_Date_End = end_date.Value;
                        _Project.Pro_URL = txt_url.Text;
                        _Project.ID = id;
                        db.Entry(_Project).State = EntityState.Modified;
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
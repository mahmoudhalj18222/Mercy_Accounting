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
    public partial class Add_Employee : DevExpress.XtraEditors.XtraForm
    {

        DB_MercyEntities db;
        TB_Employee _Employee;
        Categoire categoire;
        public int id;

        public Add_Employee()
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
                        _Employee = db.TB_Employee.Where(x => x.Emp_Name == txt_name.Text).FirstOrDefault();
                        if (_Employee != null)
                        {
                            MessageBox.Show("Data cannot duplicate", "Duplicate data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            _Employee = new TB_Employee();
                            categoire = new Categoire();
                            _Employee.Emp_Name = txt_name.Text;
                            _Employee.Emp_Email = txt_email.Text;
                            _Employee.Emp_Phone = txt_phone.Text;
                            _Employee.Emp_State = txt_state.Text;
                            _Employee.Emp_Name_Ar = txt_name_ar.Text;
                            _Employee.Emp_Zoho = Convert.ToInt32(txt_zoho.Value);
                            categoire = db.Categoires.Where(x => x.Cat_Name == combo_category.Text).FirstOrDefault();
                            _Employee.ID_cat = Convert.ToInt32(categoire.ID);
                            db.TB_Employee.Add(_Employee);
                            db.SaveChanges();
                            toastNotificationsManager1.GetNotificationByID("d2ad8e2f-47f2-411e-bdce-42e8ed15b37a");
                            this.Close();
                        }
                    }
                    else 
                    {
                        _Employee = new TB_Employee();
                        categoire = new Categoire();
                        _Employee.Emp_Name = txt_name.Text;
                        _Employee.Emp_Email = txt_email.Text;
                        _Employee.Emp_Phone = txt_phone.Text;
                        _Employee.Emp_State = txt_state.Text;
                        _Employee.Emp_Name_Ar = txt_name_ar.Text;
                        _Employee.Emp_Zoho = Convert.ToInt32(txt_zoho.Value);
                        categoire = db.Categoires.Where(x => x.Cat_Name == combo_category.Text).FirstOrDefault();
                        _Employee.ID_cat = Convert.ToInt32(categoire.ID);
                        _Employee.ID = id;
                        db.Entry(_Employee).State = EntityState.Modified;
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

        private void Add_Employee_Load(object sender, EventArgs e)
        {
            db = new DB_MercyEntities();
            combo_category.DataSource = db.Categoires.Select(x => x.Cat_Name).ToList();
            txt_name_ar.Focus();
        }
    }
}
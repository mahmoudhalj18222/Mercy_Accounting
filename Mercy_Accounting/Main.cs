using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Mercy_Accounting.Form;
using Mercy_Accounting.Form_2;
using Mercy_Accounting.Class;
using System.Data.Entity;
using DevExpress.XtraGrid.Views.Grid;
using System.IO;
using System.Threading.Tasks;
using DevExpress.XtraRichEdit.Design.Internal;

namespace Mercy_Accounting
{
    public partial class Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        DB_MercyEntities db;
        Method method = new Method();
        Category Category = new Category();
        Form.Supplier supplier = new Form.Supplier();
        Project project = new Project();
        Employee employee = new Employee();
        Credit credit = new Credit();
        Salary salary = new Salary();
        Expansess expansess = new Expansess();
        Report_monthly report_Monthly = new Report_monthly();
        Export_Excel _Excel = new Export_Excel();
        Users users = new Users();
        Payment_Request Payment_Request = new Payment_Request();


        //add
        Add_Categreis add_Category;
        Add_Suppliers add_Suppliers;
        Add_Project add_project;
        Add_Employee Add_Employee;
        Add_Credit add_Credit;
        Add_Salary add_Salary;
        Add_Payroll add_Payroll;
        Add_Expansess add_Expansess;
        Add_Expansess_Details add_Expansess_Details;
        Add_Expansess_Month add_Expansess_Month;
        Add_Credit_Month add_Credit_Month;
        Add_Linke add_linke;
        Add_Payroll_Report add_Payroll_Report;
        AShow_link show_link;
        Show_pdf show_pdf;

        // table
        Categoire cat;
        Supplier sup;
        TB_Project pro;
        TB_Employee emp;
        TB_Credit cre;
        TB_Salary sal;
        TB_Expensse exp;
        Tb_expansess details;
        TB_Monthly_Report rep;
        TB_Employee_Details emp_det;


        bool state;


        public Main()
        {
            InitializeComponent();
        }

        private bool Delete_Cat(Categoire Data)
        {
            try
            {
                db = new DB_MercyEntities();
                db.Entry(Data).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
                state = true;

            }
            catch { state = false; }
            return state;
        }

        private bool Delete_Sup(Mercy_Accounting.Supplier Data)
        {
            try
            {
                db = new DB_MercyEntities();
                db.Entry(Data).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
                state = true;

            }
            catch { state = false; }
            return state;
        }
        public void Refrech_category()
        {
            db = new DB_MercyEntities();
            Category.gridControl1.DataSource = db.Categoires.ToList();
        }

        public void Refrech_supplier()
        {
            db = new DB_MercyEntities();
            supplier.gridControl1.DataSource = db.Suppliers.ToList();
        }

        public void Refrech_project()
        {
            db = new DB_MercyEntities();
            project.gridControl1.DataSource = db.TB_Project.ToList();
        }

        public void Refrech_employee()
        {
            db = new DB_MercyEntities();
            employee.gridControl1.DataSource = db.TB_Employee.ToList();
        }

        public void Refrech_credit()
        {
            db = new DB_MercyEntities();
            credit.gridControl1.DataSource = db.TB_Credit.ToList();
        }

        public void Refrech_salary()
        {
            db = new DB_MercyEntities();
            salary.gridControl1.DataSource = db.TB_Salary.ToList();
        }

        public void Refrech_Report_Monthly()
        {
            db = new DB_MercyEntities();
            report_Monthly.gridControl1.DataSource = db.TB_Monthly_Report.Where(x => x.Monthly == Properties.Settings.Default.Report_monthly && x.Annual == Properties.Settings.Default.Report_annual).ToList();
        }

        public void Refrech_Expansess()
        {
            expansess.view_expansessTableAdapter.Fill(expansess.view.View_expansess);
            expansess.view_DetalisTableAdapter1.Fill(expansess.view.View_Detalis);
        }

        public void Refrech_Users()
        {
            db = new DB_MercyEntities();
            users.gridControl1.DataSource= db.TB_Users.ToList();
        }
        private void btn_category_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Category.Dock = DockStyle.Fill;
            panel_control.Controls.Clear();
            panel_control.Controls.Add(Category);
            Text = "Category";
            ribbon_logistic.Text = "Category";
            btn_print_logistic.Enabled = false;
        }

        private void btn_catgory_Add_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Text == "Category")
            {
                add_Category = new Add_Categreis();
                add_Category.Text = "Add";
                add_Category.id = 0;
                add_Category.ShowDialog();
            }

            if (Text == "Supplier")
            {
                add_Suppliers = new Add_Suppliers();
                add_Suppliers.Text = "Add";
                add_Suppliers.id = 0;
                add_Suppliers.ShowDialog();
            }
        }

        private void btn_catgory_refresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Text == "Category")
            {
                Refrech_category();

            }
            if (Text == "Supplier")
            {
                Refrech_supplier();
            }
        }

        private async void btn_delete_catgory_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Text == "Category")
            {
                try
                {
                    int id = 0;
                    id = Convert.ToInt32(Category.tileView1.GetFocusedRowCellValue("ID"));
                    if (id == 0)
                    {
                        MessageBox.Show("There is no category to delete", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    else
                    {
                        var result = MessageBox.Show("Do you want to delete the category", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (result == DialogResult.OK)
                        {
                            cat = new Categoire
                            { ID = id };
                            var r = await Task.Run(() => Delete_Cat(cat));
                            
                            //toastNotificationsManager1.GetNotificationByID("81af3487-82e2-4c38-8020-2d20602a9292");
                            Refrech_category();
                        }
                    }
                }
                catch
                {

                    MessageBox.Show("Error in connication Data base", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            if (Text == "Supplier")
            {
                try
                {
                    int id = 0;
                    id = Convert.ToInt32(supplier.gridView1.GetFocusedRowCellValue("ID"));
                    if (id == 0)
                    {
                        MessageBox.Show("There is no Supplier to delete", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    else
                    {
                        var result = MessageBox.Show("Do you want to delete the Supplier", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (result == DialogResult.OK)
                        {
                            sup = new Supplier
                            {
                                ID = id,
                            };
                            var r = await Task.Run(() => Delete_Sup(sup));
                            Refrech_supplier();
                        }
                    }
                }
                catch
                {

                    MessageBox.Show("Error in connication Data base", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Edit_catgory_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Text == "Category")
            {
                db = new DB_MercyEntities();
                cat = new Categoire();
                add_Category = new Add_Categreis();
                int id = 0;
                id = Convert.ToInt32(Category.tileView1.GetFocusedRowCellValue("ID"));
                if (id != 0)
                {
                    try
                    {
                        add_Category.Text = "Edit";
                        add_Category.btnAddEdit.Text = "Edit";
                        cat = db.Categoires.Where(x => x.ID == id).FirstOrDefault();
                        method.by = cat.Image;
                        add_Category.pictureEdit1.Image = Image.FromStream(method.convert_image());
                        add_Category.id = id;
                        add_Category.Txt_Des.Text = cat.Cat_Des.ToString();
                        add_Category.txt_name.Text = cat.Cat_Name;
                        add_Category.ShowDialog();
                    }
                    catch (Exception)
                    {

                        throw;
                    }

                }
                else
                {
                    MessageBox.Show("There is no category to Update", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }

            }

            if (Text == "Supplier")
            {
                db = new DB_MercyEntities();
                sup = new Supplier();
                add_Suppliers = new Add_Suppliers();
                cat = new Categoire();
                int id = 0;
                id = Convert.ToInt32(supplier.gridView1.GetFocusedRowCellValue("ID"));
                if (id != 0)
                {
                    add_Suppliers.Text = "Edit";
                    add_Suppliers.btnAddEdit.Text = "Edit";
                    sup = db.Suppliers.Where(x => x.ID == id).FirstOrDefault();
                    cat = db.Categoires.Where(x => x.ID == sup.Categorie).FirstOrDefault();
                    add_Suppliers.id = id;
                    add_Suppliers.txt_name.Text = sup.Name;
                    add_Suppliers.txt_phone.Text = sup.Phone;
                    add_Suppliers.txt_email.Text = sup.Email;
                    add_Suppliers.txt_Address.Text = sup.Address;
                    add_Suppliers.txt_Detalies.Text = sup.Detalies;
                    add_Suppliers.cat_name = cat.Cat_Name;
                    add_Suppliers.txt_IBAN.Text = sup.IBAN;
                    add_Suppliers.txt_Musteri.Text = sup.ALICI_PTT_MUSTERI_NO;
                    add_Suppliers.txt_Hesap.Text = sup.ALICI_PTT_HESAP_NO;
                    add_Suppliers.ShowDialog();
                }
                else
                {
                    MessageBox.Show("There is no Supplier to Update", "Update", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        private void btn_supplier_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            supplier.Dock = DockStyle.Fill;
            panel_control.Controls.Clear();
            panel_control.Controls.Add(supplier);
            Text = "Supplier";
            ribbon_logistic.Text = "Supplier";
            btn_print_logistic.Enabled = true;
        }

        private void btn_print_logistic_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Text == "Supplier")
            {
                supplier.gridControl1.ShowPrintPreview();
            }
        }

        private void btn_project_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            project.Dock = DockStyle.Fill;
            panel_control.Controls.Clear();
            panel_control.Controls.Add(project);
            Text = "Project";
            ribbon_hr1.Text = "Project";
            ribbon_hr2.Enabled = false;
        }

        private void btn_Add_hr_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Text == "Project")
            {
                add_project = new Add_Project();
                add_project.Text = "Add";
                add_project.id = 0;
                add_project.ShowDialog();
            }

            if (Text == "Employee")
            {
                Add_Employee = new Add_Employee();
                Add_Employee.Text = "Add";
                Add_Employee.id = 0;
                Add_Employee.ShowDialog();
            }
        }

        private void btn_Refresh_hr_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Text == "Project")
            {
                Refrech_project();
            }

            if (Text == "Employee")
            {
                Refrech_employee();
            }
        }

        private void btn_Delete_hr_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Text == "Project")
            {
                try
                {
                    int id = 0;
                    db = new DB_MercyEntities();
                    pro = new TB_Project();
                    id = Convert.ToInt32(project.gridView1.GetFocusedRowCellValue("ID"));
                    if (id == 0)
                    {
                        MessageBox.Show("There is no project to delete", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    else
                    {
                        var result = MessageBox.Show("Do you want to delete the project", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (result == DialogResult.OK)
                        {
                            pro = db.TB_Project.Where(x => x.ID == id).FirstOrDefault();
                            db.Entry(pro).State = EntityState.Deleted;
                            db.SaveChanges();
                            //toastNotificationsManager1.GetNotificationByID("81af3487-82e2-4c38-8020-2d20602a9292");
                            Refrech_project();
                        }
                    }
                }
                catch
                {

                    MessageBox.Show("Error in connication Data base", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (Text == "Employee")
            {
                try
                {
                    int id = 0;
                    db = new DB_MercyEntities();
                    emp = new TB_Employee();
                    id = Convert.ToInt32(employee.gridView1.GetFocusedRowCellValue("ID"));
                    if (id == 0)
                    {
                        MessageBox.Show("There is no Employee to delete", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    else
                    {
                        var result = MessageBox.Show("Do you want to delete the Employee", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (result == DialogResult.OK)
                        {
                            emp = db.TB_Employee.Where(x => x.ID == id).FirstOrDefault();
                            db.Entry(emp).State = EntityState.Deleted;
                            db.SaveChanges();
                            //toastNotificationsManager1.GetNotificationByID("81af3487-82e2-4c38-8020-2d20602a9292");
                            Refrech_employee();
                        }
                    }
                }
                catch
                {

                    MessageBox.Show("Error in connication Data base", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Edit_hr_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Text == "Project")
            {
                db = new DB_MercyEntities();
                pro = new TB_Project();
                add_project = new Add_Project();
                int id = 0;
                id = Convert.ToInt32(project.gridView1.GetFocusedRowCellValue("ID"));
                if (id != 0)
                {
                    try
                    {
                        add_project.Text = "Edit";
                        add_project.btnAddEdit.Text = "Edit";
                        pro = db.TB_Project.Where(x => x.ID == id).FirstOrDefault();
                        add_project.id = id;
                        add_project.Txt_Des.Text = pro.Pro_Des;
                        add_project.txt_name.Text = pro.Pro_Name;
                        add_project.txt_url.Text = pro.Pro_URL;
                        add_project.start_date.Value = (DateTime)pro.Pro_Date_Start;
                        add_project.end_date.Value = (DateTime)pro.Pro_Date_End;
                        add_project.ShowDialog();
                    }
                    catch (Exception)
                    {

                        throw;
                    }


                }
                else
                {
                    MessageBox.Show("There is no Project to Update", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }

            if (Text == "Employee")
            {
                db = new DB_MercyEntities();
                emp = new TB_Employee();
                Add_Employee = new Add_Employee();
                cat = new Categoire();
                int id = 0;
                id = Convert.ToInt32(employee.gridView1.GetFocusedRowCellValue("ID"));
                if (id != 0)
                {
                    try
                    {
                        Add_Employee.Text = "Edit";
                        Add_Employee.btnAddEdit.Text = "Edit";
                        emp = db.TB_Employee.Where(x => x.ID == id).FirstOrDefault();
                        cat = db.Categoires.Where(x => x.ID == emp.ID_cat).FirstOrDefault();
                        Add_Employee.id = id;
                        Add_Employee.txt_name.Text = emp.Emp_Name;
                        Add_Employee.txt_email.Text = emp.Emp_Email;
                        Add_Employee.txt_phone.Text = emp.Emp_Phone;
                        Add_Employee.txt_state.Text = emp.Emp_State;
                        Add_Employee.txt_name_ar.Text = emp.Emp_Name_Ar;
                        Add_Employee.txt_zoho.Text = emp.Emp_Zoho.ToString();
                        Add_Employee.combo_category.Text = cat.Cat_Name;
                        Add_Employee.ShowDialog();
                    }
                    catch (Exception)
                    {

                        throw;
                    }


                }
                else
                {
                    MessageBox.Show("There is no Employee to Update", "Update", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        private void btn_Print_hr_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Text == "Project")
            {
                project.gridControl1.ShowPrintPreview();
            }

            if (Text == "Employee")
            {
                employee.gridControl1.ShowPrintPreview();
            }
        }

        private void btn_Employee_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            employee.Dock = DockStyle.Fill;
            panel_control.Controls.Clear();
            panel_control.Controls.Add(employee);
            Text = "Employee";
            ribbon_hr1.Text = "Employee";
            ribbon_hr2.Text = "Employee";
            ribbon_hr2.Enabled = true;
        }

        private void btn_Credit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            credit.Dock = DockStyle.Fill;
            panel_control.Controls.Clear();
            panel_control.Controls.Add(credit);
            Text = "Credit";
        }

        private void btn_Credit_add_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Text == "Credit")
            {
                add_Credit = new Add_Credit();
                add_Credit.Text = "Add";
                add_Credit.id = 0;
                add_Credit.ShowDialog();
            }
        }

        private void btn_Credit_edit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Text == "Credit")
            {
                db = new DB_MercyEntities();
                cre = new TB_Credit();
                add_Credit = new Add_Credit();
                int id = 0;
                id = Convert.ToInt32(credit.gridView1.GetFocusedRowCellValue("ID"));
                if (id != 0)
                {
                    try
                    {
                        add_Credit.Text = "Edit";
                        add_Credit.btnAddEdit.Text = "Edit";
                        cre = db.TB_Credit.Where(x => x.ID == id).FirstOrDefault();
                        add_Credit.id = id;
                        add_Credit.txt_note.Text = cre.Note;
                        add_Credit.txt_name.Text = cre.Name;
                        add_Credit.txt_Abut.Text = cre.Abut_Month;
                        add_Credit.txt_amount.Text = cre.Amount.ToString();
                        if (cre.Source == "PTT")
                        {
                            add_Credit.radioButton1.Checked = true;
                            add_Credit.date.Value = (DateTime)cre.Date;
                        }
                        else
                        {
                            add_Credit.radioButton2.Checked = true;
                        }
                        add_Credit.ShowDialog();
                    }
                    catch (Exception)
                    {

                        throw;
                    }

                }
                else
                {
                    MessageBox.Show("There is no Project to Update", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        private void btn_Credit_delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Text == "Credit")
            {
                try
                {
                    int id = 0;
                    db = new DB_MercyEntities();
                    cre = new TB_Credit();
                    id = Convert.ToInt32(credit.gridView1.GetFocusedRowCellValue("ID"));
                    if (id == 0)
                    {
                        MessageBox.Show("There is no Credit to delete", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    else
                    {
                        var result = MessageBox.Show("Do you want to delete the Credit", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (result == DialogResult.OK)
                        {
                            cre = db.TB_Credit.Where(x => x.ID == id).FirstOrDefault();
                            db.Entry(cre).State = EntityState.Deleted;
                            db.SaveChanges();
                            Refrech_credit();
                        }
                    }
                }
                catch
                {

                    MessageBox.Show("Error in connication Data base", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Refrech_delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Refrech_credit();
        }

        private void btn_Credit_Print_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            credit.gridControl1.ShowPrintPreview();
        }

        private void btn_Salary_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            salary.Dock = DockStyle.Fill;
            panel_control.Controls.Clear();
            panel_control.Controls.Add(salary);
            Text = "Salary";
            Ribbon_Debit.Text = "Salary";
            btn_AddPayroll.Enabled = true;
            ribbon_details_expansess.Enabled = false;
        }

        private void btn_Debit_Add_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Text == "Salary")
            {
                add_Salary = new Add_Salary();
                add_Salary.Text = "Add";
                add_Salary.id = 0;
                add_Salary.ShowDialog();
            }

            if (Text == "Expansess")
            {
                add_Expansess = new Add_Expansess();
                add_Expansess.id = 0;
                add_Expansess.Text = "Add";
                add_Expansess.ShowDialog();
            }
        }

        private void btn_Debit_Edit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Text == "Salary")
            {
                add_Salary = new Add_Salary();
                db = new DB_MercyEntities();
                sal = new TB_Salary();
                add_Salary.Text = "Edit";
                add_Salary.btnAddEdit.Text = "Edit";
                int id = Convert.ToInt32(salary.gridView1.GetFocusedRowCellValue("ID"));
                sal = db.TB_Salary.Where(x => x.ID == id).FirstOrDefault();
                if (sal != null)
                {
                    try
                    {
                        add_Salary.zoho = sal.Name;
                        add_Salary.txt_Pos.Text = sal.Position;
                        add_Salary.txt_project.Text = sal.Project;
                        add_Salary.txt_Gross.Text = sal.Gross.ToString();
                        add_Salary.txt_add.Text = sal.Other_additions.ToString();
                        add_Salary.txt_tran.Text = sal.Transportation.ToString();
                        add_Salary.txt_Dedu.Text = sal.Other_deduction.ToString();
                        add_Salary.txt_pay.Text = sal.Payroll;
                        add_Salary.txt_abut.Text = sal.For_manth;
                        add_Salary.txt_date.Value = Convert.ToDateTime(sal.Preparation_date);
                        add_Salary.id = id;
                        add_Salary.ShowDialog();
                    }
                    catch (Exception)
                    {

                        throw;
                    }

                }
                else
                {
                    MessageBox.Show("There is no Salary to Update", "Update", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }

            if (Text == "Expansess")
            {
                add_Expansess = new Add_Expansess();
                db = new DB_MercyEntities();
                exp = new TB_Expensse();
                add_Expansess.Text = "Edit";
                add_Expansess.btnAddEdit.Text = "Edit";
                int id = Convert.ToInt32(expansess.gridView1.GetFocusedRowCellValue("Number"));
                exp = db.TB_Expensse.Where(x => x.ID == id).FirstOrDefault();
                if (exp != null)
                {
                    try
                    {
                        add_Expansess.txt_name.Text = exp.Name;
                        add_Expansess.txt_Pos.Text = exp.Position;
                        add_Expansess.txt_project.Text = exp.Project;
                        add_Expansess.txt_amount.Text = exp.Amount.ToString();
                        add_Expansess.txt_Abut.Text = exp.Abut_Month;
                        add_Expansess.txt_date.Value = Convert.ToDateTime(exp.date);
                        add_Expansess.txt_type.Text = exp.Tybe;
                        add_Expansess.txt_note.Text = exp.detatils;
                        method.by = exp.Image;
                        add_Expansess.pictureEdit1.Image = Image.FromStream(method.convert_image());
                        add_Expansess.id = id;
                        add_Expansess.ShowDialog();
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }
        }

        private void btn_Debit_Delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Text == "Salary")
            {
                try
                {
                    int id = 0;
                    db = new DB_MercyEntities();
                    sal = new TB_Salary();
                    id = Convert.ToInt32(salary.gridView1.GetFocusedRowCellValue("ID"));
                    if (id == 0)
                    {
                        MessageBox.Show("There is no Salary to delete", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    else
                    {
                        var result = MessageBox.Show("Do you want to delete the Salary", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (result == DialogResult.OK)
                        {
                            sal = db.TB_Salary.Where(x => x.ID == id).FirstOrDefault();
                            db.Entry(sal).State = EntityState.Deleted;
                            db.SaveChanges();
                            Refrech_salary();
                        }
                    }
                }
                catch
                {

                    MessageBox.Show("Error in connication Data base", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (Text == "Expansess")
            {
                db = new DB_MercyEntities();
                exp = new TB_Expensse();
                int id = Convert.ToInt32(expansess.gridView1.GetFocusedRowCellValue("Number"));
                exp = db.TB_Expensse.Where(x => x.ID == id).FirstOrDefault();
                if (exp != null)
                {
                    var result = MessageBox.Show("Do you want to delete the Expnsess", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        try
                        {
                            exp = db.TB_Expensse.Where(x => x.ID == id).FirstOrDefault();
                            db.Entry(exp).State = EntityState.Deleted;
                            db.SaveChanges();

                        }
                        catch (Exception)
                        {

                            MessageBox.Show("ياريت تحذف التفاصيل بالأول");
                        }

                    }
                }
            }
        }

        private void btn_Debit_Refrech_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Text == "Salary")
            {
                Refrech_salary();
            }
            if (Text == "Expansess")
            {
                Refrech_Expansess();
            }
        }

        private void btn_Debit_print_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Text == "Salary")
            {
                salary.gridControl1.ShowPrintPreview();
            }
            if (Text == "Expansess")
            {
                expansess.gridControl1.ShowPrintPreview();
            }
        }

        private void btn_AddPayroll_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Text == "Salary")
            {
                add_Payroll = new Add_Payroll();
                add_Payroll.Show();
            }
        }

        private void btn_Expansess_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            expansess.Dock = DockStyle.Fill;
            panel_control.Controls.Clear();
            panel_control.Controls.Add(expansess);
            Text = "Expansess";
            Ribbon_Debit.Text = "Expansess";
            btn_AddPayroll.Enabled = false;
            ribbon_details_expansess.Enabled = true;
        }

        private void btn_Detailes_Add_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Text == "Expansess")
            {
                add_Expansess_Details = new Add_Expansess_Details();
                int detatlis_invo = Convert.ToInt32(expansess.gridView1.GetFocusedRowCellValue("Number"));
                add_Expansess_Details.number_invoice = detatlis_invo;
                add_Expansess_Details.id = 0;
                add_Expansess_Details.ShowDialog();
            }
        }

        private void btn_Detailes_Edit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Text == "Expansess")
            {
                db = new DB_MercyEntities();
                add_Expansess_Details = new Add_Expansess_Details();
                int i = expansess.gridView1.FocusedRowHandle;
                if (expansess.gridView1.GetMasterRowExpanded(i))
                {
                    details = new Tb_expansess();
                    GridView detailview = expansess.gridView1.GetDetailView(i, 0) as GridView;
                    int id = Convert.ToInt32(detailview.GetRowCellValue(detailview.FocusedRowHandle, "ID"));
                    details = db.Tb_expansess.Where(x => x.ID == id).FirstOrDefault();
                    if (details != null)
                    {
                        try
                        {
                            add_Expansess_Details.Text = "Edit";
                            add_Expansess_Details.btnAddEdit.Text = "Edit";
                            add_Expansess_Details.id = id;
                            add_Expansess_Details.number_invoice = Convert.ToInt32(details.Id_expanses);
                            add_Expansess_Details.txt_name.Text = details.Name;
                            add_Expansess_Details.txt_amount.Text = details.Amount.ToString();
                            method.by = details.Image;
                            if (details.Image != null)
                            {
                                add_Expansess_Details.pictureEdit1.Image = Image.FromStream(method.convert_image());
                            }
                            add_Expansess_Details.ShowDialog();
                        }
                        catch (Exception)
                        {

                            throw;
                        }
                    }
                }
            }
        }

        private void btn_Detailes_Delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            db = new DB_MercyEntities();
            int i = expansess.gridView1.FocusedRowHandle;
            if (expansess.gridView1.GetMasterRowExpanded(i))
            {
                details = new Tb_expansess();
                GridView detailview = expansess.gridView1.GetDetailView(i, 0) as GridView;
                int id = Convert.ToInt32(detailview.GetRowCellValue(detailview.FocusedRowHandle, "ID"));
                if (details != null)
                {
                    var result = MessageBox.Show("Do you want to delete the Details Expnsess", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        details = db.Tb_expansess.Where(x => x.ID == id).FirstOrDefault();
                        db.Entry(details).State = EntityState.Deleted;
                        db.SaveChanges();
                        expansess.view_DetalisTableAdapter1.Fill(expansess.view.View_Detalis);
                    }


                }
            }
        }

        private void btn_Report_monthly_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            report_Monthly.Dock = DockStyle.Fill;
            panel_control.Controls.Clear();
            panel_control.Controls.Add(report_Monthly);
            Text = "Report Monthly";
        }

        private void btn_Insert_Credit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Text == "Report Monthly")
            {
                try
                {
                    db = new DB_MercyEntities();
                    cre = new TB_Credit();
                    int Id_Max = Convert.ToInt32(db.TB_Monthly_Report.Where(x => x.Monthly == Properties.Settings.Default.Report_monthly).Select(x => x.ID_Credit).Max());
                    add_Credit_Month = new Add_Credit_Month();
                    add_Credit_Month.gridControl1.DataSource = db.TB_Credit.Where(x => x.Abut_Month == Properties.Settings.Default.Report_monthly && x.ID > Id_Max).ToList();
                    add_Credit_Month.Text = "Add Credit to Report";
                    add_Credit_Month.Show();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private void btn_insert_salary_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Text == "Report Monthly")
            {

            }
        }

        private void btn_Delete_Row_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Text == "Report Monthly")
            {
                db = new DB_MercyEntities();
                int id = Convert.ToInt32(report_Monthly.gridView1.GetFocusedRowCellValue("ID"));
                rep = db.TB_Monthly_Report.Where(x => x.ID == id).FirstOrDefault();
                if (rep != null)
                {
                    var result = MessageBox.Show("Do you want to delete the selection Row", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        try
                        {
                            db.Entry(rep).State = EntityState.Deleted;
                            db.SaveChanges();
                            Refrech_Report_Monthly();
                        }
                        catch (Exception)
                        {

                            throw;
                        }
                    }
                }
            }
        }

        private void btn_Insert_expansess_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Text == "Report Monthly")
            {
                try
                {
                    db = new DB_MercyEntities();
                    exp = new TB_Expensse();
                    int id_report = Convert.ToInt32(db.TB_Monthly_Report.Where(x => x.Type == "Expansess" || x.Type == "Salary").Select(x => x.ID).Max());
                    string sn = db.TB_Monthly_Report.Where(x => x.ID == id_report).Select(x => x.SN).FirstOrDefault();
                    string qb = db.TB_Monthly_Report.Where(x => x.ID == id_report).Select(x => x.QB).FirstOrDefault();
                    int Id_Max = Convert.ToInt32(db.TB_Monthly_Report.Where(x => x.Monthly == Properties.Settings.Default.Report_monthly).Select(x => x.ID_Expansess).Max());
                    add_Expansess_Month = new Add_Expansess_Month();
                    add_Expansess_Month.txt_sn.Value = Convert.ToInt32(sn.Substring(2)) + 1;
                    add_Expansess_Month.txt_qb.Value = Convert.ToInt32(qb.Substring(1)) + 1;
                    add_Expansess_Month.gridControl1.DataSource = db.TB_Expensse.Where(x => x.Abut_Month == Properties.Settings.Default.Report_monthly && x.ID > Id_Max).ToList();
                    add_Expansess_Month.Text = "Add Expansess to Report";
                    add_Expansess_Month.Show();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private void btn_refrech_report_monthly_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Text == "Report Monthly")
            {
                Refrech_Report_Monthly();
            }
        }

        private void btn_paid_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Text == "Report Monthly")
            {
                int id = 0;
                db = new DB_MercyEntities();
                rep = new TB_Monthly_Report();
                id = Convert.ToInt32(report_Monthly.gridView1.GetFocusedRowCellValue("ID"));
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
                        rep.Caught = "True";
                        rep.Type = rep.Type;
                        rep.Zoho = rep.Zoho;
                        rep.Payroll = rep.Payroll;
                        rep.Monthly = rep.Monthly;
                        rep.Annual = rep.Annual;
                        rep.Link = rep.Link;
                        rep.Note = rep.Note;
                        db.Entry(rep).State = EntityState.Modified;
                        db.SaveChanges();
                        Refrech_Report_Monthly();
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }
        }

        private void btn_not_paid_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Text == "Report Monthly")
            {
                int id = 0;
                db = new DB_MercyEntities();
                rep = new TB_Monthly_Report();
                id = Convert.ToInt32(report_Monthly.gridView1.GetFocusedRowCellValue("ID"));
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
                        rep.Caught = "False";
                        rep.Type = rep.Type;
                        rep.Zoho = rep.Zoho;
                        rep.Payroll = rep.Payroll;
                        rep.Monthly = rep.Monthly;
                        rep.Annual = rep.Annual;
                        rep.Link = rep.Link;
                        rep.Note = rep.Note;
                        db.Entry(rep).State = EntityState.Modified;
                        db.SaveChanges();
                        Refrech_Report_Monthly();
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }
        }

        private void btn_link_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Text == "Report Monthly")
            {
                int id = 0;
                db = new DB_MercyEntities();
                rep = new TB_Monthly_Report();
                id = Convert.ToInt32(report_Monthly.gridView1.GetFocusedRowCellValue("ID"));
                add_linke = new Add_Linke();
                add_linke.id = id;
                add_linke.btn_Add_Report.Enabled = true;
                add_linke.ShowDialog();

            }
        }

        private void btn_show_link_Report_monthly_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Text == "Report Monthly")
            {
                int id = 0;
                db = new DB_MercyEntities();
                rep = new TB_Monthly_Report();
                id = Convert.ToInt32(report_Monthly.gridView1.GetFocusedRowCellValue("ID"));
                rep = db.TB_Monthly_Report.Where(x => x.ID == id).FirstOrDefault();
                if (rep.Link != null && rep.Link != "")
                {
                    show_link = new AShow_link();
                    show_link.webBrowser1.Url = new Uri(rep.Link);
                    show_link.ShowDialog();
                }
            }
        }

        private void btn_Delete_link_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Text == "Report Monthly")
            {
                int id = 0;
                db = new DB_MercyEntities();
                rep = new TB_Monthly_Report();
                id = Convert.ToInt32(report_Monthly.gridView1.GetFocusedRowCellValue("ID"));
                rep = db.TB_Monthly_Report.Where(x => x.ID == id).FirstOrDefault();
                if (rep != null)
                {
                    try
                    {
                        var result = MessageBox.Show("Do you went Delete link ", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (result == DialogResult.OK)
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
                            rep.Link = "";
                            rep.Note = rep.Note;
                            db.Entry(rep).State = EntityState.Modified;
                            db.SaveChanges();
                            Refrech_Report_Monthly();
                        }
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }
        }

        private void btn_Employee_Add_Signature_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Text == "Employee")
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    int id1 = 0;
                    db = new DB_MercyEntities();
                    string File_name = ofd.FileName;
                    id1 = Convert.ToInt32(employee.gridView1.GetFocusedRowCellValue("ID"));
                    emp_det = new TB_Employee_Details();
                    emp_det = db.TB_Employee_Details.Where(x => x.ID_Employee == id1).FirstOrDefault();
                    if (emp_det == null)
                    {
                        try
                        {
                            emp_det = new TB_Employee_Details();
                            emp_det.ID_Employee = id1;
                            emp_det.Signature = File.ReadAllBytes(ofd.FileName);
                            db.TB_Employee_Details.Add(emp_det);
                            db.SaveChanges();
                        }
                        catch (Exception)
                        {

                            throw;
                        }
                        
                    }
                    else
                    {
                        emp_det.ID_Employee = id1;
                        emp_det.Signature = File.ReadAllBytes(ofd.FileName);
                        emp_det.ID = emp_det.ID;
                        emp_det.Time_Sheet = emp_det.Time_Sheet;
                        emp_det.Contract = emp_det.Contract;
                        db.Entry(emp_det).State = EntityState.Modified;
                        db.SaveChanges();
                    }

                }
            }
        }

        private void btn_Employee_show_Signature_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Text == "Employee")
            {
                int id1 = 0;
                db = new DB_MercyEntities();
                id1 = Convert.ToInt32(employee.gridView1.GetFocusedRowCellValue("ID"));
                emp_det = new TB_Employee_Details();
                emp_det = db.TB_Employee_Details.Where(x => x.ID_Employee == id1).FirstOrDefault();
                if (emp_det != null)
                {
                    if (emp_det.Signature != null)
                    {
                        byte[] pdf = emp_det.Signature;
                        Stream stream = new MemoryStream(pdf);
                        show_pdf = new Show_pdf();
                        show_pdf.pdfViewer1.LoadDocument(stream);
                        show_pdf.ShowDialog();
                    }
                }
            }
        }

        private void btn_Eployee_AddTimeSheet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Text == "Employee")
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    int id1 = 0;
                    db = new DB_MercyEntities();
                    string File_name = ofd.FileName;
                    id1 = Convert.ToInt32(employee.gridView1.GetFocusedRowCellValue("ID"));
                    emp_det = new TB_Employee_Details();
                    emp_det = db.TB_Employee_Details.Where(x => x.ID_Employee == id1).FirstOrDefault();
                    if (emp_det == null)
                    {
                        try
                        {
                            emp_det = new TB_Employee_Details();
                            emp_det.ID_Employee = id1;
                            emp_det.Time_Sheet = File.ReadAllBytes(ofd.FileName);
                            db.TB_Employee_Details.Add(emp_det);
                            db.SaveChanges();
                        }
                        catch (Exception)
                        {

                            throw;
                        }

                    }
                    else
                    {
                        emp_det.ID_Employee = id1;
                        emp_det.Signature = emp_det.Signature;
                        emp_det.ID = emp_det.ID;
                        emp_det.Time_Sheet = File.ReadAllBytes(ofd.FileName);
                        emp_det.Contract = emp_det.Contract;
                        db.Entry(emp_det).State = EntityState.Modified;
                        db.SaveChanges();
                    }

                }
            }
        }

        private void Show_timeSheet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Text == "Employee")
            {
                int id1 = 0;
                db = new DB_MercyEntities();
                id1 = Convert.ToInt32(employee.gridView1.GetFocusedRowCellValue("ID"));
                emp_det = new TB_Employee_Details();
                emp_det = db.TB_Employee_Details.Where(x => x.ID_Employee == id1).FirstOrDefault();
                if (emp_det != null)
                {
                    if (emp_det.Time_Sheet != null)
                    {
                        byte[] pdf = emp_det.Time_Sheet;
                        Stream stream = new MemoryStream(pdf);
                        show_pdf = new Show_pdf();
                        show_pdf.pdfViewer1.LoadDocument(stream);
                        show_pdf.ShowDialog();
                    }
                }
            }
        }


        private void Show_Contract_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Text == "Employee")
            {
                int id1 = 0;
                db = new DB_MercyEntities();
                id1 = Convert.ToInt32(employee.gridView1.GetFocusedRowCellValue("ID"));
                emp_det = new TB_Employee_Details();
                emp_det = db.TB_Employee_Details.Where(x => x.ID_Employee == id1).FirstOrDefault();
                if (emp_det != null)
                {
                    if (emp_det.Contract != null)
                    {
                        byte[] pdf = emp_det.Contract;
                        Stream stream = new MemoryStream(pdf);
                        show_pdf = new Show_pdf();
                        show_pdf.pdfViewer1.LoadDocument(stream);
                        show_pdf.ShowDialog();
                    }
                }
            }
        }

        private void btn_Add_Contract_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Text == "Employee")
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    int id1 = 0;
                    db = new DB_MercyEntities();
                    string File_name = ofd.FileName;
                    id1 = Convert.ToInt32(employee.gridView1.GetFocusedRowCellValue("ID"));
                    emp_det = new TB_Employee_Details();
                    emp_det = db.TB_Employee_Details.Where(x => x.ID_Employee == id1).FirstOrDefault();
                    if (emp_det == null)
                    {
                        try
                        {
                            emp_det = new TB_Employee_Details();
                            emp_det.ID_Employee = id1;
                            emp_det.Contract = File.ReadAllBytes(ofd.FileName);
                            db.TB_Employee_Details.Add(emp_det);
                            db.SaveChanges();
                        }
                        catch (Exception)
                        {

                            throw;
                        }

                    }
                    else
                    {
                        emp_det.ID_Employee = id1;
                        emp_det.Signature = emp_det.Signature;
                        emp_det.ID = emp_det.ID;
                        emp_det.Time_Sheet = emp_det.Time_Sheet;
                        emp_det.Contract = File.ReadAllBytes(ofd.FileName);
                        db.Entry(emp_det).State = EntityState.Modified;
                        db.SaveChanges();
                    }

                }
            }
        }

        private void btn_insert_payroll_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Text == "Report Monthly")
            {
                add_Payroll_Report = new Add_Payroll_Report();
                db = new DB_MercyEntities();
                int id_report = Convert.ToInt32(db.TB_Monthly_Report.Where(x => x.Type == "Expansess" || x.Type == "Salary").Select(x => x.ID).Max());
                string sn = db.TB_Monthly_Report.Where(x => x.ID == id_report).Select(x => x.SN).FirstOrDefault();
                string qb = db.TB_Monthly_Report.Where(x => x.ID == id_report).Select(x => x.QB).FirstOrDefault();
                add_Payroll_Report.txt_sn.Value = Convert.ToInt32(sn.Substring(2)) + 1;
                add_Payroll_Report.txt_qb.Value = Convert.ToInt32(qb.Substring(1)) + 1;
                add_Payroll_Report.ShowDialog();
            }

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _Excel.ShowDialog();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            users.Dock = DockStyle.Fill;
            panel_control.Controls.Clear();
            panel_control.Controls.Add(users);
            Text = "Users";
            ribbon_Users.Text = "Users";
        }

        private void btn_Users_Refresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Refrech_Users();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_Payment_Request_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Payment_Request.Dock = DockStyle.Fill;
            panel_control.Controls.Clear();
            panel_control.Controls.Add(Payment_Request);
            Text = "Payment Request";
            Ribbon_Payment_Request.Text = "Payment Request";
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btn_Print_Report_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(Text == "Report Monthly")
            {
                report_Monthly.gridControl1.ShowPrintPreview();
            }
        }
    }
}


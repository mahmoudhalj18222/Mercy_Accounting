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
    public partial class Add_Salary : DevExpress.XtraEditors.XtraForm
    {
        //init
        DB_MercyEntities db;
        TB_Employee _Employee;
        TB_Salary _Salary;


        //var
        Double Gross;
        Double Add;
        Double trans;
        Double dedu;
        Double net;
        public int id;
        public string zoho;
        public Add_Salary()
        {
            InitializeComponent();
        }

        private void Add_Salary_Load(object sender, EventArgs e)
        {
            if (id == 0)
            {
                db = new DB_MercyEntities();
                txt_name.DataSource = db.TB_Employee.Select(x => x.Emp_Name).ToList();
                txt_project.DataSource = db.TB_Project.Select(x => x.Pro_Name).ToList();
            }
            else
            {
                db = new DB_MercyEntities();
                txt_name.DataSource = db.TB_Employee.Select(x => x.Emp_Name).ToList();
                txt_project.DataSource = db.TB_Project.Select(x => x.Pro_Name).ToList();
                txt_name.Text = zoho;
            }
        }

        private void txt_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            db = new DB_MercyEntities();
            _Employee = new TB_Employee();
            _Employee = db.TB_Employee.Where(x => x.Emp_Name == txt_name.Text).FirstOrDefault();
            txt_zoho.Value = Convert.ToInt32(_Employee.Emp_Zoho);
        }

        private void txt_zoho_ValueChanged(object sender, EventArgs e)
        {
            db = new DB_MercyEntities();
            _Employee = new TB_Employee();
            _Employee = db.TB_Employee.Where(x => x.Emp_Zoho == txt_zoho.Value).FirstOrDefault();
            if (_Employee != null)
            {
                txt_name.SelectedItem = _Employee.Emp_Name;
            }
        }

        private void calc_salary()
        {
            try
            {
                Gross = Convert.ToDouble(txt_Gross.Text);
                Add = Convert.ToDouble(txt_add.Text);
                dedu = Convert.ToDouble(txt_Dedu.Text);
                trans = Convert.ToDouble(txt_tran.Text);
                net = Gross + Add + trans - dedu;
                txt_net.Text = net.ToString();
            }
            catch { }
        }

        private void txt_Dedu_TextChanged(object sender, EventArgs e)
        {
            calc_salary();
        }

        private void txt_Gross_TextAlignChanged(object sender, EventArgs e)
        {
            calc_salary();
        }

        private void txt_add_TextChanged(object sender, EventArgs e)
        {
            calc_salary();
        }

        private void txt_Gross_TextChanged(object sender, EventArgs e)
        {
            calc_salary();
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
                        _Salary = new TB_Salary();
                        _Salary.Zoho = Convert.ToInt32(txt_zoho.Value);
                        _Salary.Name = txt_name.Text;
                        _Salary.Position = txt_Pos.Text;
                        _Salary.Gross = Convert.ToDouble(txt_Gross.Text);
                        _Salary.Other_additions = Convert.ToDouble(txt_add.Text);
                        _Salary.Transportation = Convert.ToDouble(txt_tran.Text);
                        _Salary.Other_deduction = Convert.ToDouble(txt_Dedu.Text);
                        _Salary.Net_Deu = Convert.ToDouble(txt_net.Text);
                        _Salary.Project = txt_project.Text;
                        _Salary.Payroll = txt_pay.Text;
                        _Salary.For_manth = txt_abut.Text;
                        _Salary.Preparation_date = txt_date.Value;
                        db.TB_Salary.Add(_Salary);
                        db.SaveChanges();
                        txt_Dedu.Text = "0";
                        txt_tran.Text = "0";
                    }
                    else
                    {
                        _Salary = new TB_Salary();
                        _Salary.Zoho = Convert.ToInt32(txt_zoho.Value);
                        _Salary.Name = txt_name.Text;
                        _Salary.Position = txt_Pos.Text;
                        _Salary.Gross = Convert.ToDouble(txt_Gross.Text);
                        _Salary.Other_additions = Convert.ToDouble(txt_add.Text);
                        _Salary.Transportation = Convert.ToDouble(txt_tran.Text);
                        _Salary.Other_deduction = Convert.ToDouble(txt_Dedu.Text);
                        _Salary.Net_Deu = Convert.ToDouble(txt_net.Text);
                        _Salary.Project = txt_project.Text;
                        _Salary.Payroll = txt_pay.Text;
                        _Salary.For_manth = txt_abut.Text;
                        _Salary.Preparation_date = txt_date.Value;
                        _Salary.ID = id;
                        db.Entry(_Salary).State = EntityState.Modified;
                        db.SaveChanges();
                        Close();
                        txt_Dedu.Text = "0";
                        txt_tran.Text = "0";
                    }
                }
                catch
                {

                    MessageBox.Show("Error in connication Data base", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            txt_name.SelectedIndex = 0;
            txt_project.SelectedIndex = 0;
            txt_Gross.Text = "0";
            txt_Pos.SelectedIndex = 0;
            txt_tran.Text = "0";
            txt_Dedu.Text = "0";
            txt_pay.Text = "";
            txt_abut.Text = "";
        }

        private void txt_tran_TextChanged(object sender, EventArgs e)
        {
            calc_salary();
        }
    }
}
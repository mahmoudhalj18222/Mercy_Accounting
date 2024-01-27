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
    public partial class Add_Payroll : DevExpress.XtraEditors.XtraForm
    {
        //init
        DB_MercyEntities db;
        TB_Employee _Employee;
        TB_Salary _Salary;
        TB_Salary [] tB_s;

        //var
        Double Gross;
        Double Add;
        Double dedu;
        Double tras;
        Double net;
        public int id;
        int tB_sLength;
        public Add_Payroll()
        {
            InitializeComponent();
        }

        private void Add_Salary_Load(object sender, EventArgs e)
        {
            db = new DB_MercyEntities();
            txt_project.DataSource = db.TB_Project.Select(x => x.Pro_Name).ToList();
            txt_name.DataSource = db.TB_Employee.Select(x => x.Emp_Name).ToList();
            List<string> a = new List<string>();
            string[] pay = db.TB_Salary.Select(x => x.Payroll).ToArray();
            int lengt = pay.Length;
            for (int i = 0; i < lengt; i++)
            {
                if (!a.Contains(pay[i]))
                {
                    a.Add(pay[i]);
                    
                }
            }
            ComPay.Items.AddRange(a.ToArray());

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
                tras = Convert.ToDouble(txt_trans);
                dedu = Convert.ToDouble(txt_Dedu.Text);
                net = Gross + Add + tras - dedu;
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
            txt_name.SelectedIndex = 0;
            txt_Gross.Text = "0";
            txt_add.Text = "0";
            txt_Dedu.Text = "0";
            txt_net.Text = "0";

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            txt_name.SelectedIndex = 0;
            txt_project.SelectedIndex = 0;
            txt_Gross.Text = "0";
            txt_abut.SelectedIndex = 0;
            txt_add.Text = "0";
            txt_Dedu.Text = "0";
            txt_pay.Text = "";

        }

        // Fatech Data
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (ComPay.Text != "")
            {

                tB_s = db.TB_Salary.Where(x => x.Payroll == ComPay.Text).ToArray();
                id = 0;
                data();
                btn_next.Enabled = true;
                tB_sLength = tB_s.Length;
                txt_project.Text = tB_s[id].Project;
                count.Text ="Count: " + db.TB_Salary.Where(x => x.Payroll == ComPay.Text).Select(x => x.Net_Deu).Count().ToString();
                Sum.Text ="Sum: "+ db.TB_Salary.Where(x => x.Payroll == ComPay.Text).Select(x => x.Net_Deu).Sum().ToString() + "$";
            }
            else
            {
                MessageBox.Show("Cell the Payroll - old empty", "waring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void data()
        {
            txt_zoho.Value = Convert.ToInt32(tB_s[id].Zoho);
            txt_name.Text = tB_s[id].Name;
            txt_Pos.Text = tB_s[id].Position;
            txt_Gross.Text = tB_s[id].Gross.ToString();
            txt_add.Text = tB_s[id].Other_additions.ToString();
            txt_trans.Text = tB_s[id].Transportation.ToString();
            txt_Dedu.Text = tB_s[id].Other_deduction.ToString();
            txt_net.Text = tB_s[id].Net_Deu.ToString();

        }
        private void checke()
        {
            if (id >= tB_sLength)
            {
                btn_next.Enabled = false;
                btn_back.Enabled = true;
            }
            else if (id <= -1)
            {
                btn_next.Enabled = true;
                btn_back.Enabled = false;
            }
            else
            {
                btn_next.Enabled = true;
                btn_back.Enabled = true;
            }
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            id += 1;
            if (id >= tB_sLength)
            {
                btn_next.Enabled = false;
            }
            else
            {
                
                data();
            }
            checke();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            id -= 1;
            if (id <= -1)
            {
                btn_back.Enabled = false;
            }
            else
            {

                data();
            }
            checke();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txt_pay.Text = textBox1.Text;
        }

        private void simpleButton4_Click(object sender, EventArgs e)
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

                    _Salary = new TB_Salary();
                    _Salary.Zoho = Convert.ToInt32(txt_zoho.Value);
                    _Salary.Name = txt_name.Text;
                    _Salary.Position = txt_abut.Text;
                    _Salary.Gross = Convert.ToDouble(txt_Gross.Text);
                    _Salary.Other_additions = Convert.ToDouble(txt_add.Text);
                    _Salary.Transportation = Convert.ToDouble(txt_trans.Text);
                    _Salary.Other_deduction = Convert.ToDouble(txt_Dedu.Text);
                    _Salary.Net_Deu = Convert.ToDouble(txt_net.Text);
                    _Salary.Project = txt_project.Text;
                    _Salary.Payroll = txt_pay.Text;
                    _Salary.For_manth = txt_abut.Text;
                    _Salary.Preparation_date = txt_date.Value;
                    db.TB_Salary.Add(_Salary);
                    db.SaveChanges();
                    txt_Dedu.Text = "0";
                    txt_add.Text = "0";


                }
                catch
                {

                    MessageBox.Show("Error in connication Data base", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txt_trans_TextChanged(object sender, EventArgs e)
        {
            calc_salary();
        }
    }
}
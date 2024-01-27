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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Mercy_Accounting.Form
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        DB_MercyEntities db = new DB_MercyEntities();
        TB_Users _User = new TB_Users();
        Main main = new Main();
        public Login()
        {
            InitializeComponent();
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("User Name is Empty");
            }
            else
            {
                _User = db.TB_Users.Where(x => x.UserName == textBox1.Text && x.Password == textBox2.Text).FirstOrDefault();
                if (_User != null)
                {
                    string role = _User.Role;
                    main.Enabled = true;
                    main.User_state.Caption = _User.FullName;
                    if (role == "Admin") 
                    {
                        main.Page_Report_Montly.Visible = true;
                        main.Page_Credit.Visible = true;
                        main.Page_Debit.Visible = true;
                        main.Page_HR.Visible = true;
                        main.Page_Logistic.Visible = true;
                        main.Page_settings.Visible = true;
                    }
                    if (role == "User")
                    {
                        main.Page_Report_Montly.Visible = true;
                        main.Page_Credit.Visible = false;
                        main.Page_Debit.Visible = false;
                        main.Page_HR.Visible = false;
                        main.Page_Logistic.Visible = false;
                        main.Page_settings.Visible = false;
                    }
                    main.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Faild login");
                }
            }
        }
    }
}
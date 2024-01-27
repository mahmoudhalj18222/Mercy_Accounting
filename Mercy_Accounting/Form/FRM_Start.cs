using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Mercy_Accounting.Form
{
    public partial class FRM_Start : SplashScreen
    {
        DB_MercyEntities db = new DB_MercyEntities();
        TB_Users _User = new TB_Users();
        Main main = new Main();
        Login _Login = new Login();
        public FRM_Start()
        {
            InitializeComponent();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
             _Login.Show();
            
            this.Hide();
            timer1.Enabled = false;
        }
    }
}
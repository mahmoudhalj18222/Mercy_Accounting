﻿using DevExpress.XtraEditors;
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
    public partial class Salary : DevExpress.XtraEditors.XtraUserControl
    {
        public Salary()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            // Instantiate a new DBContext
            Mercy_Accounting.DB_MercyEntities dbContext = new Mercy_Accounting.DB_MercyEntities();
            // Call the Load method to get the data for the given DbSet from the database.
            dbContext.TB_Salary.Load();
            // This line of code is generated by Data Source Configuration Wizard
            gridControl1.DataSource = dbContext.TB_Salary.Local.ToBindingList();
        }
    }
}

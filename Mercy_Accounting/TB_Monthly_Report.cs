//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mercy_Accounting
{
    using System;
    using System.Collections.Generic;
    
    public partial class TB_Monthly_Report
    {
        public int ID { get; set; }
        public Nullable<int> ID_Expansess { get; set; }
        public Nullable<int> ID_Salary { get; set; }
        public Nullable<int> ID_Credit { get; set; }
        public string SN { get; set; }
        public string QB { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string Name { get; set; }
        public Nullable<double> Debit { get; set; }
        public Nullable<double> Credit { get; set; }
        public string Postion { get; set; }
        public string Project { get; set; }
        public string Caught { get; set; }
        public string Type { get; set; }
        public Nullable<int> Zoho { get; set; }
        public string Payroll { get; set; }
        public string Monthly { get; set; }
        public string Annual { get; set; }
        public string Link { get; set; }
        public string Note { get; set; }
    
        public virtual TB_Credit TB_Credit { get; set; }
        public virtual TB_Expensse TB_Expensse { get; set; }
        public virtual TB_Salary TB_Salary { get; set; }
    }
}
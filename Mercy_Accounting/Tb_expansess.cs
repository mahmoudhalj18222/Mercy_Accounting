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
    
    public partial class Tb_expansess
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Nullable<int> Id_expanses { get; set; }
        public Nullable<double> Amount { get; set; }
        public byte[] Image { get; set; }
    
        public virtual TB_Expensse TB_Expensse { get; set; }
    }
}

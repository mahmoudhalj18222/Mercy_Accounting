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
    
    public partial class TB_Expensse
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_Expensse()
        {
            this.Tb_expansess = new HashSet<Tb_expansess>();
            this.TB_Monthly_Report = new HashSet<TB_Monthly_Report>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Project { get; set; }
        public Nullable<double> Amount { get; set; }
        public string Tybe { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public byte[] Image { get; set; }
        public string detatils { get; set; }
        public string Abut_Month { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tb_expansess> Tb_expansess { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_Monthly_Report> TB_Monthly_Report { get; set; }
    }
}

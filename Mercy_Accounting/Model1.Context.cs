﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DB_MercyEntities : DbContext
    {
        public DB_MercyEntities()
            : base("name=DB_MercyEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Categoire> Categoires { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TB_Credit> TB_Credit { get; set; }
        public virtual DbSet<Tb_expansess> Tb_expansess { get; set; }
        public virtual DbSet<TB_Expensse> TB_Expensse { get; set; }
        public virtual DbSet<TB_Project> TB_Project { get; set; }
        public virtual DbSet<TB_Salary> TB_Salary { get; set; }
        public virtual DbSet<TB_Monthly_Report> TB_Monthly_Report { get; set; }
        public virtual DbSet<TB_Employee_Details> TB_Employee_Details { get; set; }
        public virtual DbSet<TB_Employee> TB_Employee { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<TB_Users> TB_Users { get; set; }
        public virtual DbSet<TB_Payment_Request> TB_Payment_Request { get; set; }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.EF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BagAndBaggageTransportEntities : DbContext
    {
        public BagAndBaggageTransportEntities()
            : base("name=BagAndBaggageTransportEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<activitylog> activitylogs { get; set; }
        public DbSet<admin> admins { get; set; }
        public DbSet<customer> customers { get; set; }
        public DbSet<driver> drivers { get; set; }
        public DbSet<labour> labours { get; set; }
        public DbSet<labourwork> labourworks { get; set; }
        public DbSet<manager> managers { get; set; }
        public DbSet<review> reviews { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<tripe> tripes { get; set; }
        public DbSet<user> users { get; set; }
        public DbSet<token> tokens { get; set; }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DcdK22CNT4Lesson10Db.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DcdK22CNT4Lesson10DbEntities : DbContext
    {
        public DcdK22CNT4Lesson10DbEntities()
            : base("name=DcdK22CNT4Lesson10DbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DcdAccount> DcdAccount { get; set; }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SchoolManagement.Api.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class SMEntities : DbContext
    {
        public SMEntities()
            : base("name=SMEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Request_LST> Request_LST { get; set; }
        public virtual DbSet<Student_MST> Student_MST { get; set; }
        public virtual DbSet<Student_TRN> Student_TRN { get; set; }
    
        public virtual ObjectResult<string> GetNewRequestID()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("GetNewRequestID");
        }
    
        public virtual ObjectResult<string> GetNewStudentID()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("GetNewStudentID");
        }
    }
}
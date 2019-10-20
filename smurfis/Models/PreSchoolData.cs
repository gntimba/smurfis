using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace smurfis.Models
{
    public class PreSchoolData:DbContext
    {
        public PreSchoolData() : base("smurfies")
        {
        }
        public DbSet<Employee> employees;
        public DbSet<Child> children;
        public DbSet<Parent> parents;
        public DbSet<PreSchool> preSchools;
        public DbSet<Teacher> teachers;
        public DbSet<Secretary> secretaries;

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           
        }
    }
}
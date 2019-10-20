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
        public DbSet<Employee> employees { get; set; }
        public DbSet<Child> children { get; set; }
        public DbSet<Parent> parents { get; set; }
        public DbSet<PreSchool> preSchools { get; set; }
        public DbSet<Teacher> teachers { get; set; }
        public DbSet<Secretary> secretaries { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           
        }
    }
}
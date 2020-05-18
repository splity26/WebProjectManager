using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebProjectManager.Data
{
    public class ProjectManagerContext : DbContext
    {
        public ProjectManagerContext() : base("DefaultConnection")
        {
            //this.Configuration.LazyLoadingEnabled = false;
            //this.Configuration.ProxyCreationEnabled = false;

            //Database.SetInitializer(
            //    new MigrateDatabaseToLatestVersion<ProjectManagerContext, ProjectManagerMigrationConfiguration>()
            //    );
        }



        public DbSet<Users> Users { get; set; }
        public DbSet<Projects> Projects { get; set; }
        public DbSet<Allocations> Allocations { get; set; }
    }
}
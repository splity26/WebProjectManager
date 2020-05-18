using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace WebProjectManager.Data
{
    public class ProjectManagerMigrationConfiguration : DbMigrationsConfiguration<ProjectManagerContext>
    {
        public ProjectManagerMigrationConfiguration()
        {
            this.AutomaticMigrationDataLossAllowed = true;
            this.AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ProjectManagerContext context)
        {
            base.Seed(context);

            if(context.Users.Count() == 0)
            {
                //do stuff
            }
            if(context.Projects.Count() == 0)
            {
                //var proj = new Projects();
            }
            if(context.Allocations.Count() == 0)
            {

            }
        }


    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebProjectManager.Data
{
    public class ProjectManagerRepository : IProjectManagerRepository
    {
        ProjectManagerContext _ctx;

        public ProjectManagerRepository(ProjectManagerContext ctx)
        {
            _ctx = ctx;
        }

        public IQueryable<Allocations> GetAllocation()
        {

            return _ctx.Allocations;
        }

        public IQueryable<Projects> GetProjects()
        {
            return _ctx.Projects;
        }

        public IQueryable<Users> GetUsers()
        {
            return _ctx.Users;
        }
    }
}
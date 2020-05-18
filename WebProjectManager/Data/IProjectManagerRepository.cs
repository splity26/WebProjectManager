using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebProjectManager.Data
{
    public interface IProjectManagerRepository
    {
        IQueryable<Users> GetUsers();
        IQueryable<Projects> GetProjects();
        IQueryable<Allocations> GetAllocation();
    }
}

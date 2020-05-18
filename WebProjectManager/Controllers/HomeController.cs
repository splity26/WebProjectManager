using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebProjectManager.Data;

namespace WebProjectManager.Controllers
{
    public class HomeController : Controller
    {
        private IProjectManagerRepository _repo;

        public HomeController(IProjectManagerRepository repo)
        {
            _repo = repo;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Users()
        {
            ViewBag.Message = "Your application user page.";

            var users = _repo.GetUsers().ToList();

            return View(users);
        }

        public ActionResult Projects()
        {
            ViewBag.Message = "Your projects page.";

            var projects = _repo.GetProjects().ToList();

            return View(projects);
        }

        public ActionResult Allocations()
        {
            ViewBag.Message = "Your project allocation page.";

            var allocations = _repo.GetAllocation();

            var allocationsList = new List<AllocationDTO>();
            foreach (var allocation in allocations)
            {
                var users = _repo.GetUsers().Where(u => u.Id == allocation.UsersId).FirstOrDefault();
                var projects = _repo.GetProjects().Where(p => p.Id == allocation.ProjectsId).FirstOrDefault();

                //data transfer object
                allocationsList.Add(new AllocationDTO() { Username = users.Username, ProjectName = projects.ProjectName });
            }
      
            return View(allocationsList);
        }

        [ChildActionOnly]
        public PartialViewResult FilterByProjectName()
        {
            var allocations = _repo.GetAllocation();

            var allocationsList = new List<AllocationDTO>();
            foreach (var allocation in allocations)
            {
                var users = _repo.GetUsers().Where(u => u.Id == allocation.UsersId).FirstOrDefault();
                var projects = _repo.GetProjects().Where(p => p.Id == allocation.ProjectsId).FirstOrDefault();

                //data transfer object
                allocationsList.Add(new AllocationDTO() { Username = users.Username, ProjectName = projects.ProjectName });
            }

            // allocationsList.Where(s => s.ProjectName == TextBox.);
            // + refresh la pagina
            // vazut 


            return PartialView();
        }
    }
}

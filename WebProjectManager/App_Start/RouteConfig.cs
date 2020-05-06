using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebProjectManager
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "MyUsers",
                url: "Users",
                defaults: new { Controller = "Home", action = "Users" }
                );

            routes.MapRoute(
                name: "MyProjects",
                url: "Projects",
                defaults: new { Controller = "Home", action = "Projects" }
                );

            routes.MapRoute(
                name: "MyAllocations",
                url: "Allocations",
                defaults: new { Controller = "Home", action = "Allocations" }
                );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}

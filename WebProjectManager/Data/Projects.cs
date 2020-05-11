using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebProjectManager.Data
{
    public class Projects
    {
        public int Id { get; set; }

        public string ProjectName { get; set; }

        public string Details { get; set; }

        public DateTime ProjectStart { get; set; }

        public DateTime ProjectEnd { get; set; }

    }
}
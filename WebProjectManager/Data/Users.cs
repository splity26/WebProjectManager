using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebProjectManager.Data
{
    public class Users
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public DateTime EnrollDate { get; set; }

        public bool IsActive { get; set; }
    }
}
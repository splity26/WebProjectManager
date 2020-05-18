using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebProjectManager.Data
{
    public class Allocations
    {
        [Key]
        [Column(Order = 1)]
        public int UsersId { get; set; }
        [Key]
        [Column(Order = 2)]
        public int ProjectsId { get; set; }

        [ForeignKey("UsersId")]
        public Users Users { get; set; }

        [ForeignKey("ProjectsId")]
        public Projects Projects { get; set; }

    }
}
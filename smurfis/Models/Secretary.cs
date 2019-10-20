using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace smurfis.Models
{
    
    public class Secretary : BaseTable
    {
        [Key]
        [Required(ErrorMessage = "ID Secretary is required")]
        public Guid ID_Secretary { get; set; }
        public Guid? ID_Employee { get; set; }
    }

}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace smurfis.Models
{
  
    public class Teacher : BaseTable
    {
        [Key]
        [Required(ErrorMessage = "I D teacher is required")]
        public Guid ID_teacher { get; set; }
        public Guid? ID_Employee { get; set; }
    }
}
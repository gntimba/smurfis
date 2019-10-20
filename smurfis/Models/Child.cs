using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace smurfis.Models
{
   
    public class Child:BaseTable
    {
        [Key]
        [Required(ErrorMessage = "ID Child is required")]
        public Guid ID_Child { get; set; }
        [MaxLength(50)]
        public string cName { get; set; }
        [MaxLength(50)]
        public string cSurname { get; set; }
        [MaxLength(50)]
        public string cAddress { get; set; }
        [MaxLength(50)]
        public string cSpecialNeed { get; set; }
        public Guid? ID_parent { get; set; }
    }

}
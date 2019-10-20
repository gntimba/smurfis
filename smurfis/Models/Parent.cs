using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace smurfis.Models
{
   
    public class Parent : BaseTable
    {
        [Key]
        [Required(ErrorMessage = "I D parent is required")]
        public Guid ID_parent { get; set; }
        [MaxLength(50)]
        public string pName { get; set; }
        [MaxLength(50)]
        public string pSurname { get; set; }
        [MaxLength(50)]
        public string pAdresss { get; set; }
        [MaxLength(50)]
        public string pPhoneNumber { get; set; }
        public Guid? ID_Communication { get; set; }
        [MaxLength(50)]
        public String eMail { get; set; }
        [MaxLength(50)]
        public String password { get; set; }
    }

}
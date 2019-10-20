using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace smurfis.Models
{
    [Table("Employee")]
    public class Employee : BaseTable
    {
        [Key]
        [Required(ErrorMessage = "ID Employee is required")]
        public Guid ID_Employee { get; set; }
        [MaxLength(50)]
        public string eName { get; set; }
        [MaxLength(50)]
        public string eSurname { get; set; }
        [MaxLength(50)]
        public string eAddress { get; set; }
        [MaxLength(50)]
        public string eJobDescription { get; set; }
        [MaxLength(50)]
        public string eJobTitle { get; set; }
        [MaxLength(50)]
        public string ePhoneNumber { get; set; }
        [MaxLength(50)]
        public string email { get; set; }
        [MaxLength(50)]
        public string ePassword { get; set; }
        [MaxLength(16), Column(TypeName = "Binary")]
        public byte[] Salt { get; set; }
    }
}
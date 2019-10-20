using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace smurfis.Models
{
   
   
    public class PreSchool : BaseTable
    {
        public PreSchool()
        {
            this.ID_PresSchool = Guid.NewGuid();
        }

        [Key]
        [Required(ErrorMessage = "ID Pres School is required")]
        public Guid ID_PresSchool { get; set; }
        [MaxLength(50)]
        public string pAddress { get; set; }
        [MaxLength(50)]
        public string pOperationType { get; set; }
        [MaxLength(50)]
        public string pOperationNumber { get; set; }
    }

}
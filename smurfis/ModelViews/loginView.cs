using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace smurfis.ModelViews
{
    public class loginView
    {
        public String Email {get;set;}
        public String password { get; set; }

        public byte[] salt { get; set; }
        public Guid ID_employee { get; set; }
    }
}
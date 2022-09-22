using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace finalProject101.Models
{
    public class User
    {[Key]
        public int Uid { get; set; }
        public string Ufname { get; set; }
        public string Ulname { get; set; }
        public string Uemail { get; set; }
        public string Uusername { get; set; }
        public string Upassword { get; set; }
        public int flag { get; set; }
        public virtual ICollection<Vendor> Vendors { get; set; }
    }
}
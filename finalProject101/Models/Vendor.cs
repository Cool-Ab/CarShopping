using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace finalProject101.Models
{
    public class Vendor
    {
        [Key]
        public int Vid { get; set; }
        [ForeignKey("users")]
        public int Uid { get; set; }
        public virtual User users { get; set; }
        public string Vaddress { get; set; }
        public string Vshopname { get; set; }
        public string Vbanknumber { get; set; }


    }

}
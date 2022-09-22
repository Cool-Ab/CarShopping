using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace finalProject101.Models
{
    public class Product
    {
        [Key]
        public int Pid { get; set; }
        public string Pname { get; set; }
        public int Pyear { get; set; }
        public string Pmodel { get; set; }
        public string Pdescription { get; set; }
        public double Pprice { get; set; }
        public string Pimage { get; set; }
        public int PnoOfItem { get; set; }
        public int Prating { get; set; }
        public int Vid { get; set; }
        public virtual Vendor vendors { get; set; }

    }
}
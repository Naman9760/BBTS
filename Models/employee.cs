using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BBTS.Models
{
    public class employee
    {
        [Key]

        public int eid { get; set; }
        public string ename { get; set; }
        public string gender { get; set; }
        public string city { get; set; }
        public string salary { get; set; }
    }
}
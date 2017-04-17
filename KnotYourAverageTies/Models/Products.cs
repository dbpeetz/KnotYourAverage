using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KnotYourAverageTies.Models
{
    public class Products
    {
        [Key]
        public int UPC { get; set; }

        [Display(Name="Name")]
        public string Name { get; set; }
        public string Section { get; set; }
        public double Price { get; set; }
        public int Inventory { get; set; }



    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KnotYourAverageTies.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public int UPC { get; set; }

        [Display(Name="Name")]
        public string Name { get; set; }
        [Display(Name="Department")]
        public string Section { get; set; }
        public double Price { get; set; }
        public int Inventory { get; set; }

        public virtual Department Department { get; set; }

        public virtual ICollection<Purchase> Purchases { get; set; }
    }
}
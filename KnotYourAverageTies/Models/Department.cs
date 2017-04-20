using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KnotYourAverageTies.Models
{
    public class Department
    {
        [Display(Name="Department")]
        public int DepartmentID { get; set; }
        public string Name { get; set; }
        public double TotalSales { get; set; }

        public virtual ICollection<Product> Products { get; set; }


    }
}
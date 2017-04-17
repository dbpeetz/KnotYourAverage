using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KnotYourAverageTies.Models
{
    public class Department
    {

        public string Name { get; set; }

        public double TotalSales { get; set; }

        public virtual Products product { get; set; }
        public virtual Employees employee { get; set; }
    }
}
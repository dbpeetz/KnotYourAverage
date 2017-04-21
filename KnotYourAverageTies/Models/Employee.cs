using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KnotYourAverageTies.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime HireDate { get; set; }
        public string FullName
        {
            get { return LastName + ", " + FirstName; }
        }

        public virtual ICollection<Employee> Employees { get; set; }

    }
}
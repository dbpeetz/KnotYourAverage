using System.ComponentModel.DataAnnotations;

namespace KnotYourAverageTies.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual Department Department { get; set; }

    }
}
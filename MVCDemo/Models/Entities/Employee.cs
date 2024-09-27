using System.ComponentModel.DataAnnotations;

namespace MVCDemo.Models.Entities
{
    public class Employee
    {
        [Key]
        public string EmployeeID { get; set; }
        public string FullName { get; set; }
    }
}
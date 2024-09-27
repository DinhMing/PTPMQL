using System.ComponentModel.DataAnnotations;

namespace MVCDemo.Models.Entities
{
    public class Student
    {
        [Key]
        public string StudentID { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
    }

}
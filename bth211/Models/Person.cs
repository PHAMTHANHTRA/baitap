using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMVC.Models
{
    [Table("Employeecs")]
    // Phạm Thanh Trà _ 2021050646
    public class Employeecs
    {
        [Key]
        public string EmployeecsID { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
    }
}
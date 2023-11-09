using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMVC.Models
{
    [Table("Person")]
    // Phạm Thanh Trà _ 2021050646
    public class Person
    {
        [Key]
        public string PersonID { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
    }
}

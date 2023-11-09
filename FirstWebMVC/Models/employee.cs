using System.ComponentModel.DataAnnotations;
using Microsoft.JSInterop.Infrastructure;
//Phạm Thanh Trà _ 2021050646
namespace DemoMVC.Models
    public class Employee : Person
    {
        
       public string EmployeeID  { get; set; }
       public int Age  { get; set; }
       
    }

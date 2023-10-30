using System.ComponentModel.Design;
using System.Reflection.Metadata;
using System.Collections.Specialized;
using Microsoft.AspNetCore.Mvc;
using FirstWebMVC.Models;
using FirstWebMVC.Models;

namespace FirstWebMVC.Controllers
{
//Pham Thanh Tra - 2021050646
    public class EmployeeController : Controller
    {
         public IActionResult Index()
            {
                return View();
//Pham Thanh Tra - 2021050646
            }
            [HttpPost]
         public IActionResult Index(Employee emp)
            {
//Pham Thanh Tra - 2021050646
                string str = emp.FullName + "_" + emp.EmployeeID + "_" + emp.SoDienThoai +"_"+ emp.Address; 
                ViewBag.KetQua = str;
                return View();
//Pham Thanh Tra - 2021050646
            }
    }
}

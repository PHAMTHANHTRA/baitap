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

                int TinhLuong = (emp.LuongCB) *  (emp.HeSoLuong) +emp.PhuCap;
                string str1 = "FullName: " + " "+ emp.FullName + " " + "Luong: " + TinhLuong + "VND";
                ViewBag.KetQuaTinhLuong = str1;
                return View();
//Pham Thanh Tra - 2021050646
            }
    }
}
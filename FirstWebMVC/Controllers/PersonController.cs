using System.Reflection.Metadata.Ecma335;
using DemoMVC.Models;
using Microsoft.AspNetCore.Mvc;
namespace DemoMVC.Controllers
{ //Pham Thanh Tra - MSV : 2021050646
     public class PersonController : Controller
    {
         public IActionResult Index()
            {
                return View();
 //Pham Thanh Tra - MSV : 2021050646
            }
        [HttpPost]
        public IActionResult Index(Person prs)
        {
            string str = prs.PersonID +"_" + prs.FullName;
            ViewBag.thongBao = str;
            return View();
        }
 //Pham Thanh Tra - MSV : 2021050646       
    }
}
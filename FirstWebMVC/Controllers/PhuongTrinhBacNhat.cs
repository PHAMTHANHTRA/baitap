using Microsoft.AspNetCore.Mvc;
namespace FirstWebMVC.Controllers
{
    public class PhuongTrinhBacNhatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
//Pham Thanh Tra - 2021050646
//Giai phuong trinh bac nhat
        [HttpPost]
        public IActionResult Index(double a, double b)
        {
            if (a == 0)
            {
            if (b==0)
                {
                      ViewBag.ThongBao = "Phuong trinh co vo so nghiem";
                }else 
                {
                    ViewBag.ThongBao = "Phuong trinh vo nghiem";
                }
//Pham Thanh Tra - 2021050646
            }else
            {
                double nghiem = -b / a;
               ViewBag.ThongBao =  $"Nghiem cua phuong trinh la x = {nghiem}";
            } 

//Pham Thanh Tra - 2021050646
            return View();
        }
    }
}
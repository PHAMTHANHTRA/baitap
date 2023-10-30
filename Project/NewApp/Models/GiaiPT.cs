using System.IO;
using System.Text.RegularExpressions;
using System;
using NewApp.Models;
namespace NewApp.Models
{
    public class GiaiPT
    {   //Nghiem Thi Van Anh -2021050078

       public string PhuongTrinhBacHai(double a, double b, double c)
        {
            double denta = (b*b - 4*a*c);

            if ( denta < 0)
            {
                return "Phuong Trinh Vo Nghiem";
            }else if( denta == 0 )
            {
               double nghiemkep = -b / 2*a;
                return $"Phuong Trinh co nghiem kep {nghiemkep}";
            }else
            {
               double nghiem1 = (-b + Math.Sqrt(denta)) / 2*a;
               double nghiem2 = (-b - Math.Sqrt(denta)) / 2*a;

                return $"Phuong trinh co 2 nghiem: Nghiem 1 = {nghiem1}, Nghiem 2 = {nghiem2}";
            }
        }

    }
}

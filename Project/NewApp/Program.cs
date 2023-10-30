// Tao ra doi tuong thu 

using System.Runtime.Intrinsics.Arm;
using NewApp.Models;

//Pham Thanh Tra _ 2021050646

public class Program
{
    public static void Main(string[]args)
    {
    
     
    Student std = new Student();
    std.NhapThongTin();
    std.StudentCode = "12345678";
    std.HienThi();
    
    }
}

namespace NewApp.Models;

public class SinhVien
{

    public string HoTen { get; set; }
    public string  DiaChi { get; set; }
    public int  Tuoi { get; set; }
    public string SoDienThoai {get; set; }

    public void NhapThongTinSinhVien()
    {
        System.Console.Write("Nhap Ho Ten = ");
        HoTen = Console.ReadLine();
        System.Console.Write("Dia chi = ");
        DiaChi = Console.ReadLine();
        System.Console.Write("Tuoi = ");
        Tuoi = Convert.ToInt16(Console.ReadLine());
        System.Console.Write("So Dien Thoai = ");
        SoDienThoai = Console.ReadLine();
            
    }

    public void HienThiThongTinSinhVien()
    {
        System.Console.WriteLine("{0} - {1} - {2} - {3}", HoTen, DiaChi, Tuoi , SoDienThoai);
    }
}
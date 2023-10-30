namespace NewApp.Models
{
    public class juice : Fruit
    {
        //NGHIEM thi Van Anh -2021050078
        public string Size { get; set; }

        public void NhapThongTin()
        {
            base.NhapThongTin();
            System.Console.WriteLine("Size  =");
            Size = Console.ReadLine();  
        }

        public void HienThi()
        {
           base.HienThi();
           System.Console.WriteLine("Size = {0}", Size); 
        }

        }
    }


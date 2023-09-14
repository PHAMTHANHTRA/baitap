public class Program {

    private static void Main(string[] args)
    {

       int a = 1;
      float b = 2.1f;
      double c = 3;
      decimal d = 4m;
      bool e = true;
      bool f = false;
      char KyTu = 'a';
      string HoTen = "Pham Thanh Tra";
      Console.WriteLine("a = ", +a);


     //khai báo hằng số

      const int namLamViec = 9;
      const string HoTen = "Pham Thanh Tra";
      const float a = 0.3f;
      const double b = 4.5;
      const decimal d = 3m;
      const bool e = true;
      const char KyTu = 'v';
      Console.WriteLine("Nhanvien {0} + {1} nam kinh nghiem",HoTen,namLamViec);

     //Toán tử

     int a,b;
      System.Console.Write("a = ");
       a = Convert.ToInt32(Console.ReadLine());
      
      System.Console.Write("b = ");
       b = Convert.ToInt32(Console.ReadLine());
       
        System.Console.WriteLine("{0} + {1} = {2}",a,b,a+b);
        System.Console.WriteLine("{0} - {1} = {2}",a,b,a-b);
        System.Console.WriteLine("{0} / {1} = {2}",a,b,a/b);
        System.Console.WriteLine("{0} % {1} = {2}",a,b,a%b);




   // Toán tử so sánh
   
     int a,b;
      System.Console.Write("a = ");
       a = Convert.ToInt32(Console.ReadLine());
      
      System.Console.Write("b = ");
       b = Convert.ToInt32(Console.ReadLine());
        if(a<b){
            Console.WriteLine("{0} nho hon {1}", a,b);
          } else{
            Console.WriteLine("{0} lon hon {1}",a, b);
          }

      float a =1;
      if(a >=8.5){ dùng để kiểm tra các điều kiện
        System.Console.WriteLine("Hoc sinh dat loai gioi");
      } else if(a >=6.5){
        System.Console.WriteLine("Hoc sinh dat loai Kha");
      } else if(a>=5){
        System.Console.WriteLine("Hoc sinh loai Trung Binh");
      }else if(a>=3.5){
        System.Console.WriteLine("Hoc sinh loai Yeu");
      }else {
         System.Console.WriteLine("Hoc sinh loai Kem");
      }
     int day = 2;
    switch(day){ dùng để kiểm tra các giá trị case
      case 1 : System.Console.WriteLine("Chu nhat"); break;
      case 2 : System.Console.WriteLine("Thu 2"); break;
      case 3 : System.Console.WriteLine("Thu 3"); break;
      case 4 : System.Console.WriteLine("Thu 4"); break;
      case 5 : System.Console.WriteLine("Thu 5"); break;
      case 6 : System.Console.WriteLine("Thu 6"); break;
      case 7 : System.Console.WriteLine("Thu 7"); break;
      default :
        System.Console.WriteLine("Khong phai ngay trong tuan");
        break;
    }  

     for(int i = 0; i < 10; i++)
      {
        System.Console.WriteLine("Vòng lặp thứ {0}",i);
      }

     int a = 1;
    while(a < 10)
    {
      System.Console.WriteLine("Vòng lặp thứ {0}",a);
      a++;
    }

     int a = 2;
     do
    {
      System.Console.WriteLine("Vòng lặp thứ {0}",a);
      a++;// tăng a lên 1 đơn vị để đảm bảo có lúc a>= 10; a>=10 thì vòng lặp kết thúcthúc
    }while(a <10);*/

     for(int i = 0; i < 10; i++)
      {
        if(i ==5) break;
        System.Console.WriteLine("Vòng lặp thứ {0}",i);
    }

     for(int i = 0; i < 10; i++)
      {
        if(i ==5) continue;
        System.Console.WriteLine("Vòng lặp thứ {0}",i);
    } 
}
}
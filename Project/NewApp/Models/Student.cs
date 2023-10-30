using NewApp.Models;

namespace NewApp.Models
{

//Nghiem Thi Van Anh - MSV 2021050078
    public class Student 
    {
        public int StudentID {get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }

        public void EnterData()
        {
            System.Console.Write("Full Name = ");
            FullName = Console.ReadLine();
            System.Console.Write("Address = ");
            Address = Console.ReadLine();
            System.Console.Write("Student ID =");

            try{
                StudentID = Convert.ToInt32(Console.ReadLine()); 
            }catch(Exception e)
            {
                StudentID = 0;
            }
             
        }

        public void Display()
        {
           
           System.Console.WriteLine("Ma sinh vien: {0} - {1} - {2}", FullName, Address,StudentID); 
        }
    }
}
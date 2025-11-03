using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Enter User Name :  ");
            string uname = Console.ReadLine();

            Console.WriteLine("Enter User Age :  ");
            int age =  int.Parse( Console.ReadLine() );

            Console.WriteLine("Is Valid User (true/false) :  ");
            bool isValidUser = bool.Parse(Console.ReadLine());     
            

            Console.WriteLine("------  User Details ----------");
            Console.WriteLine("User Name  : " + uname);
            Console.WriteLine("User Age  : " + age);
            Console.WriteLine("Is Valid User : " + isValidUser);
          


            Console.ReadLine(); 
        }
    }
}

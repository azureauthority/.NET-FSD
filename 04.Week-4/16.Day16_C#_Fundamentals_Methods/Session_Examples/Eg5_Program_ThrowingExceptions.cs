using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp39
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter your age: ");
                int age = Convert.ToInt32(Console.ReadLine());

                if (age < 0 || age > 100)
                {
                    throw new Exception("Age should not be less than zero or greater than 100.");
                }

                Console.WriteLine("Your age is valid");

              
            } 
            catch (Exception ex)
            {
                Console.WriteLine($"Exception Message: {ex.Message}.");
                Console.WriteLine($"Stack Trace  :  {ex.StackTrace}");
            }
            




            Console.ReadLine();

        }
    }
}

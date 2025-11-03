using System; 

namespace ConsoleApp38
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            int[] marks = new int[5];

            Console.WriteLine("Enter marks of 5 subjects:");
            for (int i = 0; i < 5; i++)
            {
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }

            int total = 0;
            foreach (int mark in marks)
            {
                total += mark;
            }
            Console.WriteLine("Total Marks: " + total);
            Console.WriteLine("Average Marks: " + (total / 5));




            Console.ReadLine();   
        }


    }
}

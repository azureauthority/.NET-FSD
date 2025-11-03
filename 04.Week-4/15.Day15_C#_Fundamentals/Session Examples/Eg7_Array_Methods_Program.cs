using System; 

namespace ConsoleApp38
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            int[] arr3 = new int[] { 4, 80, 2, 15, 8, 90, 101 }; 
 
            // using foreach
            foreach (int item in arr3)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();

            Array.Sort(arr3);
            Array.Reverse(arr3);

            foreach (int item in arr3)
            {
                Console.Write($"{item} ");
            }




            Console.ReadLine();   
        }


    }
}

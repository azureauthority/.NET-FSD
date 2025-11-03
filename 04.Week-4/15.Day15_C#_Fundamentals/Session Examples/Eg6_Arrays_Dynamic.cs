using System; 

namespace ConsoleApp38
{
    internal class Program
    { 
        static void Main(string[] args)
        {  
            int[] arr3;

            Console.Write("Enter no. of items to store : ");
            int size = int.Parse(Console.ReadLine());

            // allocate size for array
            arr3 = new int[size];


            for (int i = 0; i < arr3.Length; i++)
            {
                Console.Write("Enter an item : ");
                arr3[i] = int.Parse(Console.ReadLine());
            }

          

            // using for
            for (int i = 0; i < arr3.Length; i++)
            { 
                Console.Write($"{arr3[i]} ");
            }

            Console.WriteLine();

            // using foreach
            foreach (int item in arr3)
            {
                Console.Write($"{item} ");
            }





            Console.ReadLine();   
        }


    }
}

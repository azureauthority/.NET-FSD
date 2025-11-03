using System; 

namespace ConsoleApp38
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number : ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine($"{n}  is even number");
            }
            else
            {
                Console.WriteLine($"{n}  is odd number");
            }
                            

            Console.ReadLine();
        }
    }
}

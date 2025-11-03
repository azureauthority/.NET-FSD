using System; 

namespace ConsoleApp38
{
    internal class Program
    {
        static void ShowEvenNumbers()
        {
            int i = 0;

            while(i <= 20)
            {
                Console.Write($"{i}  ");
                i = i + 2; //   i +=  2;
            }
        }

        static void ShowOddNumbers()
        {
            int i = 1;

            while (i <= 20)
            {
                Console.Write($"{i}  ");
                i = i + 2; //   i +=  2;
            }
        }

        static void ShowFiveMultiples()
        {
            for (int j = 1; j <= 10; j++)
            {
                Console.Write($"{j * 5} ");
            }
        }

        //    3  5  6  9   10   12  15  18  20  21  24  25  27  30
        static void ShowCustomNumbers()
        {
            for (int i = 1; i <= 30; i++)
            {
                if( i % 3 == 0 || i % 5 == 0 )
                {
                    Console.Write($"{i} ");
                }                
            }
        }

        static void Main(string[] args)
        {
            ShowEvenNumbers();
            Console.WriteLine();

            ShowOddNumbers();
            Console.WriteLine();

            ShowFiveMultiples();
            Console.WriteLine();

            ShowCustomNumbers();
             

            Console.ReadLine();   
        }


    }
}

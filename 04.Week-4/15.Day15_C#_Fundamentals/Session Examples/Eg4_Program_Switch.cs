using System; 

namespace ConsoleApp38
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter deptno : ");
            int deptno = Convert.ToInt32(Console.ReadLine());
            switch(deptno)
            {
                case 10:  Console.WriteLine("You have selected ACCOUNTS department.");
                           break;

                case 20: Console.WriteLine("You have selected SALES department.");
                            break;

                case 30: Console.WriteLine("You have selected MARKETING department.");
                            break;


                default: Console.WriteLine("Invalid deptno.");
                    break;
            }
            

            Console.ReadLine();
        }
    }
}



namespace ConsoleApp39
{
    internal class Program
    {
        static void Greeting()
        {
            Console.WriteLine("Welcome to C# Programming");
        }

        static void Greeting(string name)
        {
            Console.WriteLine($"Hi {name}, Welcome to C# Programming");
        }

        static void Greeting(string name, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Hi {name}, Welcome to C# Programming");
            }
        }

        static void Main(string[] args)
        {
          
            Greeting();
            Greeting();
            Console.WriteLine("-----------------------");

            Greeting("Narasimha");
            Greeting("Scott");
            Console.WriteLine("-------------------------");

            Greeting("Stephen", 3);
            

            Console.ReadLine();
        }
    }
}

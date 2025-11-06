namespace ConsoleApp39
{

    class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();

            Console.WriteLine("Enter person name :  ");
            p1.Name = Console.ReadLine();


            Console.WriteLine("Enter person age :  ");
            p1.Age = int.Parse( Console.ReadLine() );

            Console.WriteLine($"Hi {p1.Name}, Good morning...!");
            Console.WriteLine($"Name : {p1.Name}, Age : {p1.Age}");

            Console.ReadLine();
        }
    }
}

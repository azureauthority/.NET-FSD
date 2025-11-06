
namespace ConsoleApp39
{
    class Person
    {
        public virtual void Print()
        {
            Console.WriteLine("Person details from parent class.");
        }
    }
    class Employee : Person
    {
        public override void Print()
        {
            // base.Print();         // It invokes parent class print method
            Console.WriteLine("Employee details from child class");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Person p = new Person();
            p.Print();
            Console.WriteLine("-------------------------------");

            Employee e = new Employee();
            e.Print();
            
            Console.ReadLine();
        }
    }
}

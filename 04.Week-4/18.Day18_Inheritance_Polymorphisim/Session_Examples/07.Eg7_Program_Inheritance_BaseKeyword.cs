
namespace ConsoleApp39
{

    class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }  

        public Person(string name)
        {
            Console.WriteLine("Message from Parent Class");
            Name = name;
        }
    }


    class Employee : Person
    {
        public int EmployeeId { get; set; }
        public string Job { get; set; }

        public Employee(string name) : base(name)
        {
            Console.WriteLine("Message from Child Class");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Narasimha Rao");

            employee.EmployeeId = 6445454;         
            employee.Age = 32;
            employee.Job = "Manager";


            Console.WriteLine($" {employee.EmployeeId},  {employee.Name}, {employee.Job}, {employee.Age}");

            Console.ReadLine();
        }
    }
}

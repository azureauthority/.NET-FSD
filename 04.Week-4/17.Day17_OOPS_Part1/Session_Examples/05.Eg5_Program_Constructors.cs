using System.Xml.Linq;

namespace ConsoleApp39
{

    class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public Person()
        {
            Age = 0;
            Name = "";
        }

        public Person(int age)
        {
            Age = age;
        }

        public Person(string name)
        {
            Name = name;
        }

        public Person(string name, int  age)
        {
            Name = name;
            Age = age;
        }

        public Person(int age, string name)
        {
            Name = name;
            Age = age;
        }
         
        public void ShowDetails()
        {
            Console.WriteLine($"[Person Details] Name : {Name}, Age : {Age}");
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person(); 
            Person p2 = new Person(20); 
            Person p3 = new Person("Scott"); 
            Person p4 = new Person("Scott", 20); 
            Person p5 = new Person(20, "Scott");


            p1.ShowDetails();
            p2.ShowDetails();
            p3.ShowDetails();
            p4.ShowDetails();
            p5.ShowDetails(); 


            Console.ReadLine();
        }
    }
}

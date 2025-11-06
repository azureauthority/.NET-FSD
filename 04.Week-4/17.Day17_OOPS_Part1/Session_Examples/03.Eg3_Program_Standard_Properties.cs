using System;
using System.Collections.Generic;
using System.Linq;
 
namespace ConsoleApp39
{ 
    class Person
    {
        // data or state or fields 
        private int age;
        private string name; 
 
        //Standard Properties
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Name
        {
            get { return name; }
            set {  name = value; }
        }

        // functions or methods 
        public void ShowDetails()
        {
            Console.WriteLine($"[Person Details] Name : {name}, Age : {age}");
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        { 

            Person p1 = new Person();
            p1.Name = "Scott";
            p1.Age = 25;


            Person p2 = new Person();
            p2.Name = "Smith";
            p2.Age = 24;


            p1.ShowDetails();
            p2.ShowDetails();

            Console.ReadLine();
        }

    }
}
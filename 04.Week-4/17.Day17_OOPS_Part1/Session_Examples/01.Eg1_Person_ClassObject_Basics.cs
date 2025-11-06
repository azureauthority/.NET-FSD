using System;
using System.Collections.Generic;
using System.Linq;
 
namespace ConsoleApp39
{ 

    class Person
    {
        // data or state or fields 
        private int age = 25;
        private string name = "Scott";

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

            Person personObj = new Person();
            personObj.ShowDetails();
             

            Console.ReadLine();
        }

    }
}
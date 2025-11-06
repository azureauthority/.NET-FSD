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


        // getters and setters
        public int GetAge()
        {
            return age;
        }

        public void SetAge(int age)
        {
            this.age = age;
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

            Person personObj = new Person();

            Console.WriteLine($"Age : {personObj.GetAge()}");   // Get

            personObj.SetAge(26);       //  Set

            Console.WriteLine($"Age : {personObj.GetAge()}");   // Get
             

            Console.ReadLine();
        }

    }
}
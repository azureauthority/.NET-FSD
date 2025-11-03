using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp38
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            List<int> listObj = new List<int>() { 10, 20, 30 };
            listObj.Add(40);
            listObj.Add(50);

            foreach (int item in listObj)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            listObj.Remove(40);
            foreach (int item in listObj)
            {
                Console.Write($"{item} ");
            } 

            Console.ReadLine();   
        }


    }
}

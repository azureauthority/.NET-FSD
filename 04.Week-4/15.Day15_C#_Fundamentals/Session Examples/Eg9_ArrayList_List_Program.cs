using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp38
{
    internal class Program
    { 
        static void Main(string[] args)
        {

            object obj = 25;  // boxing
            int x = (int) obj;  // Unboxing
            Console.WriteLine(x);
           
            // -----------------------------
            ArrayList arList = new ArrayList();
            arList.Add(10);  // boxing 
            arList.Add(20);


            int y = (int) arList[1];
            Console.WriteLine(y);

            // -----------------------------------------

            List<int> listObj = new List<int>();
            listObj.Add(10);
            listObj.Add(20);
            listObj.Add(30);


            int z = listObj[2];
            Console.WriteLine(z);


            Console.ReadLine();   
        }


    }
}

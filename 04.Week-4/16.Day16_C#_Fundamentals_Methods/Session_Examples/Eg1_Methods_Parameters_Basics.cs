using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp38
{
    internal class Program
    { 
        // 1.  Call By Value
        static void Test1(int x)
        {
            x = x + 10;
        }

        // 2.  Call By Ref
        static void Test2(ref int x)
        {
            x = x + 10;
        }

        // 3.Out Parameters
        static  void  FindTotal(int x, int y, out int z)
        {
            z = x + y;
        }

        // 4. Default Parameters
        static int  GetTotalAmount(int price, int qty = 1)
        {
            return price * qty;
        }


        // 5. Unlimited Parameters
        static void Sum(params int[] x)
        {
            int s = 0;
            foreach (int item in x)
            {
                s += item;
            }
            Console.WriteLine($"Sum Result : {s}");
        }

        static void Main(string[] args)
        {
            int a = 10;

            Console.WriteLine($"Before : {a}");
            Test1(a);
            Console.WriteLine($"After : {a}");

            Console.WriteLine("---------------------------------");

            Console.WriteLine($"Before : {a}");
            Test2(ref a);
            Console.WriteLine($"After : {a}");

            Console.WriteLine("-----------------------------");
            //---------------------------
            int p = 10, q = 20, r;
            FindTotal(p, q, out r);
            Console.WriteLine($"Total Result : {r}");

            Console.WriteLine("--------------------------");

            Console.WriteLine("Total Amount :  " + GetTotalAmount(2500, 3));
            Console.WriteLine("Total Amount :  " + GetTotalAmount(1500));

            Console.WriteLine("--------------------------");
            Sum(10);
            Sum(10, 20);
            Sum(10, 20, 30);
            Sum(10, 20, 30, 40);

            Console.ReadLine();   
        }


    }
}

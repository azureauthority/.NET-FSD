using System;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder();

        Console.WriteLine("[Using StringBuilder]");

        Console.WriteLine("Start Time: {0}", DateTime.Now.ToString("T"));

        for (int i = 0; i < 100000; i++)
        {
            sb.Append(i);
        }

        Console.WriteLine("End Time: {0}", DateTime.Now.ToString("T"));

        Console.WriteLine();

        string str = "";
        Console.WriteLine("[Using String]");
        Console.WriteLine("Start Time: {0}", DateTime.Now.ToString("T"));

        for (int i = 0; i < 100000; i++)
        {
            str = str + i;
        }
        Console.WriteLine("End Time: {0}", DateTime.Now.ToString("T"));

        Console.WriteLine();
    }

}
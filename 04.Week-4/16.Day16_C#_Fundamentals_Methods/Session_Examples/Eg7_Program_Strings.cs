using System;

internal class Program
{
    private static void Main(string[] args)
    {
        string s1, s2;
        s1 = "Hello";
        s2 = " World";


        s1 = string.Concat(s1, s2);
        Console.WriteLine("Concate Result : {0}", s1);

        Console.WriteLine("Upper:  {0}", s1.ToUpper());		
        Console.WriteLine("Lower:  {0}", s1.ToLower());


       bool flag = s1.Contains("World");
       Console.WriteLine("Contains : {0}", flag);


        int n = s1.IndexOf("llo");
        Console.WriteLine("IndexOf : {0}", n);

        n = s1.LastIndexOf('l');
       Console.WriteLine("LastIndexOf : {0}", n);

        Console.WriteLine("Substring : {0}", s1.Substring(4));
        Console.WriteLine("Substring : {0}", s1.Substring(4, 3));

        Console.WriteLine();
        string s3 = "       ABC APP          ";       
	   Console.WriteLine("With spaces : {0}", s3.Length);
        s3 = s3.Trim();
        Console.WriteLine("After trim : {0}", s3.Length);

        Console.WriteLine();
        string s4 = "ASP.NET,VB.NET,C#.NET";
        string[] strArray =  s4.Split(',');
        foreach (string str in strArray)
        {
            Console.Write("  " + str);
        }
    }

}
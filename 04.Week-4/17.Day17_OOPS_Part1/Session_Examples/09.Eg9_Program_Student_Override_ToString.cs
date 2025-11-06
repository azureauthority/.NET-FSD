
namespace ConsoleApp39
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Course { get; set; }
        public string Email {  get; set; }


        public override string ToString()
        {
            return $"{Id}, {Name}, {Course}, {Email}";
        }

    }

    class Test
    {

    }

    internal class Program
    {
        static void Main(string[] args)
        {

            Test  t = new Test();
            Console.WriteLine(t.ToString() );
            Console.WriteLine("-----------------------------");

            Student student = new Student();

            student.Id = 1256;
            student.Name = "Scott";
            student.Course = "C#.NET";
            student.Email = "scott@gmail.com";


            Console.WriteLine(student);
            Console.WriteLine(student.ToString() );

            Console.WriteLine("-------------------------------");


            List<int> lstObj = new List<int>();
            Console.WriteLine(lstObj );
            Console.WriteLine(lstObj.ToString() );
            Console.WriteLine("------------------------------------------");

            String s1 = new string("Hello");
            Console.WriteLine(s1);
            Console.WriteLine(s1.ToString() );
 
            Console.ReadLine();
        }
    }
}

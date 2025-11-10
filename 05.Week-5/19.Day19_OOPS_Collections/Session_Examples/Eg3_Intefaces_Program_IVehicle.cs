

namespace ConsoleApp39
{

    interface IVehicle
    {
        void SpeedUp(int increment);
        void CheckSpeed();
        int Speed { get; set; } // Property
    }


    class Bicycle : IVehicle
    {
        public int Speed { get; set; }

        public void SpeedUp(int increment)
        {
            Speed += increment;
        }

        public void CheckSpeed()
        {
            Console.WriteLine($"Current speed: {Speed}");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            Bicycle b = new Bicycle();
            b.Speed = 100;
            b.CheckSpeed();

            b.SpeedUp(20);
            b.CheckSpeed();

            b.SpeedUp(20);
            b.CheckSpeed();

            Console.ReadLine();
        }
    }
}

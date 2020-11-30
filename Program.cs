using System;

namespace cars
{
    class Program
    {
        static void Main(string[] args)
        {
            Tesla tesla = new Tesla()
            {
                MainColor = "black"
            };
            Cessna cessna = new Cessna()
            {
                MainColor = "black"
            };
            Ram ram = new Ram()
            {
                MainColor = "black"
            };
            Zero zero = new Zero()
            {
                MainColor = "black"
            };

            tesla.Drive();
            tesla.Turn("right");
            tesla.Stop();
            cessna.Drive();
            cessna.Turn("left");
            cessna.Stop();
            ram.Drive();
            ram.Turn("right");
            ram.Stop();
            zero.Drive();
            zero.Turn("left");
            zero.Stop();
        }
    }
}

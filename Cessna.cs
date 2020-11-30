using System;

namespace cars {
    public class Cessna : Vehicle // Propellor light aircraft
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }
        public override void Drive()
        {
            Console.WriteLine($"The {this.MainColor} Cessna flashes by you.");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The {this.MainColor} Cessna turns {direction}.");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {this.MainColor} Cessna stops.");
        }
    }
}
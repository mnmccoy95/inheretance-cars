using System;

namespace cars {
    public class Ram : Vehicle // Gas powered truck
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }
        public override void Drive()
        {
            Console.WriteLine($"The {this.MainColor} Ram shakes by you.");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The {this.MainColor} Ram turns {direction}.");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {this.MainColor} Ram stops.");
        }
    }
}
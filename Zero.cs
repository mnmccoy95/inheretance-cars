using System;

namespace cars {
    public class Zero : Vehicle  // Electric motorcycle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
        }
        public override void Drive()
        {
            Console.WriteLine($"The {this.MainColor} Zero zooms by you.");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The {this.MainColor} Zero turns {direction}.");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {this.MainColor} Zero stops.");
        }
    }
}
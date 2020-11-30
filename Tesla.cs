using System;

namespace cars {
    public class Tesla : Vehicle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            // method definition omitted
        }
        public override void Drive()
        {
            Console.WriteLine($"The {this.MainColor} Tesla yeets by you.");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The {this.MainColor} Tesla turns {direction}.");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {this.MainColor} Tesla stops.");
        }
    }
}
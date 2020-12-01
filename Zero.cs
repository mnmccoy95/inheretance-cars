using System;

namespace cars {
    public class Zero : IElectricVehicle  // Electric motorcycle
    {
        public double BatteryKWh { get; } = 100;
        public double CurrentChargePercentage {get; set;}
    }
}
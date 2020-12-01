using System;

namespace cars {
    public class Tesla : IElectricVehicle
    {
        public double BatteryKWh { get; } = 100;
        public double CurrentChargePercentage {get; set;}
    }
}
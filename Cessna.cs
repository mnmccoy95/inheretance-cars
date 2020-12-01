using System;

namespace cars {
    public class Cessna : IGasVehicles // Propellor light aircraft
    {
        public double FuelCapacity { get; } = 100;

        public double CurrentTankPercentage {get; set;}
    }
}
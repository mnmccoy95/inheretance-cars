using System;

namespace cars {
    public class Ram : IGasVehicles // Gas powered truck
    {
        public double FuelCapacity { get; } = 100;

        public double CurrentTankPercentage {get; set;}
    }
}
using System;

namespace cars
{
    public interface IGasVehicles
    {
        void RefuelTank()
        {
            CurrentTankPercentage = 100;
        }
        double FuelCapacity { get; }
        double CurrentTankPercentage { get; set;}
    }
}
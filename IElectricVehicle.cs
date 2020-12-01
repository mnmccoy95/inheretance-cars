using System;

namespace cars
{
    public interface IElectricVehicle
    {
        void ChargeBattery()
        {
            CurrentChargePercentage = 100;
        }
        double BatteryKWh { get; }
        double CurrentChargePercentage {get; set;}
    }
}
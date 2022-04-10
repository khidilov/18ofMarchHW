using System;
using System.Collections.Generic;
using System.Text;

namespace _18ofMarch_MotoredVehicleHW.Models
{
    internal class Car : MotoredVehicle
    {
        public string GetDetailedInfo(int FuelAmount)
        {
            return $"Make: {Make};\nModel: {Model};\nYear of manufaction: {ProductionYear};\nMotor Size: {MotorSize};\nColor {Color};\nFuel Amount {FuelAmount}:";
        }
        public bool isON = false;
        public Car(string Make, string Model, string ProductionYear) : base(Make, Model, ProductionYear)
        {

        }

        public Car()
        {
        }

        public void TurnOn()
        {
            isON = true;
        }
        public void TurnOff()
        {
            isON = false;
        }
        public string Go(int Route, int FuelAmount, int FuelUsedPerKm)
        {
            if (isON == false) return "Maybe you should start the engine first";
            else
            {
                if (FuelAmount > Route * FuelUsedPerKm)
                {
                    return $"You have reached your destination.\nRemaining fuel amount is: {FuelAmount = FuelAmount - Route * FuelUsedPerKm}";
                }
                else
                {
                    return $"No money, no honey. But you still can go {FuelAmount / FuelUsedPerKm}";
                }
            }

        }
    }
}

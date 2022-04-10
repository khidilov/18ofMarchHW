using System;
using System.Collections.Generic;
using System.Text;

namespace _18ofMarch_MotoredVehicleHW.Models
{
    internal class MotoredVehicle
    {
        public string Make;
        public string Model;
        public string ProductionYear;
        public int MotorSize;
        public int FuelTankSize;
        public int FuelAmount;
        public int FuelUsedPerKm;
        public string Color;
        public string Transmission;
        public int HorsePower;
        public int PassangerCount;
        public MotoredVehicle()
        {

        }
        public MotoredVehicle(string Make, string Model, string ProductionYear)
        {
            this.Make = Make;
            this .Model = Model;
            this .ProductionYear = ProductionYear;
        }

        public string GetInfo()
        {
            return $"Make: {Make}; \n Model: {Model}; \n Year of manufaction: {ProductionYear}";
        } 
        public string GetDetailedInfo()
        {
            return $"Make: {Make}; \n Model: {Model}; \n Year of manufaction: {ProductionYear}; \n Motor Size: {MotorSize}; \n Color {Color}:";
        }
    }
}

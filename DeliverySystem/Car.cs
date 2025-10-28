using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem
{
    public class Car : Vehicle
    {
        protected int doors;      
        protected double fuelLevel;

        public Car(string brand, int year, double mileage, int doors, double maxSpeed)
            : base(brand, year, mileage, maxSpeed)
        {
            this.doors = doors;
            this.fuelLevel = 50;
        }

        public Car(string brand, int year,  double mileage, int doors)
            : this(brand, year, mileage, doors, 180.0)
        {
        }


        public override string GetInfo()
        {
            return $"Car: {brand} ({year}), Doors: {doors}, Fuel: {fuelLevel}L";
        }

        public override double GetMaxSpeed()
        {
            return maxSpeed;
        }

        public override void Move(double distance)
        {
            double fuelUsed = distance * 0.1;
            fuelLevel -= fuelUsed;
            if (fuelLevel < 0)
                fuelLevel = 0;

            base.Move(distance);
        }

        public void Refuel(double liters)
        {
            fuelLevel += liters;
            if (fuelLevel > 50)
            {
                fuelLevel = 50;
            }
        }

    }

}

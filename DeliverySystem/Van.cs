using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliverySystem
{
    public class Van: Car
    {
        private double loadCapacity;
        private double currentLoad;

        public Van(string brand, int year, double mileage, int doors, double loadCapacity) 
            : base(brand, year, mileage, doors, 140.0)
        {
            this.loadCapacity = loadCapacity;
            this.currentLoad = 0;
            this.doors = doors;
        }

        public override string GetInfo()
        {
            return $"Van: {brand} ({year}), Doors: {doors}, Load: {currentLoad}/{loadCapacity}kg, Fuel: {fuelLevel}L";
        }

        public override double GetMaxSpeed()
        {
            return maxSpeed;
        }

        public void LoadCargo(double weight)
        {
            if (currentLoad + weight <= loadCapacity)
            {
                currentLoad += weight;
                Console.WriteLine($"{weight} kg loaded into the van.");
            }
            else
            {
                Console.WriteLine("Too heavy! Cannot load more cargo.");
            }
        }

        public void UnloadCargo()
        {
            currentLoad = 0;
            Console.WriteLine("Van unloaded.");
        }



    }
}


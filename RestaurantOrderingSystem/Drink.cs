using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderingSystem
{
    public class Drink : MenuItem
    {
        public double Volume { get; private set; }
        public double AlcoholContent { get; private set; }

        public Drink(string name, decimal price, string category, double volume, double alcoholContent = 0)
       : base(name, price, category)
        {
            Volume = volume;
            AlcoholContent = alcoholContent;
        }

        public override string GetDescription()
        {
            string alcoholInfo = "";

            if (AlcoholContent > 0)
            {
                alcoholInfo = $", {AlcoholContent}% алкоголю";
            }

            return $"Напій, {Category}, {Volume}л{alcoholInfo}";
        }
    }
}

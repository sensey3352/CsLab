using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderingSystem
{
    public class Food : MenuItem
    {
        public int WeightGrams { get; private set; }

        public Food(string name, decimal price, string category, int weightGrams)
       : base(name, price, category)
        {
            WeightGrams = weightGrams;
        }

        public override string GetDescription()
        {
            return $"Їжа, {Category}, {WeightGrams}г";
        }

    }
}

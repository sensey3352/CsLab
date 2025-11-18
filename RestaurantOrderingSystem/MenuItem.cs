using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderingSystem
{
    public abstract class MenuItem : IMenuItem
    {
        public string Name { get; protected set; }
        public decimal Price { get; protected set; }
        public string Category { get; protected set; }

        protected MenuItem(string name, decimal price, string category)
        {
            Name = name;
            Category = category;
            Price = price;
        }

        public abstract string GetDescription();
    }
}

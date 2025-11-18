using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderingSystem
{
    public interface IOrder
    {
        int Id { get; }
        int TableNumber { get; }
        string Status { get; }
        void AddItem(IMenuItem item);
        void RemoveItem(IMenuItem item);
        decimal CalculateTotal();
    }
}

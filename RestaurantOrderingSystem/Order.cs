using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderingSystem
{
    public class Order 
    {
        public int Id { get; private set; }
        public int TableNumber { get; private set; }
        public string Status { get; private set; }
        public List<IMenuItem> Items { get; private set; }

        public Order(int id, int tableNumber)
        {
            Id = id;
            TableNumber = tableNumber;
            Status = OrderStatus.New;
            Items = new List<IMenuItem>();
        }

        public void AddItem(IMenuItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(IMenuItem item)
        {
            Items.Remove(item);
        }

        public decimal CalculateTotal()
        {
            decimal total = 0;
            foreach (var item in Items)
            {
                total += item.Price;
            }
            return total;
        }

        public void ChangeStatus(string newStatus)
        {
            string[] allStatuses = OrderStatus.GetAllStatuses();

            foreach (string status in allStatuses)
            {
                if (status == newStatus)
                {
                    Status = newStatus;
                    break;
                }
            }
        }
    }
}


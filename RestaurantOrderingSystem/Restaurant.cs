using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantOrderingSystem
{
    public class Restaurant
    {
        public string Name { get; private set; }
        public List<MenuItem> MenuItems { get; private set; }
        public List<Order> Orders { get; private set; }

        public Restaurant(string name)
        {
            Name = name;
            MenuItems = new List<MenuItem>();
            Orders = new List<Order>();
        }

        public void AddMenuItem(MenuItem item)
        {
            MenuItems.Add(item);
        }

        public void AddOrder(Order order)
        {
            Orders.Add(order);
        }

        public void ShowMenu()
        {
            Console.WriteLine($"Меню ресторану '{Name}':");
            foreach (var item in MenuItems)
            {
                Console.WriteLine($"  {item.Name} - {item.Price} грн ({item.GetDescription()})");
            }
        }

        public List<Order> GetActiveOrders()
        {
            List<Order> activeOrders = new List<Order>();

            foreach (var order in Orders)
            {
                if (order.Status == "Нове")
                {
                    activeOrders.Add(order);
                }
                else if (order.Status == "Готується")
                {
                    activeOrders.Add(order);
                }
                else if (order.Status == "Готове")
                {
                    activeOrders.Add(order);
                }
            }
            return activeOrders;
        }

        public Order FindOrderById(int id)
        {
            foreach (var order in Orders)
            {
                if (order.Id == id)
                {
                    return order;
                }
            }
            return null;
        }

        public List<MenuItem> FindItemsByCategory(string category)
        {
            List<MenuItem> foundItems = new List<MenuItem>();
            foreach (var item in MenuItems)
            {
                if (item.Category == category)
                {
                    foundItems.Add(item);
                }
            }
            return foundItems;
        }
    }
}



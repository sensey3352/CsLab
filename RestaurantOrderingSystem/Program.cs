namespace RestaurantOrderingSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Restaurant restaurant = new Restaurant("My Restaurant");

            CreateMenu(restaurant);
            Ordering(restaurant);
        }

        static void CreateMenu(Restaurant restaurant)
        {
            restaurant.AddMenuItem(new Food("Борщ", 120, "Перші страви", 350));
            restaurant.AddMenuItem(new Food("Піца Маргарита", 250, "Піца", 400));
            restaurant.AddMenuItem(new Food("Паста Карбонара", 180, "Паста", 350));
            restaurant.AddMenuItem(new Food("Салат Цезар", 110, "Салати", 300));
            restaurant.AddMenuItem(new Food("Стейк з яловичини", 450, "Головні страви", 500));

            restaurant.AddMenuItem(new Drink("Кока-Кола", 50, "Безалкогольні", 0.5));
            restaurant.AddMenuItem(new Drink("Апельсиновий сік", 60, "Соки", 0.3));
            restaurant.AddMenuItem(new Drink("Кава", 80, "Гарячі напої", 0.25));
            restaurant.AddMenuItem(new Drink("Чай зелений", 40, "Гарячі напої", 0.3));
        }

        static void Ordering(Restaurant restaurant)
        {
            Console.WriteLine("=== СИСТЕМА ЗАМОВЛЕНЬ РЕСТОРАНУ ===\n");

            Console.WriteLine("Створено нове замовлення для столика №5");

            var newOrder = new Order(1, 5);

            newOrder.AddItem(restaurant.MenuItems[3]);

            newOrder.AddItem(restaurant.MenuItems[8]);

            Console.WriteLine($"Поточна сума: {newOrder.CalculateTotal()} грн");
            Console.WriteLine();

            restaurant.AddOrder(newOrder);

            Console.WriteLine($"Статус замовлення: {newOrder.Status}");

            newOrder.ChangeStatus("Готується");
            Console.WriteLine("> Змінено статус: Готується");

            newOrder.ChangeStatus("Готове");
            Console.WriteLine("> Змінено статус: Готове");

            newOrder.ChangeStatus("Оплачено");
            Console.WriteLine("> Змінено статус: Оплачено");

            Console.WriteLine("\n--- Пошук замовлень ---");

            var foundOrder = restaurant.FindOrderById(1);
            if (foundOrder != null)
            {
                Console.WriteLine($"Знайдено замовлення #1:");
                Console.WriteLine($"Столик: {foundOrder.TableNumber}, Сума: {foundOrder.CalculateTotal()} грн");
            }

            Console.WriteLine("\n--- Пошук страв за категорією ---");

            Console.WriteLine("\nГарячі напої у меню:");
            var hotDrinks = restaurant.FindItemsByCategory("Гарячі напої");
            foreach (var drink in hotDrinks)
            {
                Console.WriteLine($"  - {drink.Name} - {drink.Price} грн");
            }

            Console.WriteLine("\nАктивні замовлення:");
            var activeOrders = restaurant.GetActiveOrders();
            if (activeOrders.Count == 0)
            {
                Console.WriteLine("Активних замовлень немає");
            }
            else
            {
                foreach (var order in activeOrders)
                {
                    Console.WriteLine($"Замовлення #{order.Id} - Столик {order.TableNumber} - {order.Status}");
                }
            }
        }
    }
}


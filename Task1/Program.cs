namespace Task1
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("Введіть число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            string message = GetMessage(number);
            Console.WriteLine(message);
        }
        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }
        public static string GetMessage(int number)
        {
            if (IsEven(number))
            {
                return "Двері відкриваються!";
            }
            else
            {
                return "Двері зачинені...";
            }
        }
    }
}

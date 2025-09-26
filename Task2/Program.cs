namespace Task2
{
    public static class Program
    {
        public static void Main()
        {
            int[] numbers = GenerateRandomArray(10, 1, 100);
            Console.WriteLine("Масив випадкових чисел:");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Сума: " + GetSum(numbers));
            Console.WriteLine("Середнє: " + GetAverage(numbers));
            Console.WriteLine("Мінімум: " + GetMin(numbers));
            Console.WriteLine("Максимум: " + GetMax(numbers));
        }
        public static int[] GenerateRandomArray(int size, int min, int max)
        {
            int[] arr = new int[size];
            Random rnd = new Random();

            for (int i = 0; i < size; i++)
            {
                arr[i] = rnd.Next(min, max + 1);
            }
            return arr;
        }
        public static int GetSum(int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum;
        }
        public static double GetAverage(int[] numbers)
        {
            return (double)GetSum(numbers) / numbers.Length;
        }
        public static int GetMin(int[] numbers)
        {
            int min = numbers[0];
            foreach (int num in numbers)
            {
                if (num < min)
                    min = num;
            }
            return min;
        }
        public static int GetMax(int[] numbers)
        {
            int max = numbers[0];
            foreach (int num in numbers)
            {
                if (num > max)
                    max = num;
            }
            return max;
        }
    }
}

namespace Task5
{
    public class Program
    {
        public static void Main()
        {
            int[][] groups = new int[][]
            {
            new int[] { 100, 90, 85, 70, 60, 95, 80, 88, 77, 66 },     
            new int[] { 67, 60, 70, 80, 95, 72, 65, 77, 89, 91, 55 },   
            new int[] { 100, 100, 95, 92, 90, 97, 99, 96, 94, 93 }      
            };
            PrintGroupStatistics(groups);
        }
        public static double GetAverage(int[] marks)
        {
            int sum = 0;
            foreach (int mark in marks)
            {
                sum += mark;
            }
            return (double)sum / marks.Length;
        }
        public static int GetMin(int[] marks)
        {
            int min = marks[0];
            foreach (int mark in marks)
            {
                if (mark < min)
                    min = mark;
            }
            return min;
        }
        public static int GetMax(int[] marks)
        {
            int max = marks[0];
            foreach (int mark in marks)
            {
                if (mark > max)
                    max = mark;
            }
            return max;
        }
        public static void PrintGroupStatistics(int[][] groups)
        {
            for (int i = 0; i < groups.Length; i++)
            {
                double average = GetAverage(groups[i]);
                int min = GetMin(groups[i]);
                int max = GetMax(groups[i]);
                Console.WriteLine($"Група {i + 1}: Середній = {average:f1}, Мінімальний = {min}, Максимальний = {max}");
            }
        }
    }
}

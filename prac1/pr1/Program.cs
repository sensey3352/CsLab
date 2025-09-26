namespace pr1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("nextline");
            Console.Write("nonextline");

            int number = 92;
            Console.WriteLine(number);
            Console.WriteLine(3 % 2);

            if (3 > 2)
            {
                number++;
                ++number;
                number = number + 1;
            }
            if (!true) { }
            else if (true) { }
            else { }
            switch (number)
            {
                case 0:
                    break;
                case 1:
                    break;
                default:
                    break;

            }
            int a =10;
            float b = 20.5f;
            decimal c = 30.5m;
            b = a;
            a=(int)b;//нізя так робить

            int[] array = new int[5];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i * 10;
            }
            int[,] array2 = new int[5, 5];
            for(int i = 0;i < array2.GetLength(0); i++)
            {
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    array2[i, j] = i * j;
                }
            }

            int[][] jaggedArray = new int[5][];
            jaggedArray[0] = new int[] { 1 };
            jaggedArray[1]=new int[] { 1,2 };
            jaggedArray[2] = new int[] { 1 ,2,3};
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                jaggedArray[i] = new int[i + 1];
                for (int j = 0;j < jaggedArray.Length; j++)
                {
                    jaggedArray[i][j] = i + j;
                }
            }

        }

        public static void Method()
        {
            Console.WriteLine("Method");
        }
        public static int Method2()
        {
            Console.WriteLine("Method");
            return 92;
        }
        private static int Method3(int param1, string param2)
        {
            Console.WriteLine($"Method3 {param1}, {param2}");
        }
    }
}

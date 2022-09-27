namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            const int m = 3;
            const int n = 3;
            int[,] arr = new int[m, n]{{ 4, 7, 3 },
                                       { 3, 6, 9 },
                                       { 0, 1, 4 }};

            Console.WriteLine("Початкова матриця:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(" ");

            Console.WriteLine("Оброблена матриця:");

            int k = 2;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (i != k - 1 && j != k - 1)
                    {
                        arr[i, j] = arr[i, j];
                        Console.Write(arr[i, j] + " ");
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            const int N = 10;
            int[] a = new int[N] { 1, 1, 2, 3, 3, 3, 4, 5, 6, 6 };

            int count = 1;
            int number = a[0];

            Console.WriteLine("Довжини всіх серій:");

            for (int i = 1; i < N; i++)
            {
                if (a[i] == number)
                    count++;
                else
                {
                    Console.Write(count + " ");
                    count = 1;
                    number = a[i];
                }
            }
            Console.Write(count + " ");
        }
    }
}
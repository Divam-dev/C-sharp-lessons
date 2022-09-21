namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int nn, nk;
            double result = 0;
            bool isnnOk, isnkOk;

            do
            {
                Console.Write("Введіть nk: ");
                string strnk = Console.ReadLine()!;
                isnkOk = int.TryParse(strnk, out nk);
                if (!isnkOk || nk < 0)
                {
                    Console.WriteLine("Помилка введення nk");
                }
            } while (!isnkOk);

            do
            {
                Console.Write("Введіть nn: ");
                string strnn = Console.ReadLine()!;
                isnnOk = int.TryParse(strnn, out nn);
                if (!isnnOk && nn < 0)
                {
                    Console.WriteLine("Помилка введення nn");
                }
            } while (!isnnOk);
            if (nn < 0 || nk < nn) Console.WriteLine("Помилка 0 <= nn <= nk");

            for (int k = nn; k < nk; k++)
            {
                result = (k * k - Math.Pow(-1, Math.Pow(k, 2) + 1) * k) / (k * k + 2);
            }
            Console.WriteLine($"Результат = {result}");
        }
    }
}
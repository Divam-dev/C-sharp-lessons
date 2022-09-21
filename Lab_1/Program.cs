namespace ConsoleApp
{

    class Program
    {
        static void Main(string[] args)
        {

            double a, t;
            bool isaOk, istOk;

            do
            {
                Console.Write("Введіть прискорення. a = ");
                string stra = Console.ReadLine()!;
                isaOk = double.TryParse(stra, out a);
                if (!isaOk)
                {
                    Console.WriteLine("Помилка введення прискорення");
                }
            } while (!isaOk);

            do
            {
                Console.Write("Введіть час. t = ");
                string strt = Console.ReadLine()!;
                istOk = double.TryParse(strt, out t);
                if (!istOk)
                {
                    Console.WriteLine("Помилка введення часу");

                }
            } while (!istOk);

            double S = (a * Math.Pow(t, 2)) / 2;
            Console.WriteLine($"Результат = {S}");
        }
    }
}
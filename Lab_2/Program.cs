using System.Text;
Console.OutputEncoding = Encoding.UTF8;

Console.Write("Введіть nk: ");
int nk = int.Parse(Console.ReadLine()!);

Console.Write("Введіть nn: ");
int nn = int.Parse(Console.ReadLine()!);

if (nn <= 0 | nk <= nn) Console.WriteLine("Помилка введення");
else
{
    double result = 1;
    for (double k = nn; k < nk; k++)
    {
        double numerator = k * k - Math.Pow(-1, Math.Pow(k, 2) + 1) * k;
        double denominator = k * k + 2;
        result = numerator / denominator;

    }
    Console.WriteLine($"Результат = {result}");
}
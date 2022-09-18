using System.Text;
Console.OutputEncoding = Encoding.UTF8;

Console.Write("Введіть a: ");
int a = int.Parse(Console.ReadLine()!);

Console.Write("Введіть t: ");
int t = int.Parse(Console.ReadLine()!);

double S = (a * Math.Pow(t, 2)) / 2;
Console.WriteLine($"Результат = {S}");
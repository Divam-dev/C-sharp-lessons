namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введіть x: ");
            float x = float.Parse(Console.ReadLine()!);

            Console.WriteLine("Введіть y: ");
            float y = float.Parse(Console.ReadLine()!);

            if (x > 0 && y > 0 || x < 0 && y < 0) Console.WriteLine("True");

            else Console.WriteLine("False");
        }
    }
}
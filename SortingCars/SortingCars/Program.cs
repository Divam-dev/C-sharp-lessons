class Cars
{
    public class Car
    {
        public List<string> Colors;
        public int Year;
        public int Price;
        public string FuelType;
        public string Model;
    }

    private List<Car> cars;

    public Cars()
    {
        cars = new List<Car>
        {
            new Car {Colors = new List<string> {"white", "black"}, Year = 2020, Price = 20000, FuelType = "Gasoline", Model = "Honda Civic"},
            new Car {Colors = new List<string> {"red", "blue"}, Year = 2019, Price = 25000, FuelType = "Diesel", Model = "Toyota Camry"},
            new Car {Colors = new List<string> {"black", "silver"}, Year = 2021, Price = 30000, FuelType = "Gasoline", Model = "Mitsubishi Outlander"},
            new Car {Colors = new List<string> {"gray", "green"}, Year = 2017, Price = 30000, FuelType = "Electric", Model = "Nissan Leaf"},
            new Car {Colors = new List<string> {"white", "black", "silver"}, Year = 2016, Price = 25000, FuelType = "Gasoline", Model = "Mazda CX-5"}
        };
    }

    public Cars.Car FindCar(List<string> colors, int year, int price, string fuelType)
    {
        Car result = cars.Find(car => colors.Any(color => car.Colors.Contains(color)) && car.Year == year && car.Price == price && car.FuelType == fuelType);
        return result;
    }

    public void PrintCar(Cars.Car car)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;

        if (car == null)
        {
            Console.WriteLine("Немає автомобілів з заданими параметрами.");
        }
        else
        {
            Console.WriteLine("Модель: " + car.Model);
            Console.WriteLine("Кольори: " + string.Join(", ", car.Colors));
            Console.WriteLine("Рік: " + car.Year);
            Console.WriteLine("Ціна: " + car.Price);
            Console.WriteLine("Тип палива: " + car.FuelType);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;

        Cars carInventory = new Cars();

        Console.WriteLine("Введіть колір автомобіля:");
        string colorInput = Console.ReadLine();
        var colors = new List<string> { colorInput };

        Console.WriteLine("Введіть рік випуску автомобіля:");
        int year = int.Parse(Console.ReadLine());

        Console.WriteLine("Введіть ціну автомобіля:");
        int price = int.Parse(Console.ReadLine());

        Console.WriteLine("Введіть тип палива автомобіля:");
        string fuelType = Console.ReadLine();

        Cars.Car selectedCar = carInventory.FindCar(colors, year, price, fuelType);
        carInventory.PrintCar(selectedCar);
    }
}
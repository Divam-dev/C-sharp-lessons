using static Cars;

class Cars
{
    public class Car
    {
        public string[] colors;
        public int year;
        public int price;
        public string model;

        public Car(string[] colors, int year, int price, string model)
        {
            this.colors = colors;
            this.year = year;
            this.price = price;
            this.model = model;
        }
    }
    public List<Car> cars = new List<Car>();

    public Cars()
    {
        cars.Add(new Car(new string[] { "red", "black" }, 2018, 20000, "Honda Civic"));
        cars.Add(new Car(new string[] { "white", "blue" }, 2020, 30000, "Toyota Corolla"));
        cars.Add(new Car(new string[] { "black", "silver" }, 2016, 15000, "Mazda3"));
        cars.Add(new Car(new string[] { "gray", "green" }, 2019, 25000, "Nissan Altima"));
        cars.Add(new Car(new string[] { "silver", "brown" }, 2015, 10000, "Suzuki SX4"));
    }

    public Car FindCar(string color, int year, int price, string model)
    {
        foreach (Car car in cars)
        {
            if (car.colors.Contains(color) && car.year == year && car.price == price && car.model.Contains(model))
            {
                return car;
            }
        }
        return null;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Cars availableCars = new Cars();
        Console.WriteLine("Enter color:");
        string color = Console.ReadLine();
        Console.WriteLine("Enter year:");
        int year = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter price:");
        int price = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter model:");
        string model = Console.ReadLine();

        Car chosenCar = availableCars.FindCar(color, year, price, model);

        if (chosenCar == null)
        {
            Console.WriteLine("No car found with these parameters");
        }
        else
        {
            Console.WriteLine("Car with color: " + chosenCar.colors + " year: " + chosenCar.year + " price: " + chosenCar.price + " model: " + chosenCar.model);
        }
    }
}


namespace ConsoleApp.Model
{
    public class Car
    {
        public string PlateNumber { get; set; }
        public int YearOfProduction { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }

        public double Mileage { get; private set; }

        public void AddKm(double km)
        {
            Mileage += km;
        }
    }
}

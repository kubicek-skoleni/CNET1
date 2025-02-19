using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental;

public class CarDataset
{
    public static CarDealer LoadCarDealer(string file, string name, string adress)
    {
                
        List<Car> cars = new();

        var lines = File.ReadAllLines(file);

        foreach(var line in lines)
        {
            Car car = new Car();
            var items = line.Split(',');
            car.RegNumber = items[0];
            car.Brand = (CarBrand)int.Parse(items[1]);
            car.ModelYear = int.Parse(items[2]);
            cars.Add(car);
        }

        CarDealer pujcovna = new();
        pujcovna.CarsForRent = cars;
        pujcovna.Name = name;
        pujcovna.Adress = adress;

        return pujcovna;
    }

    public static void SaveCarsToFile(string file, List<Car> cars)
    {
        var lines = cars.Select(car => 
                    $"{car.RegNumber},{(int)car.Brand},{car.ModelYear}");
        File.WriteAllLines(file, lines);
    }

    public static List<Car> GetRandomCars(int count)
    {
        List<Car> cars = new();

        for(int i = 0; i < count; i++)
        {
            var car = GetRandomCar();
            cars.Add(car);
        }

        return cars;
    }
    public static Car GetRandomCar()
    {
        Car car = new();

        //szp - regNumber
        var povolene_znaky = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        char[] znaky = povolene_znaky.ToArray<char>();
        Random.Shared.Shuffle<char>(znaky);
        car.RegNumber = new string(znaky.Take(6).ToArray());

        // rok (model)
        car.ModelYear = Random.Shared.Next(1990, 2025);

        // značka auta/brand
        // získat pole z enumu [SKODA, AUDI, ..]
        CarBrand[] brands = (CarBrand[])Enum.GetValues(typeof(CarBrand));
        // random pole seřadit
        Random.Shared.Shuffle<CarBrand>(brands);
        // vzít první položku z pole
        car.Brand = brands.First();

        return car;
    }
}

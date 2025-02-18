using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental;

class CarDataset
{
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

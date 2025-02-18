using CarRental;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Den2
    {
        void Exceptions()
        {
            string[] dny = ["pondělí", "úterý", "středa", "čtvrtek",
                "pátek", "sobota", "neděle"];
            string DenVTydnu(int x)
            {
                if (x < 0 || x > 6)
                    throw new IndexOutOfRangeException();

                return dny[x - 1];
            }

            try
            {
                var den = DenVTydnu(8);
                Console.WriteLine($"den: {den}");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("index mimo rozsah pole");
            }
            catch (Exception ex)
            {
                Console.WriteLine("nastala chyba");
            }
            finally
            {
                Console.WriteLine("toto se provede vždy");
            }
        }

        void References()
        {
            //using CarRental;

            var car1 = new Car("AXB0101", CarBrand.SKODA, 2021);

            Car car2 = new("BS1234");
            car2.ModelYear = 1999;
            car2.Brand = CarBrand.AUDI;

            //tisk do konzole
            Console.WriteLine(car1.CarInfo());
            Console.WriteLine(car2.CarInfo());

            car2 = car1;

            car2.ModelYear = 2025;

            Console.WriteLine(car1.CarInfo());
            Console.WriteLine(car2.CarInfo());
        }

        void cars()
        {
            var car1 = new Car("AXB0101", CarBrand.SKODA, 2021);
            var car2 = new Car("BS1234", CarBrand.AUDI, 2005);

            Person person = new()
            {
                Name = "Pavel Novák",
                DateOfBirth = new DateOnly(2002, 3, 22),
                Document = DocumentType.ID,
                DocumentNumber = "1234512"
            };

            person.RentedCar = car1;

            CarDealer pujcovna = new();
            pujcovna.Name = "nejlepší půjčovna aut";

            pujcovna.CarsForRent.Add(car1);
            pujcovna.CarsForRent.Add(car2);

            Console.WriteLine($"půjčovna jméno: {pujcovna.Name}");
            Console.WriteLine($"půjčovna adresa: {pujcovna.Adress}");

            foreach (var car in pujcovna.CarsForRent)
            {
                Console.WriteLine($"{car.CarInfo()}");
            }
        }
    }
}

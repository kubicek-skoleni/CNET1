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

        void LINQ1()
        {
            int[] numbers = [33, -234, 0, 1223, 43223, -999999, 0, 11, 23];

            // where - filtr
            var kladna = numbers.Where(number => number >= 0);

            // orderBy - řazení
            var ordered = numbers.OrderByDescending(number => number);

            // Take
            var first_5 = numbers.Take(5);

            // skip
            var skip_5 = numbers.Skip(5);

            // agregační - Max, Min, Sum, Average
            var max = numbers.Max();
            var sum = numbers.Sum();
            var avg = numbers.Average();
            var count = numbers.Count();

            // select - transormační 
            var abs = numbers.Select(number => Math.Abs(number));

            // First, FirstOrDefault,..
            var first = numbers.First();

            var smallest_3 = numbers.OrderBy(number => number).Take(3);

            Console.WriteLine("numbers: " + string.Join(", ", numbers));
            Console.WriteLine("kladna: " + string.Join(", ", kladna));
            Console.WriteLine("ordered: " + string.Join(", ", ordered));
            Console.WriteLine("first_5: " + string.Join(", ", first_5));
            Console.WriteLine("skip_5: " + string.Join(", ", skip_5));
            Console.WriteLine($"max: {max}");
            Console.WriteLine($"sum: {sum}");
            Console.WriteLine($"avg: {avg}");
            Console.WriteLine($"count: {count}");
            Console.WriteLine("abs: " + string.Join(", ", abs));
            Console.WriteLine("smallest_3: " + string.Join(", ", smallest_3));


            // 1. kolik obsahuje pole kladných čísel
            // 2. kolik obsahuje pole záporných čísel
            // 3. sumu kladných hodnot
            // 4. najděte první tři největší absolutní hodnoty
            // 5. seřaďte pole od nejmenších po největší hodnoty, 
            //    přeskočte první 3 prvky a sečtěte zbytek hodnot


            var result_1 = numbers.Where(x => x > 0).Count();
            Console.WriteLine($"1: {result_1}");

            var result_2 = numbers.Where(x => x < 0).Count();
            Console.WriteLine($"2: {result_2}");

            var result_3 = numbers.Where(x => x > 0).Sum();
            Console.WriteLine($"3: {result_3}");

            var result_4 = numbers.Select(x => Math.Abs(x))
                                  .OrderByDescending(x => x)
                                  .Take(3);
            Console.WriteLine("4: " + string.Join(", ", result_4));

            var result_5 = numbers.OrderBy(x => x).Skip(3).Sum();
            Console.WriteLine($"5: {result_5}");



        }
    }
}

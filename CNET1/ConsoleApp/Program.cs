using CarRental;
using ConsoleApp;

CarDealer pujcovna1 =
        CarDataset.LoadCarDealer("pujcovna1.txt", "pujcovna 1", "");

CarDealer pujcovna2 =
        CarDataset.LoadCarDealer("pujcovna2.txt", "pujcovna 2", "");

Console.WriteLine("načteno");

//// kolik jakych znacek aut dohromady (vsechny pujcovny)

CarBrand[] brands = (CarBrand[])Enum.GetValues(typeof(CarBrand));

int sum = 0;

foreach (var brand in brands)
{
    var cnt_1 = pujcovna1
                .CarsForRent.Where(car => car.Brand == brand)
                .Count();
    var cnt_2 = pujcovna2
                .CarsForRent.Where(car => car.Brand == brand)
                .Count();

    var cnt = cnt_1 + cnt_2;
    sum += cnt;

    Console.WriteLine($"{brand}: {cnt}");
}

Console.WriteLine(sum);

/////////////////////////////////
/////

// sloučit obě kolekce aut
var all_cars = pujcovna1.CarsForRent.Union(pujcovna2.CarsForRent);

var grouped = all_cars.GroupBy(car => car.Brand)
        .Select(x => new { Brand = x.Key, Count = x.Count() });

foreach (var brand_count in grouped)
{
    Console.WriteLine($"brand:{brand_count.Brand}, count{brand_count.Count}");
}


int a = 0;
int? aa = null;
double b = 0;
long c = 0;
string name = null;
string? ss = null;
Car d = null;
Person p = null;
DateTime? dt;
DateOnly? dd = null;

if (!string.IsNullOrEmpty(name))
{
    name.ToLower();
}
else
{
    Console.WriteLine("xx");
}


string[] dny = ["pondělí", "úterý", "středa", "čtvrtek",
                "pátek", "sobota", "neděle"];

var result = dny.Select(word => new Car() { RegNumber = word });

foreach (var num in result)
{
    Console.WriteLine(num);
}
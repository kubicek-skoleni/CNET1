using CarRental;

CarDealer pujcovna1 =
        CarDataset.LoadCarDealer("pujcovna1.txt", "pujcovna 1", "");

CarDealer pujcovna2 =
        CarDataset.LoadCarDealer("pujcovna2.txt", "pujcovna 2", "");

Console.WriteLine("načteno");

// kolik jakych znacek aut dohromady (vsechny pujcovny)

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

///////////////////////////////
///

var all_cars = pujcovna1.CarsForRent.Union(pujcovna2.CarsForRent);

var grouped = all_cars.GroupBy(x => x.Brand)
        .Select(x => new { Brand = x.Key, Count = x.Count() });

foreach(var brand_count in grouped)
{
    Console.WriteLine($"brand:{brand_count.Brand}, count{brand_count.Count}");
    
}

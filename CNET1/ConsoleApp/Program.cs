using CarRental;
using ConsoleApp;
// commit & push test

CarDealer pujcovna1 =
        CarDataset.LoadCarDealer("pujcovna1.txt", "pujcovna 1", "");

CarDealer pujcovna2 =
        CarDataset.LoadCarDealer("pujcovna2.txt", "pujcovna 2", "");

Console.WriteLine("načteno");

Console.WriteLine(pujcovna1);
Console.WriteLine(pujcovna2);

Person person = new()
{
    Name = "Pavel Novák",
    DateOfBirth = new DateOnly(2002, 3, 22),
    Document = DocumentType.ID,
    DocumentNumber = "1234512"
};

// nejnovější model SKODA z půjčovny 1
// přiřadit osobě

var car = pujcovna2.CarsForRent
         .Where(car => car.Brand == CarBrand.SKODA)
         .OrderByDescending(car => car.ModelYear)
         .First();

string name = null;

name ??= "beze jména";
name += "append";
pujcovna2.Name = name ?? "beze jména";
pujcovna2.Name = (name != null) ? name : "beze jména";



//person.RentedCar = car;

//if (person != null && person.RentedCar != null)
//{
//    var znacka = person.RentedCar.RegNumber;
//}

var znacka = person?.RentedCar?.RegNumber;

if(znacka != null)
{

}


Console.WriteLine("konec");






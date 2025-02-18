using CarRental;

var car1 = CarDataset.GetRandomCar();
var car2 = CarDataset.GetRandomCar();


Console.WriteLine(car1.CarInfo());
Console.WriteLine(car2.CarInfo());
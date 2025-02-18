
using CarRental;
using ConsoleApp;

Person person = new()
{
    Name = "Pavel Novák",
    DateOfBirth = new DateOnly(2002, 3, 22),
    Document = DocumentType.ID,
    DocumentNumber = "1234512"
};

//null
Car car1 = null; // new Car("123451");
person.RentedCar = car1;

string car_info = person.RentedCar.CarInfo();
Console.WriteLine($"car info: {car_info}");











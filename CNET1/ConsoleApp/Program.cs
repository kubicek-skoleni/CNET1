
using CarRental;
using ConsoleApp;

var car1 = new Car("AXB0101", CarBrand.SKODA, 2021);

Car car2 = new("BS1234");
car2.ModelYear = 1999;
car2.Brand = CarBrand.AUDI;



//tisk do konzole
Console.WriteLine(car1.CarInfo());
Console.WriteLine(car2.CarInfo());


var p1 = new Person()
{
    Name = "Pavel Novák",
    DateOfBirth = new DateOnly(2001, 3, 12),
    Document = DocumentType.ID,
    DocumentNumber = "123456",
    Phone = "777222333"
};

Person p2 = new();


Console.WriteLine($"osoba p1: {p1.Name}");
Console.WriteLine($"osoba p2: {p2.Name}");

ProcessPerson(p1);
ProcessPerson(p2);

Console.WriteLine($"osoba p1: {p1.Name}");
Console.WriteLine($"osoba p2: {p2.Name}");
void ProcessPerson(Person person)
{
    if (person.Name == "")
        person.Name = "Bezejména";
}

int a = 1;
int b = 50;

Console.WriteLine($"a: {a}");
Console.WriteLine($"b: {b}");

ProcessNumber(a);
ProcessNumber(b);

Console.WriteLine($"a: {a}");
Console.WriteLine($"b: {b}");


void ProcessNumber(int input)
{
    if (input < 5)
        input = 10;
}






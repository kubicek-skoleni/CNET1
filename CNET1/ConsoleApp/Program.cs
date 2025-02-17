List<int> numbers = [2, 10, -555, 0, 12_000_000, -555];

List<int> numbers2 = new();

numbers2.Add(50);
var third = numbers.ElementAt(2);

Console.WriteLine($"treti element: {third}");

foreach(int item in numbers)
{
    Console.WriteLine(item);
}





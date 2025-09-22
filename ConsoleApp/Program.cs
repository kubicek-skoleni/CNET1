Console.WriteLine("Zadej čislo nebo Q pro ukončení");

string line = Console.ReadLine();
int sum = 0;

while (line != "Q")
{
    int currentNumber = int.Parse(line);

    sum = sum + currentNumber;
    Console.WriteLine($"Aktuální součet je {sum}");
    Console.WriteLine("Napiš další číslo nebo Q pro ukončení");
    line = Console.ReadLine();
}

Console.WriteLine($"KONEC, výsledná suma je: {sum}");
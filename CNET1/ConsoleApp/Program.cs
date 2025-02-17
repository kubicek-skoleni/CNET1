//List<int> numbers = [2, 10, -555, 0, 12_000_000, -555];
//List<int> numbers2 = new();


string[] dny = ["pondělí", "úterý", "středa", "čtvrtek",
                "pátek", "sobota", "neděle"];

string DenVTydnu(int x)
{
    return dny[x - 1];
}

Console.WriteLine("Zadávej číslo 1-7 nebo X pro ukončení.");
string input = Console.ReadLine();

while(input != "X")
{
    int number = int.Parse(input);

    if(number < 1 || number > 7)
    {
        Console.WriteLine("zadané číslo je mimo povolený rozsah");
    }
    else
    {
        string den_v_tydnu = DenVTydnu(number);
        Console.WriteLine($"den v týdnu: {den_v_tydnu}");
    }

    Console.WriteLine("Zadávej číslo 1-7 nebo X pro ukončení.");
    input = Console.ReadLine();
}

Console.WriteLine("ukončuji program");



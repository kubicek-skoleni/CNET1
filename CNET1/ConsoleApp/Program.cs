


string[] dny = ["pondělí", "úterý", "středa", "čtvrtek",
                "pátek", "sobota", "neděle"];

string DenVTydnuSlovo(DenVTydnu x)
{
    return dny[(int)x];
}

Console.WriteLine("Zadávej číslo 1-7 nebo X pro ukončení.");
string input = Console.ReadLine();

while (input.ToUpper() != "X")
{
    try
    {
        int number = int.Parse(input);

        if (number < 1 || number > 7)
        {
            Console.WriteLine("zadané číslo je mimo povolený rozsah");
        }
        else
        {
            DenVTydnu den = (DenVTydnu)(number - 1);
            string den_v_tydnu = DenVTydnuSlovo(den);
            Console.WriteLine($"den v týdnu: {den_v_tydnu}");
        }
    }catch(Exception ex)
    {
        Console.WriteLine("neplatný vstup");
    }

    Console.WriteLine("Zadávej číslo 1-7 nebo X pro ukončení.");
    input = Console.ReadLine();
}

Console.WriteLine("ukončuji program");


enum DenVTydnu
{
    PONDELI,
    UTERY,
    STREDA,
    CTVRTEK,
    PATEK,
    SOBOTA,
    NEDELE
}

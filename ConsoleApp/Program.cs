

int[] cisla = [-1, -23, -30, -433, -5, -100];

//najit nejvetsi cislo a vypsat
int zatim_nejvetsi = cisla[0];

foreach (int cislo in cisla)
{
    if(cislo > zatim_nejvetsi)
    {
        zatim_nejvetsi = cislo;
    }
}

Console.WriteLine($"Nejvetsi cislo je: {zatim_nejvetsi}");

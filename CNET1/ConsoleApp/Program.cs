


string[] dny = ["pondělí", "úterý", "středa", "čtvrtek",
                "pátek", "sobota", "neděle"];

string DenVTydnuSlovo(DenVTydnu x)
{
    return dny[(int)x];
}

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

enum RGB
{
    RED = 1,
    GREEN = 3,
    BLUE = 5
}

enum CarBrands
{
    VOLVO,
    SKODA,
    MERCEDES,
    FIAT
}

enum Brushes
{
    Violet,
    DeepBlue,
    DarkGreen,
}

string[] dny = ["pondělí", "úterý", "středa", "čtvrtek",
                "pátek", "sobota", "neděle"];

(string den, bool vikend) DenVTydnuSlovo(DenVTydnu x)
{
    bool vikend = (x == DenVTydnu.SOBOTA || x == DenVTydnu.NEDELE);
    string den = dny[(int)x];
    return (den, vikend);
}

var zadani = DenVTydnu.NEDELE;
var vysledek = DenVTydnuSlovo(zadani);
Console.WriteLine($"{zadani}: {vysledek.den}, vikend:{vysledek.vikend}");

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

﻿// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

//int a = 0;
//int b = a + 10;

//decimal x = 1.5m;
//double y = (double)x;

//string s = "Ahoj světe!";


//bool IsBigger = true;

//if (a > b)
//{
//    IsBigger = true;
//}
//else
//{
//    IsBigger = false;
//}

//string message = "M1: Je A větší než B?" + IsBigger.ToString();

//string message2 = $"M2: Je A větší než B? {IsBigger}";

//Console.WriteLine(message);
//Console.WriteLine(message2);

//char znak = 'o';



Console.WriteLine("Zadej svůj věk a zmáčkni enter:");

string? line = Console.ReadLine();

try
{
    double age = int.Parse(line);
    bool isAdult = (age >= 18.5);

    if (isAdult)
        Console.WriteLine("Uživatel je plnoletý");
    else
        Console.WriteLine("Uživatel není plnoletý");

}
catch(FormatException ex)
{
    Console.WriteLine("Vstup není číslo, ukončuji program.");
}
catch (Exception ex)
{
    Console.WriteLine($"Nastala chyba");
}













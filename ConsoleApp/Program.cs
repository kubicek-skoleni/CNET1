﻿using System.Linq.Expressions;

Console.WriteLine("Zadej číslo 1-7 a zmáčkni enter:");

string? line = Console.ReadLine();

int dayNumber = int.Parse(line);

switch (dayNumber)
{
    case 1:
        Console.WriteLine("Pondělí");
        break;
    case 2:
        Console.WriteLine("Úterý");
        break;
    case 3:
        Console.WriteLine("Středa");
        break;
    case 4:
        Console.WriteLine("Čtvrtek");
        break;
    case 5:
        Console.WriteLine("Pátek");
        break;
    case 6:
        Console.WriteLine("Sobota");
        break;
    case 7:
        Console.WriteLine("Neděle");
        break;
    default:
        Console.WriteLine("číslo mimo rozsah!");
        break;
}














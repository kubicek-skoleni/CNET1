Console.WriteLine("Zadej číslo 1-7 a zmáčkni enter:");

string? line = Console.ReadLine();

int dayNumber = int.Parse(line);

if(dayNumber == 1)
    Console.WriteLine("Pondělí");

else if (dayNumber == 2)
    Console.WriteLine("Úterý");

else if (dayNumber == 3)
    Console.WriteLine("Středa");

else if (dayNumber == 4)
    Console.WriteLine("Čtvrtek");

else if (dayNumber == 5)
    Console.WriteLine("Pátek");

else if (dayNumber == 6)
    Console.WriteLine("Sobota");

else if (dayNumber == 7)
    Console.WriteLine("Neděle");

else
    Console.WriteLine("Neplatné číslo dne v týdnu.");















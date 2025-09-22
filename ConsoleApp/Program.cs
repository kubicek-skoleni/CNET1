

double c = 25.0;

double f = FromCelsiusToFahrenheit(c);

Console.WriteLine($"hodnota C:{c} => F:{f}");

double FromCelsiusToFahrenheit(double celsius)
{
    double fahrenheit = (celsius * 9 / 5) + 32;

    return fahrenheit;
}


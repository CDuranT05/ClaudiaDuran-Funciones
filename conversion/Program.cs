// See https://aka.ms/new-console-template for more information

double CelsiusAFahrenheit(double celsius)
{
    double Fahrenheit = (celsius * 1.8) + 32;
    return Fahrenheit;
}

double FahrenheitACelsius(double fahrenheit)
{
    double Celsius = (fahrenheit - 32 ) / 1.8;
    return Celsius;
}

double CelsiusAKelvin(double celsius)
{
    double Kelvin = celsius + 273.15;
    return Kelvin;
}

Console.WriteLine("Por favor ingresa tu opcion preferida a Calcular: 1.CelsiusAFahrenheit, 2.FahrenheitACelsius, 3,CelsiusAKelvin");
Console.WriteLine("1-2-3   para salir: (S)");
string usuario = Console.ReadLine();


    
    if (usuario == "1")
    {
        Console.WriteLine("Por favor ingresa los grados Celsius");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("la conversion de celcius a Fahrenheit es: " + CelsiusAFahrenheit(c));

    }
    else if (usuario == "2")
    {
        Console.WriteLine("Por favor ingresa los grados Fahrenheit");
        double f = double.Parse(Console.ReadLine());
        Console.WriteLine("la conversion de Fahrenheit a celcius es: " + FahrenheitACelsius(f));

    }
    else if (usuario == "3")
    {
        Console.WriteLine("Por favor ingresa los grados Celsius");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("la conversion de celcius a Kelvin es: " + CelsiusAKelvin(c));

    }
    
    else
    {
        Console.WriteLine("No se ha encontado ninguna opcion a calcular");
    }

   



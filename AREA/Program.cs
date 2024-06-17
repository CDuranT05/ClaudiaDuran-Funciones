// See https://aka.ms/new-console-template for more information 

Console.WriteLine("Por favor ingresa tu opcion preferida: 1.Triangulo, 2.Rectangulo, 3,Circulo");
Console.WriteLine("1-2-3");
string usuario = Console.ReadLine();
double CalcularArea(string usuario)
{
    double area = 0;


    if (usuario == "1") {
        Console.WriteLine("Por favor ingresa la base");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Por favor ingrese la altura");
        double a = double.Parse(Console.ReadLine());
        area = (b * a) / 2;
        Console.WriteLine("el area del triangulo es: ");
    }
    else if (usuario == "2") {
        Console.WriteLine("Por favor ingresa la base");
        double br = double.Parse(Console.ReadLine());
        Console.WriteLine("Por favor ingrese la altura");
        double ar = double.Parse(Console.ReadLine());
        area = br * ar;
        Console.WriteLine("el area del rectangulo es: ");

    }
    else if (usuario == "3") {
        Console.WriteLine("Por favor ingresa el radio");
        double r = double.Parse(Console.ReadLine());
        area = 3.14 * Math.Pow(r, 2);
        Console.WriteLine("el area del circulo es: ");

    }
    else { 
            Console.WriteLine("no se puede calcular el area");
    }

       
    return area;    
}



Console.WriteLine(CalcularArea(usuario));




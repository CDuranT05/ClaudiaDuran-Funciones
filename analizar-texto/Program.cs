// See https://aka.ms/new-console-template for more information

string ContarPalabras(string texto)
{
    string[] Contar = texto.Split(" ");
    int Contador = Contar.Count();

    return Contador.ToString();
}

string ContarVocales(string texto)
{
    string[] Parrafo = [texto];
    int contador = 0;

    foreach (string p in Parrafo)
    {
        string P = p.ToUpper();
        foreach (char c in P)
        {
            if (c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
            {
                contador++;
            }

        }
    }
    return  contador.ToString();
}
string InvertirTexto(string texto)
{
    char[] reverso = texto.ToCharArray();
    Array.Reverse(reverso);
    return new string(reverso);

}
Console.WriteLine("Ingresa un texto largo");

string usuario = Console.ReadLine();
Console.WriteLine("El numero de palabras es: " + ContarPalabras(usuario));
Console.WriteLine("El numero de Vocales es: " +ContarVocales(usuario));
Console.WriteLine("El texto invertido es: " + InvertirTexto(usuario));
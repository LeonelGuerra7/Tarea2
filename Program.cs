using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un número entero para convertir a decimal: ");
        int entero = int.Parse(Console.ReadLine());
        decimal decimalResultado = Convert.ToDecimal(entero);
        Console.WriteLine($"Entero a Decimal: {decimalResultado}");

        Console.Write("Ingrese un número decimal para convertir a flotante: ");
        decimal decimalNumero = decimal.Parse(Console.ReadLine());
        float floatResultado = Convert.ToSingle(decimalNumero);
        Console.WriteLine($"Decimal a Flotante: {floatResultado}");

        Console.Write("Ingrese un número flotante para convertir a entero: ");
        float flotanteNumero = float.Parse(Console.ReadLine());
        int enteroResultado = Convert.ToInt32(flotanteNumero);
        Console.WriteLine($"Flotante a Entero: {enteroResultado}");

        Console.Write("Ingrese un carácter para convertir a entero: ");
        char caracter = char.Parse(Console.ReadLine());
        int caracterEntero = Convert.ToInt32(caracter);
        Console.WriteLine($"Carácter a Entero: {caracterEntero}");

        Console.Write("Ingrese un número entero para convertir a carácter: ");
        int enteroCaracter = int.Parse(Console.ReadLine());
        char enteroCaracterResultado = Convert.ToChar(enteroCaracter);
        Console.WriteLine($"Entero a Carácter: {enteroCaracterResultado}");
    }
}


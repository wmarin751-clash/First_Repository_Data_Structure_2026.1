var numberstring = string.Empty;

do
{

    Console.Write("Ingrese número entero o presione la palabra 'Salir' para salir: ");
    numberstring = Console.ReadLine();
    if (numberstring!.ToLower() == "salir")
    {
        continue;
    }
    var numberInt = 0;
    if (int.TryParse(numberstring, out numberInt))
    {
        if (numberInt % 2 == 0)
        {
            Console.WriteLine($"El número {numberInt} es par.");
        }
        else
        {
            Console.WriteLine($"El número {numberInt} es impar.");
        }
    }
    else
    {
        Console.WriteLine($"Lo que ingresaste: {numberstring} no es un número entero. ");
    }
} while (numberstring!.ToLower() != "salir");
Console.WriteLine("Game Over!");
 
using System;
// 1. Definición de variables y constantes
const int DeskPrice = 650000;
int cantidad;
double GrossTotal, Descount, FinalValue;

// 2. Entrada de datos
Console.Write("Número de escritorios: ");
// Leemos la entrada y la convertimos a entero
cantidad = int.Parse(Console.ReadLine());

// 3. Proceso y Lógica de Descuentos
GrossTotal = cantidad * DeskPrice;

if (cantidad < 5)
{
    Descount = GrossTotal * 0.10; // 10% de descuento
}
else if (cantidad < 10)
{
    Descount = GrossTotal * 0.20; // 20% de descuento
}
else
{
    Descount = GrossTotal * 0.40; // 40% de descuento
}

FinalValue = GrossTotal - Descount;

// 4. Salida de resultados
Console.WriteLine("El valor a pagar es: " + FinalValue);

// Pausa para que no se cierre la consola inmediatamente
Console.WriteLine("\nPresione cualquier tecla para salir...");
Console.ReadKey();

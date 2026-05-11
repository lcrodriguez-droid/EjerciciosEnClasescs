/*Un sistema de monitoreo industrial registra diferencias de 
producción entre dos máquinas durante cinco períodos 
consecutivos. El departamento técnico necesita calcular la 
diferencia entre ambos vectores.

Instrucciones
Crear dos arreglos.
Ingresar los valores correspondientes a cada vector.
Utilizar un ciclo for para realizar la resta posición por posición.
Guardar el resultado en un nuevo vector.
Mostrar el vector resultante en pantalla.*/
using System;
int[] Vector1 = new int [5];
int[] Vector2 = new int [5];
int[] Diferencia = new int [5];

Console.WriteLine("Ingrese los valores del primer vector:");
for (int i = 0; i < Vector1.Length; i++)
{
    try
    {
        Console.Write($"Elemento {i + 1}: ");
        Vector1[i] = int.Parse(Console.ReadLine()!);
    }
    catch (FormatException)
    {
        Console.WriteLine("Por favor, ingrese un número válido.");
        i--; // Decrementar el índice para volver a solicitar el valor
    }
}
Console.WriteLine("Ingrese los valores del segundo vector:");
for (int i = 0; i < Vector2.Length; i++)
{
    try
    {
        Console.Write($"Elemento {i + 1}: ");
        Vector2[i] = int.Parse(Console.ReadLine()!);
    }
    catch (FormatException)
    {
        Console.WriteLine("Por favor, ingrese un número válido.");
        i--; // Decrementar el índice para volver a solicitar el valor
    }
}
for (int i = 0; i < Vector1.Length; i++)
{
    Diferencia[i] = Vector1[i] - Vector2[i];
}
Console.WriteLine("La diferencia entre los dos vectores es:");
for (int i = 0; i < Diferencia.Length; i++)
{
    Console.WriteLine($"Elemento {i + 1}: {Diferencia[i]}");
}
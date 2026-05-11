/*Un robot industrial realiza movimientos en 
cinco direcciones diferentes dentro de una planta 
automatizada. El equipo de ingeniería necesita 
calcular la magnitud total del vector de movimiento para 
validar la trayectoria recorrida.

Vector
V = (3, 4, 5, 6, 7)
Instrucciones
Crear un arreglo.
Recorrer el vector utilizando un ciclo for.
Elevar al cuadrado cada elemento del vector.
Sumar todos los cuadrados obtenidos.
Aplicar la función Math.Sqrt() para calcular la magnitud.
Mostrar el resultado final en pantalla.*/


using System.Numerics;

double[] Vector1 = new double [5];
double SumaCuadrados = 0;
double Magnitud = 0;
Console.WriteLine("Ingrese los elementos del vector:");
for (int i = 0; i < Vector1.Length; i++)
{
    try
    {
        Console.Write($"Elemento {i + 1}: ");
        Vector1[i] = int.Parse(Console.ReadLine()!);
    }
    catch (FormatException)
    {
        Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");
        i--; // Decrementar el índice para volver a solicitar el mismo elemento
    }

}
for (int i=0; i<Vector1.Length; i++)
{
    Vector1[i]= Math.Pow(Vector1[i], 2);
}
for (int i=0; i<Vector1.Length; i++)
{
    SumaCuadrados += Vector1[i];
}
for (int i=0; i<Vector1.Length; i++)
{
    Magnitud = Math.Sqrt(SumaCuadrados);
}
Console.WriteLine($"La magnitud del vector es: {Magnitud}");

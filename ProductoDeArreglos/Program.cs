/*Un sistema físico analiza dos conjuntos de fuerzas aplicadas 
sobre una estructura metálica. Cada fuerza está representada 
mediante un vector de tamaño 5. El objetivo es calcular el producto 
escalar entre ambos vectores para analizar su comportamiento.

Vectores
A = (1, 2, 3, 4, 5)
B = (5, 4, 3, 2, 1)
Instrucciones
Crear dos arreglos.
Recorrer ambos vectores utilizando un ciclo for.
Multiplicar las posiciones correspondientes.
Acumular el resultado de cada multiplicación.
Mostrar el producto escalar total en pantalla.*/

int[] Vector1 = new int[5];
int[] Vector2 = new int[5];
int ProdutoEscalar = 0;

Console.WriteLine("Ingrese los valores del primer vector:");
for (int i=0;i<Vector1.Length;i++)
{
    try
    {
        Console.WriteLine($"Elemento {i+1}");
        Vector1[i]=int.Parse(Console.ReadLine()!);
    }
    catch(FormatException)
    {
        Console.WriteLine("Formato incorrecto, Escriba en un formato adecuado");
        i--;
    }
}
Console.WriteLine("Ingrese los valores del Segundo vector:");
for (int i=0;i<Vector2.Length;i++)
{
    try
    {
        Console.WriteLine($"Elemento {i+1}");
        Vector2[i]=int.Parse(Console.ReadLine()!);
    }
    catch(FormatException)
    {
        Console.WriteLine("Formato incorrecto, Escriba en un formato adecuado");
        i--;
    }
}
for(int i=0;i<Vector1.Length;i++)
{
    ProdutoEscalar+=Vector1[i]*Vector2[i];
}
Console.WriteLine($"La magnitud escalar de los 2 vectores es de: {ProdutoEscalar}");

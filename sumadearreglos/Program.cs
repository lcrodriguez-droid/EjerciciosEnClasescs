int[] Vector1=new int[5];
int[] Vector2=new int[5];
int[] SumaVector=new int[5];

Console.WriteLine("Ingrese los elementos del primer vector:");
for (int i=0; i<Vector1.Length;i++)
{
    try
    {
        Console.WriteLine($"Elemento {i + 1}:");
        Vector1[i]=int.Parse(Console.ReadLine()!);
    }
    catch (FormatException)
    {
        Console.ForegroundColor=ConsoleColor.Red;
        Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero.");
        i--; // Decrementar el índice para volver a solicitar la entrada
        Console.ResetColor();
    }
}

Console.WriteLine("Ingrese los elementos del segundo vector");
for(int i=0;i<Vector2.Length; i++)
{
    try
    {
        Console.WriteLine($"Elemento {i + 1}");
        Vector2[i]=int.Parse(Console.ReadLine()!);
    }    
    catch(FormatException)
    {
        Console.ForegroundColor=ConsoleColor.Red;
        Console.WriteLine("Entrada no valida, escriba en el formado correcto");
        i--;
        Console.ResetColor();
    }
}

Console.WriteLine("La suma de sus vectores es: ");
for(int i=0; i<SumaVector.Length;i++)
{
    SumaVector[i]=Vector1[i]+Vector2[i];
}
for(int i=0; i<SumaVector.Length;i++)
{
    Console.WriteLine($"Elemento {i+1}: {SumaVector[i]}");
}
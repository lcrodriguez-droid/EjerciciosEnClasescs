// leer un numero entero y  mostral el cuadrado de sus antecesores 
using System ;
using System.Timers;

int numero;
while (true)
{
    Console.Write ("ingrese un numero entero: ");
    if (int.TryParse (Console.ReadLine(), out numero ))
    {
        break;
    }
    
        else
        {
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine (" entrada no valida. porfavor, ingrese un numero entero ");
        Console.ResetColor();  
        }

    }
    Console.WriteLine(" mostrar el cuadrado mientras de los antecesores de " + numero +  ":");
    int cont = 1;
    while( cont < numero )

{
    Console.WriteLine ( " el cuadrado de " + cont + " es:" + Math.Pow (cont,2));
    cont++;
}


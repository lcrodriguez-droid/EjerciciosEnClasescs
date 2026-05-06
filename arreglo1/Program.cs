//leer 5 edades y mostrar la edad promedio

    
        int[] edades = new int[5];
        double suma = 0;
double promedio= 0;

        for (int i = 0; i < edades.Length; i++)
       { 
            Console.Write("dime la edad: " +(i + 1) + ": ");
            edades[i] = int.Parse(Console.ReadLine()!);
       }

        for (int i = 0; i < edades.Length; i++)
        {
            suma += edades[i];
        }

        promedio = suma / edades.Length;

        Console.WriteLine("La edad promedio es: " + promedio);
         
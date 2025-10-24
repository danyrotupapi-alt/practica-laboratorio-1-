using System;

class Program
{
    static void Main()
    {
        // Declarar variables para las tres notas
        double nota1, nota2, nota3, promedio;

        // Solicitar al usuario las tres notas
        Console.Write("Ingrese la primera nota: ");
        nota1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese la segunda nota: ");
        nota2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese la tercera nota: ");
        nota3 = Convert.ToDouble(Console.ReadLine());

        // Calcular el promedio
        promedio = (nota1 + nota2 + nota3) / 3;

        // Mostrar el promedio
        Console.WriteLine($"\nEl promedio es: {promedio:F2}");

        // Determinar si aprobó o no
        if (promedio >= 11)
        {
            Console.WriteLine("¡Felicidades! Has aprobado.");
        }
        else
        {
            Console.WriteLine("Lo siento, no has aprobado.");
        }

        // Esperar tecla para finalizar
        Console.WriteLine("\nPresiona una tecla para salir...");
        Console.ReadKey();
    }
}



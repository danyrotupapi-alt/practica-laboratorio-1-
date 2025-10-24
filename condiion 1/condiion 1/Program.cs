// See https://aka.ms/new-console-template for more information
//Paso 1: Lectura de datos 
Console.WriteLine("Digite la edad de la persona");
int edad = int.Parse(Console.ReadLine());
//Paso 2 : Proceso
string mje = "";
if (edad >= 18)
    Console.WriteLine("Es mayor de edad");
mje = "Es mayor de edad";
else
    Console.WriteLine("Es menor de edad");
mje = "Es menor de edad";

//Paso 3 : Resultados
Console.WriteLine(mje); 


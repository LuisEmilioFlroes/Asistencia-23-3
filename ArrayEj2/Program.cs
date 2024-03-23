using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese una lista de números enteros separados por comas:");
        string entrada = Console.ReadLine();

        
        string[] numerosComoString = entrada.Split(',');

        
        int[] numeros = new int[numerosComoString.Length];
        for (int i = 0; i < numerosComoString.Length; i++)
        {
            numeros[i] = int.Parse(numerosComoString[i]);
        }

        
        int maximo = numeros.Max();
        int minimo = numeros.Min();

        
        Console.WriteLine("\nEl valor máximo de la lista es: " + maximo);
        Console.WriteLine("El valor mínimo de la lista es: " + minimo);
    }
}

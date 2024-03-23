using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese una lista de nombres separados por comas:");
        string entrada = Console.ReadLine();

        
        string[] nombres = entrada.Split(',');

        
        for (int i = 0; i < nombres.Length; i++)
        {
            nombres[i] = nombres[i].Trim();
        }

        
        Array.Sort(nombres);

        
        Console.WriteLine("\nNombres ordenada alfabéticamente:");
        foreach (string nombre in nombres)
        {
            Console.WriteLine(nombre);
        }
    }
}


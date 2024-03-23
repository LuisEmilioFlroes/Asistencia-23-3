using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese una lista de calificaciones separadas por comas:");
        string entrada = Console.ReadLine();

        
        string[] calificacionesComoString = entrada.Split(',');

        
        int[] calificaciones = new int[calificacionesComoString.Length];
        for (int i = 0; i < calificacionesComoString.Length; i++)
        {
            calificaciones[i] = int.Parse(calificacionesComoString[i]);
        }

        
        bool haySobresalientes = Array.Exists(calificaciones, calificacion => calificacion >= 90);

        
        if (haySobresalientes)
        {
            Console.WriteLine("¡Si hay calificaciones sobresalientes en la lista! :)");
        }
        else
        {
            Console.WriteLine("No hay calificaciones sobresalientes en la lista :(.");
        }
    }
}

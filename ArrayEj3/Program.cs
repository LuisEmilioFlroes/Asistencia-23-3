using System;

class Program
{
    static void Main(string[] args)
    {
        
        string[] paises = { "Guatemala", "Honduras", "Canadá", "Colombia", "Perú", "Uruguay" };

        Console.WriteLine("Ingrese un nombre de país:");
        string paisBuscado = Console.ReadLine();

        
        int indice = Array.IndexOf(paises, paisBuscado);

        
        if (indice != -1)
        {
            Console.WriteLine("El país '{0}' fue encontrado en la posición {1} del arreglo.", paisBuscado, indice);
        }
        else
        {
            Console.WriteLine("El país '{0}' no fue encontrado en el arreglo.", paisBuscado);
        }
    }
}

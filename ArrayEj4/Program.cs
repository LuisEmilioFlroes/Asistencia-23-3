using System;

class Program
{
    static void Main(string[] args)
    {
        
        int[] arreglo = { 5, 4, 3, 2, 1 };

        
        Console.WriteLine("Arreglo original:");
        ImprimirArreglo(arreglo);

        
        Array.Reverse(arreglo);

        
        Console.WriteLine("\nArreglo invertido:");
        ImprimirArreglo(arreglo);
    }

    static void ImprimirArreglo(int[] arreglo)
    {
        foreach (int elemento in arreglo)
        {
            Console.Write(elemento + " ");
        }
    }
}

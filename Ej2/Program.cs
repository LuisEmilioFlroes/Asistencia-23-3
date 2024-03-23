using System;

class Program
{
    static void Main(string[] args)
    {
        int[] arregloOriginal = { 1, 2, 3, 4, 5 };
        int[] arregloInvertido = InvertirArreglo(arregloOriginal);

        Console.WriteLine("Arreglo original:");
        ImprimirArreglo(arregloOriginal);

        Console.WriteLine("\nArreglo invertido:");
        ImprimirArreglo(arregloInvertido);

    }

    static int[] InvertirArreglo(int[] arreglo)
    {
        int[] arregloInvertido = new int[arreglo.Length];

        for (int i = 0; i < arreglo.Length; i++)
        {
            arregloInvertido[i] = arreglo[arreglo.Length - 1 - i];
        }

        return arregloInvertido;

    }

    static void ImprimirArreglo(int[] arreglo)
    {
        foreach (int elemento in arreglo)
        {
            Console.Write(elemento + " ");
        }
    }
}

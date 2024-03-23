using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 3, 7, 2, 9, 5 };
        int[] arrayOrdenado = OrdenarArregloAscendente(array);

        Console.WriteLine("Arreglo original:");
        ImprimirArreglo(array);

        Console.WriteLine("\nArreglo ordenado de forma ascendente:");
        ImprimirArreglo(arrayOrdenado);
    }

    static int[] OrdenarArregloAscendente(int[] array)
    {
       
        int[] arrayClonado = (int[])array.Clone();

        Array.Sort(arrayClonado);

         return arrayClonado;
    }

    static void ImprimirArreglo(int[] array)
    {
        foreach (int elemento in array)
        {
            Console.Write(elemento + " ");
        }
    }
}

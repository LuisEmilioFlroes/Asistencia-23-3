using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int sumaDePares = SumarElementosPares(numeros);
        Console.WriteLine("La suma de los elementos pares del arreglo es: " + sumaDePares);

    }

    static int SumarElementosPares(int[] arreglo)
    {
        int suma = 0;
        for (int indice = 0; indice < arreglo.Length; indice++)
        {
            if (arreglo[indice] % 2 == 0) 
            {
                suma += arreglo[indice]; 
            }
        }
        return suma;
    }
}

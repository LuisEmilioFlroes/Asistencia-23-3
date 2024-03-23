using System;

class Program
{
    static void Main(string[] args)
    {
        int[] valores = { 1, 9, 3, 16, 5 };
        int maximo = EncontrarMaximo(valores);
        Console.WriteLine("El valor máximo en el arreglo es: " + maximo);
    }

    static int EncontrarMaximo(int[] arreglo)
    {
        int max = arreglo[0];

        
        for (int i = 1; i < arreglo.Length; i++)
        {
            
            if (arreglo[i] > max)
            {
                max = arreglo[i];
            }
        }

        return max;
    }
}

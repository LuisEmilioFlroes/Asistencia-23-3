using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 3, 9, 2, 4, 8 };
        int valoraBuscar = 9;
        int posicion = BuscarElemento(array, valoraBuscar);

        if (posicion != -1)
        {
            Console.WriteLine("El valor {0} se encuentra en la posición {1} del arreglo.", valoraBuscar, posicion);
        }
        else
        {
            Console.WriteLine("El valor {0} no se encuentra en el arreglo.", valoraBuscar);
        }
    }

    static int BuscarElemento(int[] array, int valorABuscar)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == valorABuscar)
            {
                return i;
            }
        }
        return -1; 
    }
}

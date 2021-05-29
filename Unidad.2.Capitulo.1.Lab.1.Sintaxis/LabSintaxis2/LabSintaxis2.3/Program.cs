using System;

namespace LabSintaxis2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantIteraciones = 5;
            String[] arreglo = new String[cantIteraciones];

            for (int i = 0; i < cantIteraciones; i++)
            {
                Console.WriteLine($"Ingrese texto {i + 1}");
                arreglo[i] = Console.ReadLine();
            }
            for (int i = arreglo.Length; i > 0; i--)
            {
                Console.WriteLine($"Texto {i}: {arreglo[i - 1]}");
            }
        }
    }
}


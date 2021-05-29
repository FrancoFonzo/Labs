using System;

namespace LabSintaxis2._4._7
{
    class Program
    {
        // Calcular los N primeros números primos gemelos.

        static void Main(string[] args)
        {
            Console.Write("Ingrese numero de tuplas a mostrar: ");
            int tuplas = int.Parse(Console.ReadLine());

            int n = 0;

            for (int i = 3; n < tuplas; i++)
            {
                if (esPrimo(i) && esPrimo(i + 2))
                {
                    mostrarPrimosGemelos(i, i + 2);
                    n++;
                }
            }
        }

        private static void mostrarPrimosGemelos(int a, int b)
        {   
            Console.WriteLine($"{{{a},{b}}}");
        }

        private static bool esPrimo(int numero)
        {
            for (int i = 2; i < numero; i++) 
                if (numero % i == 0) return false;

            return true;
        }
    }
}

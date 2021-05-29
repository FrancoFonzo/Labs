using System;

namespace LabSintaxis2._4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa para calcular la suma de la serie de Fibonacci, Fn = F(n-1) + F(n-2), 0 1 1 2 3 5 8 13

            int x = 0, y = 1, z, length;

            Console.Write("Ingrese rango de la serie: ");
            length = int.Parse(Console.ReadLine());

            for (int i = 0; i < length; i++)
            {
                if (i <= 1) z = i;
                else
                {
                    z = x + y;
                    x = y;
                    y = z;
                }
                Console.Write($"{z} ");
            }

        }
    }
}

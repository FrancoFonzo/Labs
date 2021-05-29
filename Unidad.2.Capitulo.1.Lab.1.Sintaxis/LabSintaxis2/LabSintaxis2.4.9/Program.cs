using System;

namespace LabSintaxis2._4._9
{
    class Program
    {

        // Realizar patron piramide con *
            
        static void Main(string[] args)
        {
            Console.Write("Ingrese numero de filas: ");
            int filas = int.Parse(Console.ReadLine());

            for (int fActual = 1; fActual <= filas; fActual++)
            {
                for (int esp = 0; esp < filas - fActual; esp++)
                {
                    Console.Write(" ");
                }
                for (int ast = 0; ast < (fActual * 2) - 1; ast++)
                {               
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }
    }
}

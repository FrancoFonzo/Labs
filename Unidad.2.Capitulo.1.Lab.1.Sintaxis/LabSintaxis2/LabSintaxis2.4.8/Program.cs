using System;

namespace LabSintaxis2._4._8
{
    class Program
    {

        // Algoritmo para el ingreso de una clave:

        const String clave = "Franco Fonzo";

        static void Main(string[] args)
        {
            int intentos = 0;
            while (intentos < 3)
            {
                intentos++;
                Console.Write("Ingrese la clave: ");
                if (Console.ReadLine().Equals(clave)) break;
                Console.WriteLine($"Contraseña incorrecta. {3 - intentos} intentos restantes");
                if (intentos > 2) return;
            }
            Console.WriteLine("Clave correcta!");
        }
    }
}

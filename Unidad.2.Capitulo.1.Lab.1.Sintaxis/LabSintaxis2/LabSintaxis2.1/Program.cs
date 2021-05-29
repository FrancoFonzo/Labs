using System;

namespace LabSintaxis2._1

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese texto: ");
            String inputTexto = Console.ReadLine();
            if (inputTexto != "")
            {
                Console.WriteLine("1) Mostrar texto en Mayusculas");
                Console.WriteLine("2) Mostrar texto en Minusculas");
                Console.WriteLine("3) Mostrar cantidad de caracteres del texto");

                ConsoleKeyInfo opcion = Console.ReadKey();

                if (opcion.Key == ConsoleKey.D1)
                {
                    Console.WriteLine($"Texto en mayusculas: {inputTexto.ToUpper()}");
                }
                else if (opcion.Key == ConsoleKey.D2)
                {
                    Console.WriteLine($"Texto en minusculas: {inputTexto.ToLower()}");
                }
                else if (opcion.Key == ConsoleKey.D3)
                {
                    Console.WriteLine($"Caracteres del texto: {inputTexto.Length}");
                }
                else
                {
                    Console.WriteLine("No se ingreso una ocpion correcta");
                    return;
                }
            }
            else Console.WriteLine("No se ingreso un texto!");

        }
    }
}

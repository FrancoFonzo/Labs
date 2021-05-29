using System;

namespace LabSintaxis2._2
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

                switch (opcion.Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine($"Texto en mayusculas: {inputTexto.ToUpper()}");
                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine($"Texto en minusculas: {inputTexto.ToLower()}");
                        break;
                    case ConsoleKey.D3:
                        Console.WriteLine($"Caracteres del texto: {inputTexto.Length}");
                        break;
                    default:
                        Console.WriteLine("No se ingreso una ocpion correcta");
                        return;
                }
            }
            else Console.WriteLine("No se ingreso un texto!");
        }
    }
}

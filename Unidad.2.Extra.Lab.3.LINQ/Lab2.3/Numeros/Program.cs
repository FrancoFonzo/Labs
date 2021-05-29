using System;
using System.Linq;
using System.Collections.Generic;

namespace Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();

            String opc;
            do
            {
                do
                {
                    try
                    {
                        Console.Clear();
                        Console.Write("\nIngrese un numero: ");
                        numeros.Add(int.Parse(Console.ReadLine()));
                        break;
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("El numero que has ingresado es muy grande.");
                        Console.ReadKey();
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Debes ingresar un numero.");
                        Console.ReadKey();
                    }
                } while (true);              

                Console.WriteLine("\nDesea seguir ingresando numeros? (S/N)");
                opc = Console.ReadLine();

            } while (opc.Equals("S", StringComparison.OrdinalIgnoreCase));

            var numerosMay20 = numeros.Where(n => n > 20);

            foreach (var num in numerosMay20)
            {
                Console.WriteLine(num);
            }
        }
    }
}

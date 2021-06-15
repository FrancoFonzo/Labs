using System;
using System.IO;

namespace Lab4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            leer();
            escribir();
            leer();
        }

        private static void leer()
        {
            StreamReader lector = File.OpenText("agenda.txt");
            string linea;
            Console.WriteLine("Nombre\tApellido\tEmail\t\t\tTelefono");

            do
            {
                linea = lector.ReadLine();
                if (linea != null)
                {
                    string[] valores = linea.Split(';');
                    Console.WriteLine($"{valores[0]}\t{valores[1]}\t{valores[2]}\t{valores[3]}");
                }
            } while (linea != null);

            lector.Close();
        }

        private static void escribir()
        {
            Console.ReadKey();
            Console.Clear();
            StreamWriter escritor = File.AppendText("agenda.txt");
            Console.WriteLine("Ingrese nuevo contacto");

            string rta = "S";

            while (rta.Equals("s", StringComparison.OrdinalIgnoreCase))
            {
                Console.Write("\nIngrese nombre: ");
                string nombre = Console.ReadLine();
                Console.Write("\nIngrese apellido: ");
                string apellido = Console.ReadLine();
                Console.Write("\nIngrese email: ");
                string email = Console.ReadLine();
                Console.Write("\nIngrese telefono: ");
                string telefono = Console.ReadLine();
                Console.WriteLine();
            
                escritor.WriteLine($"{nombre};{apellido};{email};{telefono}");

                Console.Write("Desea ingresar otro contacto? (S/N): ");
                rta = Console.ReadLine();
            }
            escritor.Close();
        }
    }
}

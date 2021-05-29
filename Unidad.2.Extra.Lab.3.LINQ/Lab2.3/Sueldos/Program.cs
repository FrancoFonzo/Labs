using System;
using System.Linq;
using System.Collections.Generic;

namespace Sueldos
{
    class Program
    {

        static int id = 1;
        static List<Empleado> listaEmpleados = new List<Empleado>();

        static void Main(string[] args)
        {   
            altaEmpleado();  

            mostrarLista();
        }

        private static void mostrarLista()
        {
            var empleados = from e in listaEmpleados orderby e.Sueldo ascending select e;

            Console.Clear();
            Console.WriteLine(String.Format("{0,-5} {1,30} {2,15}", "ID", "NOMBRE", "SUELDO"));
            foreach (Empleado e in empleados)
            {
                Console.WriteLine(String.Format("{0,-5} {1,30} {2,15}", e.Id.ToString(), e.Nombre, e.Sueldo.ToString()));
            }
        }

        private static void altaEmpleado()
        {
            string nombre;
            do
            {
                Console.Write("Ingrese el nombre de un empleado (0 para finalizar): ");
                nombre = Console.ReadLine();

                if (nombre.Equals("0")) break;

                listaEmpleados.Add(new Empleado(id++, nombre, verificaSueldo()));
                
                Console.Clear();
            } while (true);
        }

        private static float verificaSueldo()
        {
            float sueldo = 0;

            do
            {
                Console.Write("\n\nIngrese el sueldo del empleado: ");
                try
                {
                    sueldo = float.Parse(Console.ReadLine());
                    if (sueldo < 0) throw new Exception();
                    break;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("El sueldo ingresado tiene demasiados digitos.");
                }
                catch (Exception)
                {
                    Console.WriteLine("El sueldo solo puede ser un numero positivo.");
                }
            } while (true);

            return sueldo;
        }
    }

    class Empleado
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public float Sueldo { get; set; }

        public Empleado(int id, String nombre, float sueldo)
        {
            Id = id;
            Nombre = nombre;
            Sueldo = sueldo;
        }
    }
}

using System;
using System.Linq;
using System.Collections;

namespace Ciudades
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList ciudades = new ArrayList();
            ciudades.Add(new Ciudad { Codigo = "2000", Nombre = "Rosario" });
            ciudades.Add(new Ciudad { Codigo = "2138", Nombre = "Carcaraña" });
            ciudades.Add(new Ciudad { Codigo = "2630", Nombre = "Firmat" });
            ciudades.Add(new Ciudad { Codigo = "2440", Nombre = "Sastre" });
            ciudades.Add(new Ciudad { Codigo = "2520", Nombre = "LasRosas" });

            Console.Write("Ingrese una expresion de 3 caracteres: ");
            String exp = Console.ReadLine();

            //var ciudadesExp = ciudades.Where(c => c.Nombre.Contains(exp));

            var ciudadesExp = from Ciudad c in ciudades
                               where c.Nombre.ToLower().Contains(exp.ToLower())
                               select c.Codigo; 

            foreach (var ciudad in ciudadesExp)
            {
                Console.WriteLine(ciudad);
            }
        }
    }
    class Ciudad
    {
        public String Codigo { get; set; }
        public String Nombre { get; set; }
    }
}

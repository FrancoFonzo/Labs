using System;

namespace LabSintaxis2._4._5
{
    class Program
    {
        
        static void Main(string[] args)
        {
            /* Construir una aplicación que reciba el nombre de un mes del año 
             * como el parámetro y proporcione su número correspondiente. 
             * Debe ser con el formato: < Nombre del mes > + < número del mes >.
             */

            String[] meses = { "enero", "febrero", "marzo", "abril", "mayo", "junio", "julio", "agosto", "septiembre", "octubre", "noviembre", "diciembre"};
            String mes;         

            Console.Write("Ingrese nombre del mes: ");
            mes = Console.ReadLine();

            for (int i = 0; i < meses.Length; i++)
            {
                if (mes.Equals(meses[i], StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"El mes {mes} es el numero {i + 1}");
                    return;
                }
            }
            Console.WriteLine("Mes inexistente");
        }
    }
}

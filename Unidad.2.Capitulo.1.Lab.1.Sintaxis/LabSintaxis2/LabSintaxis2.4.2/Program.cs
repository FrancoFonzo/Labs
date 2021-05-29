using System;

namespace LabSintaxis2._4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Crear una aplicacion que te pida un año y verifique si el año es bisiesto o no.

            Observación: Un año es bisiesto si es divisible por 4, excepto el último de cada siglo(aquel divisible por 100),
            salvo que éste último sea divisible por 400.Es decir los años que sean divisibles por 4 serán bisiestos;
            aunque no serán bisiestos si son divisibles entre 100(como los años 1700, 1800, 1900 y 2100) a no ser
            que sean divisibles por 400(como los años 1600, 2000 ó 2400))
            */

            Console.WriteLine("Ingrese un año: ");
            int año = int.Parse(Console.ReadLine());

            if (año % 4 != 0)
            {
                Console.WriteLine($"El año {año} no es bisiesto");
                return;
            }
            if (año % 100 == 0 && año % 400 != 0)
            {
                Console.WriteLine($"El año {año} no es bisiesto");
                return;
            }
            Console.WriteLine($"El año {año} es bisiesto");
        }
    }
}

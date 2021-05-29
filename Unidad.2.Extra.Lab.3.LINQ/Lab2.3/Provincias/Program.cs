using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;


namespace Provincias
{
    class Program
    {
        static void Main(string[] args)
        {

            var provincias = new String[]{"Buenos Aires", "Catamarca", "Chaco", "Chubut", "Cordoba", "Corrientes", "Entre Rios", "Formosa",
                "Jujuy", "La Pampa", "La Rioja", "Mendoza", "Misiones", "Neuquen", "Rio Negro", "Salta", "San Juan",
                "San Luis", "Santa Cruz", "Santa Fe", "Santiago del Estero", "Tierra del Fuego", "Tucuman" };

            var provinciasST = provincias.Where(p => p.StartsWith("T") || p.StartsWith("S"));

            //var provinciasST = from p in provincias
            //                    where p.StartsWith("S") || p.StartsWith("T") select p;

            foreach (var p in provinciasST)
            {
                Console.WriteLine(p);
            }     
        }
    }

    
}

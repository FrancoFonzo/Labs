using System;

namespace LabSintaxis2._4._6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dado un número entero, que se convierta a número romano.
                       
            Console.Write("Ingrese un numero: ");
            int numEntero = int.Parse(Console.ReadLine());

            if (numEntero < 1 || numEntero > 4999)
            {
                Console.WriteLine("Has ingresado un valor fuera del rango de valores validos (1-4999)");
                return;
            }

            int milesima = numEntero / 1000;
            int resto = numEntero % 1000;

            int centesima = resto / 100;
            resto = resto % 100;

            int decima = resto / 10;
            resto = resto % 10;

            int unidad = resto;

            switch (milesima)
            {
                case 1: Console.Write("M"); break;
                case 2: Console.Write("MM"); break;
                case 3: Console.Write("MMM"); break;
            }
            switch (centesima)
            {
                case 1: Console.Write("C"); break;
                case 2: Console.Write("CC"); break;
                case 3: Console.Write("CCC"); break;
                case 4: Console.Write("CD"); break;
                case 5: Console.Write("D"); break;
                case 6: Console.Write("DC"); break;
                case 7: Console.Write("DCC"); break;
                case 8: Console.Write("DCCC"); break;
                case 9: Console.Write("CM"); break;
            }
            switch (decima)
            {
                case 1: Console.Write("X"); break;
                case 2: Console.Write("XX"); break;
                case 3: Console.Write("XXX"); break;
                case 4: Console.Write("XL"); break;
                case 5: Console.Write("L"); break;
                case 6: Console.Write("LX"); break;
                case 7: Console.Write("LXX"); break;
                case 8: Console.Write("LXXX"); break;
                case 9: Console.Write("XC"); break;
            }
            switch (unidad)
            {
                case 1: Console.Write("I"); break;
                case 2: Console.Write("II"); break;
                case 3: Console.Write("III"); break;
                case 4: Console.Write("IV"); break;
                case 5: Console.Write("V"); break;
                case 6: Console.Write("VI"); break;
                case 7: Console.Write("VII"); break;
                case 8: Console.Write("VIII"); break;
                case 9: Console.Write("IX"); break;
            }
        }
    }
}

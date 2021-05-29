using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdivinaNumero
{
    public class JugadaConAyuda : Jugada
    {
        public JugadaConAyuda(int maxNumero) : base(maxNumero)
        {

        }

        public override bool Comparar(int numero)
        {
            if (base.Comparar(numero)) return true;

            int diferencia = Math.Abs(Numero - numero);

            if (Numero > numero) Console.Write("El numero es mayor ");
            else Console.Write("El numero es menor "); 

            if (diferencia > 99) Console.Write("y esta muy lejos.");
            else if (diferencia < 6) Console.Write("y esta muy cerca.");

            Console.WriteLine();

            return false;

        }

    }
}
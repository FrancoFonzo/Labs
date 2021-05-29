using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdivinaNumero
{
    public class Jugada
    {
        //private bool _adivino = false;
        //private int _intentos = 0;
        //private int _numero;

        public Jugada(int maxNumero)
        {
            Random rnd = new Random();
            Numero = rnd.Next(maxNumero);
        }

        public bool Adivino { get; set; } = false;

        public int Intentos { get; set; } = 0;

        public int Numero { get; set;}

        public virtual bool Comparar(int numero)
        {
            Intentos++;

            if (Numero != numero) return false;

            Adivino = true;
            return true;
            
        }
    }
}

using System;
using static System.Console;
using Clases;

namespace LabClases1
{
    class Program
    {
        static void Main(string[] args)
        {
            A aInstancia = new A();
            B bInstancia = new B();

            aInstancia.M1();
            aInstancia.M2();
            aInstancia.M3();
            aInstancia.MostrarNombre();

            bInstancia.M4();

        }
    }
}

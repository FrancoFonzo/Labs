using System;
using static System.Console;

namespace Clases
{
    public class A
    {
        public string NombreInstancia { get; set; }

        public A() => this.NombreInstancia = "Instancia sin nombre";

        public A(String nombre) => this.NombreInstancia = nombre;

        public void MostrarNombre() => WriteLine($"Nombre de la isntancia: {NombreInstancia}");
        public void M1() => WriteLine("Invocaste al metodo M1");
        public void M2() => WriteLine("Invocaste al metodo M2");
        public void M3() => WriteLine("Invocaste al metodo M3");
    }
}

using System;

namespace Clases
{
    public class B : A
    {
        public B() : base("Instancia de B")
        {

        }

        public void M4() => Console.WriteLine("Metodo del hijo invocado");
    }
}
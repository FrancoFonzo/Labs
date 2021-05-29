using System;

namespace LabSintaxis2._4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Construir una aplicación que sume dos números y proporcione el resultado 
             *  con el formato siguiente: El resultado de la suma de < número uno > y < número dos > es < resultado >.*/

            Console.Write("Ingrese un numero: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("\nIngrese otro numero: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nEl resultado de la suma de {num1} y {num2} es {num1 + num2}");
        }
    }
}

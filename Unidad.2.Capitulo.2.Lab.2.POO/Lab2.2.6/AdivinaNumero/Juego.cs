using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdivinaNumero
{
    public class Juego
    {
        private static int _record = 0;

        public Juego()
        {
        }

        public static int Record
        {
            get => _record;
            set => _record = value;
        }

        public static void ComenzarJuego()
        {          
            do
            {
                int opc = Menu();
                if (opc == 3) return;

                Console.Clear();

                Jugada jugada = InstaciarJugada(opc);

                do
                {
                    jugada.Comparar(PreguntarNumero());

                    if(!(jugada.Adivino) && (jugada.Intentos != 3)) 
                        Console.WriteLine($"El numero es incorrecto. Tienes {3 - jugada.Intentos} intentos restantes.");

                } while (!(jugada.Adivino) && (jugada.Intentos < 3));

                if (jugada.Adivino)
                {
                    if (CompararRecord(jugada.Intentos))
                        Console.WriteLine($"Felicidades! Has acertado marcando un nuevo record con {jugada.Intentos} intentos.");
                    else Console.WriteLine($"Felicidades! Has acertado con {jugada.Intentos} intentos");

                }
                else Console.WriteLine("Has gastado todos tus intentos! Puedes intentarlo nuevamente en un nuevo juego!");

            } while (Continuar());
        }

        private static Jugada InstaciarJugada(int opc)
        {
            if (opc == 1)
            {
                MostrarCentrado("| Adivina el numero sin ayudas|\n");
                return new Jugada(PreguntarMaximo());
            }
            MostrarCentrado("| Adivina el numero con ayudas|\n");
            return new JugadaConAyuda(PreguntarMaximo());
        }

        private static int Menu()
        {
            int opc = 3;
            do
            {
                try
                {
                    Console.Clear();

                    Console.WriteLine("1) Juego sin ayudas \n2) Juego con ayudas \n3) Salir");
                    Console.Write("\nIngrese opcion: ");
                    opc = int.Parse(Console.ReadLine());
                    if (opc < 1 && opc > 3) throw new ArgumentOutOfRangeException();
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Debe ingresar obligatoriamente uno de los números del menu .\n");
                }

            } while (true);
            return opc;
        }

        private static void MostrarCentrado(string mensaje)
        {
            int align = (Console.WindowWidth / 2) + mensaje.Length / 2;
            Console.WriteLine($"{{0,{align}}}", mensaje); 
            // Console.WriteLine("{indiceArgumento, tamañoAlign}", mensaje); => tamañoAlign siendo la mitad del ancho de la consola + la mitad del mensaje
        }

        private static bool CompararRecord(int intentos)
        {
            if((intentos >= _record) && (_record != 0)) return false;
            Record = intentos;
            return true;
        }

        private static bool Continuar()
        {
            Console.Write("\nDeasea jugar otra vez? (S/N): ");

            if (Console.ReadLine().ToUpper().Equals("N")) return false;
            return true;
        }

        private static int PreguntarMaximo()
        {

            do
            {
                try
                {
                    Console.Write("Ingrese un numero maximo: ");
                    int max = int.Parse(Console.ReadLine());
                    if (max <= 0) throw new ArgumentOutOfRangeException();
                    return max;
                }
                catch (ArithmeticException)
                {
                    Console.WriteLine("El numero ingresado es muy grande.\n");
                    Console.WriteLine();
                }
                catch (Exception)
                {
                    Console.WriteLine("Debe ingresar obligatoriamente un número entero positivo.\n");
                }
            } while (true);
        }

        private static int PreguntarNumero()
        {
            do
            {
                try
                {
                    Console.Write("\nIngrese un numero: ");
                    int num = int.Parse(Console.ReadLine());
                    return num;
                }
                catch (ArithmeticException)
                {
                    Console.WriteLine("El numero ingresado es muy grande.\n");
                }
                catch (Exception)
                {
                    Console.WriteLine("\nDebe ingresar obligatoriamente un número entero.");
                }
            } while (true);    
        }
    }
}

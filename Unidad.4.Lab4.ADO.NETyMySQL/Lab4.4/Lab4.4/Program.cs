using System;

namespace Lab4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            ManejadorContactos manejadorContactos;
            Console.WriteLine("Elija el modo:");
            Console.WriteLine("1 - TXT");
            Console.WriteLine("2 - XML");
            Console.WriteLine("3 - MySQL");
            string opc = Console.ReadLine();
            if (opc == "2")
            {
                manejadorContactos = new ManejadorArchivoXml();
            }
            else if (opc == "1")
            {
                manejadorContactos = new ManejadorArchivoTxt();
            }
            else
            {
                manejadorContactos = new ContactosMysqlConDataAdapter();
            }
            manejadorContactos.listar();
            menu(manejadorContactos);
        }

        static void menu(ManejadorContactos manejadorContactcos)
        {
            string rta = "";
            do
            {
                Console.WriteLine("1 - Listar");
                Console.WriteLine("2 - Agregar");
                Console.WriteLine("3 - Modificar");
                Console.WriteLine("4 - Eliminar");
                Console.WriteLine("5 - Guardar Cambios");
                Console.WriteLine("6 - Salir");
                rta = Console.ReadLine();
                switch (rta)
                {
                    case "1":
                        manejadorContactcos.listar();
                        break;
                    case "2":
                        manejadorContactcos.nuevaFila();
                        break;
                    case "3":
                        manejadorContactcos.editarFila();
                        break;
                    case "4":
                        manejadorContactcos.eliminarFila();
                        break;
                    case "5":
                        manejadorContactcos.aplicaCambios();
                        break;
                    default:
                        break;
                }
            } while (rta != "6");
        }

    }
}

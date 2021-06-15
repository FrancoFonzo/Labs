using System;
using System.IO;
using System.Xml;

namespace Lab4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            archivo texto plano.
            leer();
            escribir();
            leer();
            */
            Console.WriteLine("Presione una tecla para generar el archivo agendaxml.xml" +
                " con los datos de agenda.txt");
            Console.ReadKey();
            escribirXML();
            Console.WriteLine("\nArchivo agendaxml.xml generado correctamente.\n\n" +
                "Presione una tecla para ver su contenido.");
            Console.ReadKey();
            Console.Clear();
            leerXML();
            Console.WriteLine();
            Console.ReadKey();            
        }

        private static void leer()
        {
            StreamReader lector = File.OpenText("agenda.txt");
            string linea;
            Console.WriteLine("Nombre\tApellido\tEmail\t\t\tTelefono");

            do
            {
                linea = lector.ReadLine();
                if (linea != null)
                {
                    string[] valores = linea.Split(';');
                    Console.WriteLine($"{valores[0]}\t{valores[1]}\t{valores[2]}\t{valores[3]}");
                }
            } while (linea != null);

            lector.Close();
        }

        private static void escribir()
        {
            Console.ReadKey();
            Console.Clear();
            StreamWriter escritor = File.AppendText("agenda.txt");
            Console.WriteLine("Ingrese nuevo contacto");

            string rta = "S";

            while (rta.Equals("s", StringComparison.OrdinalIgnoreCase))
            {
                Console.Write("\nIngrese nombre: ");
                string nombre = Console.ReadLine();
                Console.Write("\nIngrese apellido: ");
                string apellido = Console.ReadLine();
                Console.Write("\nIngrese email: ");
                string email = Console.ReadLine();
                Console.Write("\nIngrese telefono: ");
                string telefono = Console.ReadLine();
                Console.WriteLine();
            
                escritor.WriteLine($"{nombre};{apellido};{email};{telefono}");

                Console.Write("Desea ingresar otro contacto? (S/N): ");
                rta = Console.ReadLine();
            }
            escritor.Close();
        }

        private static void escribirXML()
        {
            XmlWriter escritorXML = new XmlTextWriter("agendaxml.xml", null) { Formatting = Formatting.Indented};
            escritorXML.WriteStartDocument(true);
            escritorXML.WriteStartElement("DocumentElement");
            StreamReader lector = File.OpenText("agenda.txt");

            string linea;
            do
            {
                linea = lector.ReadLine();
                if (linea != null)
                {
                    string[] valores = linea.Split(';');
                    escritorXML.WriteStartElement("contactos");
                    escritorXML.WriteStartElement("nombre");
                    escritorXML.WriteValue(valores[0]);
                    escritorXML.WriteEndElement();
                    escritorXML.WriteStartElement("apellido");
                    escritorXML.WriteValue(valores[1]);
                    escritorXML.WriteEndElement();
                    escritorXML.WriteStartElement("email");
                    escritorXML.WriteValue(valores[2]);
                    escritorXML.WriteEndElement();
                    escritorXML.WriteStartElement("telefono");
                    escritorXML.WriteValue(valores[3]);
                    escritorXML.WriteEndElement();
                    escritorXML.WriteEndElement();
                }
            } while (linea != null);
            escritorXML.WriteEndElement();
            escritorXML.WriteEndDocument();

            escritorXML.Close();
        }

        private static void leerXML()
        {
            XmlReader lectorXML = new XmlTextReader("agendaxml.xml");
            string tagAnterior = "";

            while (lectorXML.Read())
            {
                if (lectorXML.NodeType == XmlNodeType.Element)
                {
                    tagAnterior = lectorXML.Name;
                    Console.WriteLine();
                }
                else if (lectorXML.NodeType == XmlNodeType.Text)
                {
                    Console.Write($"{tagAnterior} : {lectorXML.Value}");
                }
            }

            lectorXML.Close();
        }
    }
}

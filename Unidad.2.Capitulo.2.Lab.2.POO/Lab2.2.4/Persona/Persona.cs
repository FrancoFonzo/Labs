using System;

namespace Persona
{
    public class Persona
    {
        private String _nombre;
        private String _apellido;
        private String _dni;
        private int _edad;

        public Persona(String nombre, String apellido, String dni, int edad)
        {
            Nombre = nombre;
            Apellido = apellido;
            DNI = dni;
            Edad = edad;

            Console.WriteLine("Se ha creado el objeto correctamente");
        }

        ~Persona()
        {
            Console.WriteLine("Se ha destruido el objeto correctamente");
        }

        public String Nombre
        {
            get => this._nombre;
            set => this._nombre = value;
        }

        public String Apellido
        {
            get => this._apellido;
            set => this._apellido = value;
        }

        public int Edad
        {
            get => this._edad;
            set => this._edad = value;
        }

        public String DNI
        {
            get => this._dni;
            set => this._dni = value;
        }

        public String GetFullName()
        {
            return $"{Nombre}{Apellido}";
        }
        public int GetEdad()
        {
            return Edad;
        }
    }
}

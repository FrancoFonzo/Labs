using System;
using System.Data;
using System.Data.SqlClient;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataTable dtAlumnos = new DataTable();
            DataRow rwAlumno = dtAlumnos.NewRow();

            DataColumn dtColNombre = new DataColumn("Nombre");
            DataColumn dtColApellido = new DataColumn("Apellido");

            dtAlumnos.Columns.Add(dtColNombre);
            dtAlumnos.Columns.Add(dtColApellido);

            rwAlumno[dtColNombre] = "Franco";
            rwAlumno[dtColApellido] = "Fonzo";

            dtAlumnos.Rows.Add(rwAlumno);

            DataRow rwAlumno2 = dtAlumnos.NewRow();
            rwAlumno2[dtColNombre] = "Danny";
            rwAlumno2[dtColApellido] = "Carey";
            dtAlumnos.Rows.Add(rwAlumno2);

            DataRow rwAlumno3 = dtAlumnos.NewRow();
            rwAlumno3[dtColNombre] = "Mario";
            rwAlumno3[dtColApellido] = "Duplantier";
            dtAlumnos.Rows.Add(rwAlumno3);

            Console.WriteLine("Listado de Alumnos\n");

            foreach (DataRow rw in dtAlumnos.Rows)
            {
                Console.WriteLine($"{rw.Field<String>(dtColApellido)}, " +
                    $"{rw.Field<String>(dtColNombre)}");
            }
            Console.ReadKey();
        }

    }
}

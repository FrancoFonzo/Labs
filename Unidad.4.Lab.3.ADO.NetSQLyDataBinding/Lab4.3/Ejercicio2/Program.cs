using System;
using System.Data;
using System.Data.SqlClient;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataTable dtAlumnos = new DataTable("Alumnos");

            DataColumn colIdAlumno = new DataColumn("ID", typeof(int))
            {
                ReadOnly = true,        
                AutoIncrement = true,
                AutoIncrementSeed = 0,
                AutoIncrementStep = 1
            };
            DataColumn colNombreAlumno = new DataColumn("Nombre", typeof(string));
            DataColumn colApellidoAlumno = new DataColumn("Apellido", typeof(string));

            dtAlumnos.Columns.Add(colIdAlumno);
            dtAlumnos.Columns.Add(colNombreAlumno);
            dtAlumnos.Columns.Add(colApellidoAlumno);

            // La PK puede estar formada por varios atributos,
            // por lo que pide un arreglo de columnas
            dtAlumnos.PrimaryKey = new DataColumn[] { colIdAlumno };

            DataRow rwAlumno = dtAlumnos.NewRow();
            rwAlumno[colNombreAlumno] = "Franco";
            rwAlumno[colApellidoAlumno] = "Fonzo";

            dtAlumnos.Rows.Add(rwAlumno);

            DataRow rwAlumno2 = dtAlumnos.NewRow();
            rwAlumno2[colNombreAlumno] = "Danny";
            rwAlumno2[colApellidoAlumno] = "Carey";
            dtAlumnos.Rows.Add(rwAlumno2);

            DataRow rwAlumno3 = dtAlumnos.NewRow();
            rwAlumno3[colNombreAlumno] = "Mario";
            rwAlumno3[colApellidoAlumno] = "Duplantier";
            dtAlumnos.Rows.Add(rwAlumno3);

            DataTable dtCursos = new DataTable("Cursos");

            DataColumn colIdCurso = new DataColumn("ID", typeof(int)) 
            {
                ReadOnly = true,
                AutoIncrement = true,
                AutoIncrementSeed = 0,
                AutoIncrementStep = 1
            };
            DataColumn colCurso = new DataColumn("Curso", typeof(string));

            dtCursos.Columns.Add(colIdCurso);
            dtCursos.Columns.Add(colCurso);

            dtCursos.PrimaryKey = new DataColumn[] { colIdCurso };

            DataRow rwCurso = dtCursos.NewRow();
            rwCurso[colCurso] = ".NET";
            dtCursos.Rows.Add(rwCurso);

            DataSet dsUniversidad = new DataSet("Universidad");
            dsUniversidad.Tables.Add(dtCursos);
            dsUniversidad.Tables.Add(dtAlumnos);

            // Realcion: dtCursos  1:N  ------  0:M  dtAlumnos
            DataTable dtCursosAlumnos = new DataTable("CursosAlumno");

            DataColumn colCAIdCurso = new DataColumn("IDCurso", typeof(int));
            DataColumn colCAIdAlumno = new DataColumn("IDAlumno", typeof(int));
            dtCursosAlumnos.Columns.Add(colCAIdAlumno);
            dtCursosAlumnos.Columns.Add(colCAIdCurso);

            dsUniversidad.Tables.Add(dtCursosAlumnos);

            DataRelation relAlumnoAC = 
                new DataRelation("AlumnoCursos", colIdAlumno, colCAIdAlumno);
            DataRelation relCursoAC =
                new DataRelation("CursoAlumnos", colIdCurso, colCAIdCurso);
            dsUniversidad.Relations.Add(relAlumnoAC);
            dsUniversidad.Relations.Add(relCursoAC);

            DataRow rwCursosAlumnos = dtCursosAlumnos.NewRow();
            rwCursosAlumnos[colCAIdAlumno] = 0; //Alumno: Franco Fonzo
            rwCursosAlumnos[colCAIdCurso] = 0;  //Curso: .NET
            dtCursosAlumnos.Rows.Add(rwCursosAlumnos);

            rwCursosAlumnos = dtCursosAlumnos.NewRow();
            rwCursosAlumnos[colCAIdAlumno] = 1; //Alumno: Danny Carey
            rwCursosAlumnos[colCAIdCurso] = 0;  //Curso: .NET
            dtCursosAlumnos.Rows.Add(rwCursosAlumnos);

            rwCursosAlumnos = dtCursosAlumnos.NewRow();
            rwCursosAlumnos[colCAIdAlumno] = 2; //Alumno: Mario Duplantier
            rwCursosAlumnos[colCAIdCurso] = 0;  //Curso: .NET
            dtCursosAlumnos.Rows.Add(rwCursosAlumnos);

            Console.Write("Ingrese nombre del curso: ");
            string curso = Console.ReadLine();
            Console.WriteLine($"\nListado de alumnos del curso {curso}\n");
            DataRow[] rowCursos = dtCursos.Select($"Curso = '{curso}'");

            foreach (DataRow rowCurso in rowCursos)
            {
                DataRow[] rowAlumnos = rowCurso.GetChildRows(relCursoAC);
                foreach (DataRow rowAlumno in rowAlumnos)
                {
                    Console.WriteLine(
                        $"{rowAlumno.GetParentRow(relAlumnoAC)[colApellidoAlumno].ToString()}" +
                        $", " +
                        $"{rowAlumno.GetParentRow(relAlumnoAC)[colNombreAlumno].ToString()}"
                        );
                }
            }
        }
    }
}

using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            dsUniversidad miUniversidad = new dsUniversidad();
            dsUniversidad.dtAlumnosDataTable dtAlumnos = new dsUniversidad.dtAlumnosDataTable();
            dsUniversidad.dtCursosDataTable dtCursos = new dsUniversidad.dtCursosDataTable();

            dsUniversidad.dtAlumnosRow rowAlumno = dtAlumnos.NewdtAlumnosRow();

            rowAlumno.Apellido = "Fonzo";
            rowAlumno.Nombre = "Franco";
            dtAlumnos.AdddtAlumnosRow(rowAlumno);

            dsUniversidad.dtCursosRow rowCurso = dtCursos.NewdtCursosRow();
            rowCurso.Curso = ".NET";
            dtCursos.AdddtCursosRow(rowCurso);

            dsUniversidad.dtAlumnos_CursosDataTable dtAlumnos_Cursos = new dsUniversidad.dtAlumnos_CursosDataTable();

            dsUniversidad.dtAlumnos_CursosRow rowdtAlumnos_Cursos = dtAlumnos_Cursos.NewdtAlumnos_CursosRow();

            dtAlumnos_Cursos.AdddtAlumnos_CursosRow(rowAlumno, rowCurso);

            rowAlumno = dtAlumnos.NewdtAlumnosRow();
            rowAlumno.Nombre = "Mario";
            rowAlumno.Apellido = "Duplantier";
            dtAlumnos.AdddtAlumnosRow(rowAlumno);

            dtAlumnos_Cursos.AdddtAlumnos_CursosRow(rowAlumno, rowCurso);
        }
    }
}

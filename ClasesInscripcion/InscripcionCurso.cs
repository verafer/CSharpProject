using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesInscripcion
{
    public class InscripcionCurso
    {

        public Alumno Alumno { get; set; }
        public Curso curso { get; set; }
        public int[] examenes { get; set; }

        public InscripcionCurso() { }

        public static List<Curso> ObtenerCursosDeAlumno(Alumno alumno)
        {
            List<Curso> listaCursosDelAlumno = new List<Curso>();
            foreach (Curso c in Curso.ObtenerCursos())
            {
                if (c.listaAlumnos.Contains(alumno))
                {
                    listaCursosDelAlumno.Add(c);
                }
            }
            return listaCursosDelAlumno;
        }
        public static void AgregarInscripto(Alumno alumno, Curso Curso)
        {
            Curso.listaAlumnos.Add(alumno);
        }
        public static void RemoverInscripto(Alumno alumno, Curso Curso)
        {
            Curso.listaAlumnos.Remove(alumno);
        }
        public static void EditarInscrpcion(Curso c, int indice)
        {
           // Inscripcion.listaCurso[indice] = c;

        }

    }
}

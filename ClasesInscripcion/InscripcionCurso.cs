using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesInscripcion
{
    public class InscripcionCurso
    {

        public Alumno Alumno { get; set; }
        public Curso Curso { get; set; }
        public int[] examenes { get; set; }

        public InscripcionCurso() { }

        public InscripcionCurso(Alumno a,Curso c) {
            this.Alumno = a;
            this.Curso = c;
        }

        public static List<InscripcionCurso> ObtenerCursosDeAlumno(Alumno alumno)
        {
            List<InscripcionCurso> listaCursosDelAlumno = new List<InscripcionCurso>();
            foreach (Curso c in Curso.ObtenerCursos())
            {
                foreach (InscripcionCurso ic in c.listaInscriptos)
                {
                    if (alumno == ic.Alumno)
                    {
                        listaCursosDelAlumno.Add(ic);
                    }
                }
            }
            return listaCursosDelAlumno;
        }
        public static void AgregarInscripto(InscripcionCurso i, Curso Curso)
        {
            Curso.listaInscriptos.Add(i);
        }
        public static void RemoverInscripto(InscripcionCurso i, Curso Curso)
        {
            Curso.listaInscriptos.Remove(i);
        }
        public static void EditarInscrpcion(Curso c, int indice)
        {
           // Inscripcion.listaCurso[indice] = c;

        }

        public override string ToString()
        {
            if(Curso.Materia != null)
            {
                return $"{Curso.numeroCurso} - { Curso.Materia}";
            }
            else
            {
                return $"{Curso.numeroCurso}";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesInscripcion
{
    public enum EstadoInscripcion
    {
        Pendiente,
        Confirmada
    }
    public class InscripcionCurso
    {

        public Alumno Alumno { get; set; }
        public Curso Curso { get; set; }
        public EstadoInscripcion Estado { get; set; }

        public InscripcionCurso() { }

        public InscripcionCurso(Alumno a,Curso c) {
            this.Alumno = a;
            this.Curso = c;
            this.Estado = EstadoInscripcion.Pendiente;
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
        public static void RemoverInscripto(InscripcionCurso i)
        {
            i.Curso.listaInscriptos.Remove(i);
        }
        public static void EditarInscrpcion(Curso c, int indice)
        {
           // Inscripcion.listaCurso[indice] = c;

        }

        public override string ToString()
        {
            string texto = "";
            if(Curso.Materia != null)
            {
                texto += $"{Curso.NumeroCurso} - { Curso.Materia} , Dia: { Curso.Dia }";
            }
            else
            {
                texto += $"{Curso.NumeroCurso}";
            }
            if (Estado == EstadoInscripcion.Pendiente)
                texto += "  (Inscripсión Pendiente)";
            return texto;
        }
    }
}

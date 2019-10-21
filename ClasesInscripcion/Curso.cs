using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesInscripcion
{
    public enum Modalidad
    {
        Presencial, 
        Distancia
    }
    public enum Turnos
    {
        Mañana,
        Tarde,
       Noche
    }
    public class Curso : Objeto
    {  
        public string numeroCurso { get; set; }
        public Materia Materia { get; set; }
        public Turnos Turno { get; set; }
        public Profesor Profesor { get; set; }
        public Modalidad modalidad { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public List<InscripcionCurso> listaInscriptos = new List<InscripcionCurso>();

        public static List<Curso> listaCurso = new List<Curso>();


        public Curso() {
        }
        public override string ToString()
        {
            return this.numeroCurso + " " + this.Materia; 
        }
        public string ObtenerDatosCurso()
        {
            return numeroCurso;
        }

        public static void AgregarCurso(Curso c)
        {
            listaCurso.Add(c);
        }

        public static void EditarCurso(Curso c, int indice)
        {
            Curso.listaCurso[indice] = c;

        }
        public static void EliminarCurso(Curso curso)
        {
            listaCurso.Remove(curso);
        }

        public static List<Curso> ObtenerCursos()
        {
            return listaCurso;
        }
        public void BajaCurso() { }
    }
}

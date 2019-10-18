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
    public class Curso : Objeto
    {  
        public Materia Materia { get; set; }
        public Turno Turno { get; set; }
        public Profesor Profesor { get; set; }
        public Modalidad modalidad { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public static List<Curso> listaCurso = new List<Curso>();


        public Curso() {
        }
        public override string ToString()
        {
            return $"Nro Curso: {Id} Materia: {Materia.Descripcion} Profesor: {Materia.Profesor} Turno: {Turno}";
        }
        public string ObtenerDatosCurso()
        {
            return $"nro curso{Id} {Materia.Descripcion} Profesor: {Materia.Profesor} Turno: {Turno} {modalidad} Fecha Inicio: {FechaInicio} Fecha Fin:{FechaFin} ";
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

using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesInscripcion
{
    public enum modalidad
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
    public enum DiasSemana
    {L,M,X,J,V,S}
    public class Curso : Objeto
    {  
        public string NumeroCurso { get; set; }
        public Materia Materia { get; set; }
        public DiasSemana Dia { get; set; }
        public Turnos Turno { get; set; }
        public Profesor Profesor { get; set; }
        public modalidad Modalidad { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int MontoTotal { get; set; }
        public List<InscripcionCurso> listaInscriptos = new List<InscripcionCurso>();

        public static List<Curso> listaCurso = new List<Curso>();


        public Curso() {
        }

        public Curso(string numeroCurso, Materia materia,DiasSemana dia, Turnos turno, Profesor profesor, modalidad Modalidad,
          DateTime fechaInicio, DateTime fechaFin)
        {
            this.NumeroCurso = numeroCurso;
            this.Materia = materia;
            this.Dia = dia;
            this.Turno = turno;
            this.Profesor = profesor;
            this.Modalidad = Modalidad;
            this.FechaInicio = fechaInicio;
            this.FechaFin = fechaFin;
            this.MontoTotal = 1500000;
        }

        public override string ToString()
        {
            return this.NumeroCurso + " " + this.Materia + ", Dia: " + Dia.ToString(); 
        }
        public string ObtenerDatosCurso()
        {
            return NumeroCurso;
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

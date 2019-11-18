using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    public enum DiasSemana
    {L,M,X,J,V,S}
    public class Curso : Objeto
    {  
        public string NumeroCurso { get; set; }
        public Materia Materia { get; set; }
        public DiasSemana Dia { get; set; }
        public Turnos Turno { get; set; }
        public Profesor Profesor { get; set; }
        public Modalidad Modalidad { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int MontoTotal { get; set; }
        public List<InscripcionCurso> listaInscriptos = new List<InscripcionCurso>();

        public static List<Curso> listaCurso = new List<Curso>();


        public Curso() {
        }

        public Curso(string numeroCurso, Materia materia,DiasSemana dia, Turnos turno, Profesor profesor, Modalidad Modalidad,
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
            //return listaCurso;
            Curso curso;
            listaCurso.Clear();
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open();
                string textoCMD = "Select * from Curso";

                SqlCommand cmd = new SqlCommand(textoCMD, con);

                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                while (elLectorDeDatos.Read())
                {
                    curso = new Curso();
                    curso.Id = elLectorDeDatos.GetInt32(0);
                    curso.NumeroCurso = elLectorDeDatos.GetString(1);
                    curso.Materia = Materia.ObtenerMateria(elLectorDeDatos.GetInt32(2));
                    curso.Dia = (DiasSemana)(Convert.ToInt32(elLectorDeDatos.GetString(3)));
                    curso.Turno = (Turnos)elLectorDeDatos.GetInt32(4);
                    curso.Profesor = Profesor.ObtenerProfesor(elLectorDeDatos.GetInt32(5));
                    curso.Modalidad = (Modalidad)(Convert.ToInt32(elLectorDeDatos.GetString(6)));
                    curso.FechaInicio = elLectorDeDatos.GetDateTime(7);
                    curso.FechaFin = elLectorDeDatos.GetDateTime(8);
                    curso.MontoTotal = elLectorDeDatos.GetInt32(9);

                    listaCurso.Add(curso);
                }

                return listaCurso;
            }
        }
        public void BajaCurso() { }
    }
}

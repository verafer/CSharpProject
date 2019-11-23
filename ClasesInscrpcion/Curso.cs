using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Data;

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
        public static void AgregarCurso(Curso c)
        {
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open();
                string textoCmd = "INSERT INTO Curso (numero_curso, materia, dia, turno, profesor, modalidad, fecha_inicio, fecha_fin,monto_total)VALUES (@numero_curso, @materia, @dia, @turno, @profesor, @modalidad, @fecha_inicio, @fecha_fin,@monto_total)";
                SqlCommand cmd = new SqlCommand(textoCmd, con);
                cmd = c.ObtenerParametros(cmd);
                cmd.ExecuteNonQuery();
            }
        }
        public static void EliminarCurso(Curso curso)
        {
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open();
                string SENTENCIA_SQL = "delete from Curso where Id = @curso_id";

                SqlCommand cmd = new SqlCommand(SENTENCIA_SQL, con);
                SqlParameter p1 = new SqlParameter("@curso_id", curso.Id);
                p1.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(p1);

                cmd.ExecuteNonQuery();
                con.Close();
            }
        }


        public static void EditarCurso(int index, Curso c)
        {

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCMD = "UPDATE Curso SET numero_curso = @numero_curso,materia= @materia,dia= @dia,turno= @turno,profesor= @profesor,modalidad=@modalidad, fecha_inicio= @fecha_inicio, fecha_fin= @fecha_fin,monto_total@monto_total where Id = @curso_id";

                SqlCommand cmd = new SqlCommand(textoCMD, con);
                cmd = c.ObtenerParametros(cmd, true);

                cmd.ExecuteNonQuery();
            }
        }

        public static Curso ObtenerCurso(int id)
        {
            Curso curso = null;

            if (listaCurso.Count == 0)
            {
                Curso.ObtenerCursos();
            }

            foreach (Curso c in listaCurso)
            {
                if (c.Id == id)
                {
                    curso = c;
                    break;
                }
            }

            return curso;
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

        private SqlCommand ObtenerParametros(SqlCommand cmd, Boolean id = false)

        {
            SqlParameter p1 = new SqlParameter("@numero_curso", this.NumeroCurso);
            SqlParameter p2 = new SqlParameter("@materia", this.Materia.Id);
            SqlParameter p3 = new SqlParameter("@dia", this.Dia);
            SqlParameter p4 = new SqlParameter("@turno", this.Turno);
            SqlParameter p5 = new SqlParameter("@profesor", this.Profesor.Id);
            SqlParameter p6 = new SqlParameter("@modalidad", this.Modalidad); //es el id del proveedor para obtener dicho valor
            SqlParameter p7 = new SqlParameter("@fecha_inicio", this.FechaInicio);
            SqlParameter p8 = new SqlParameter("@fecha_fin", this.FechaFin);
            SqlParameter p9 = new SqlParameter("@monto_total", this.MontoTotal);
            p1.SqlDbType = SqlDbType.VarChar;
            p2.SqlDbType = SqlDbType.Int;
            p3.SqlDbType = SqlDbType.VarChar;
            p4.SqlDbType = SqlDbType.VarChar;
            p5.SqlDbType = SqlDbType.Int;
            p6.SqlDbType = SqlDbType.VarChar;
            p7.SqlDbType = SqlDbType.DateTime;
            p8.SqlDbType = SqlDbType.DateTime;
            p9.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);
            cmd.Parameters.Add(p5);
            cmd.Parameters.Add(p6);
            cmd.Parameters.Add(p7);
            cmd.Parameters.Add(p8);
            cmd.Parameters.Add(p9);
            if (id == true)
            {
                cmd = ObtenerParametrosId(cmd);
            }
            return cmd;

        }

        //Obtenemos los dias de entrega separador por coma ","
      
        private SqlCommand ObtenerParametrosId(SqlCommand cmd)
        {
            SqlParameter p10 = new SqlParameter("@id", this.Id);
            p10.SqlDbType = SqlDbType.Int;
            cmd.Parameters.Add(p10);
            return cmd;
        }
        public void BajaCurso() { }
    }
}

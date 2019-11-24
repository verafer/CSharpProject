using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace ClasesInscripcion
{
    public enum EstadoInscripcion
    {
        Pendiente,
        Confirmada,
        Anulada
    }
    public class InscripcionCurso
    {

        public Alumno Alumno { get; set; }
        //public Curso Curso { get; set; }
        public EstadoInscripcion Estado { get; set; }
        public int Id { get; set; }
        public Curso Curso { get; set; }
        public float Precio { get; set; }
        //public Alumno alumno { get; set; }
        // EstadoInscripcion estado { get; set; }
        public DateTime FechaInscripcion { get; set; }

        public List<InscripcionCurso> listaDic = new List<InscripcionCurso>();
        public List<InscripcionCurso> listaDicGrilla = new List<InscripcionCurso>();

        //public static List<InscripcionCurso> listaInscripciones = new List<InscripcionCurso>();
        public static List<InscripcionCurso> listaInscripciones = new List<InscripcionCurso>();

        public InscripcionCurso() { }

        /*public InscripcionCurso(Alumno a) {
            this.Alumno = a;
            this.Estado = EstadoInscripcion.Pendiente;
        }*/


        public static void Agregar(InscripcionCurso i)
        {
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                //DETALLE
                foreach (InscripcionCurso dic in i.listaDic)
                {

                    //cabecera
                    string textoCMD = "INSERT INTO Inscripcion_Curso_Detalle (curso_id, precio,alumno, estado, fecha_inscripcion) VALUES (@curso_id, @precio, @alumno, @estado, @fecha_inscripcion)";
                    SqlCommand cmd = new SqlCommand(textoCMD, con);

                    //parametros
                    SqlParameter i1 = new SqlParameter("@curso_id", dic.Curso.Id);
                    SqlParameter i2 = new SqlParameter("@precio", dic.Precio);
                    SqlParameter i3 = new SqlParameter("@alumno", i.Alumno.Id);
                    SqlParameter i4 = new SqlParameter("@estado", i.Estado);
                    SqlParameter i5 = new SqlParameter("@fecha_inscripcion", DateTime.Now);

                    i1.SqlDbType = System.Data.SqlDbType.Int;
                    i2.SqlDbType = System.Data.SqlDbType.Float;
                    i3.SqlDbType = System.Data.SqlDbType.Int;
                    i4.SqlDbType = System.Data.SqlDbType.Int;
                    i5.SqlDbType = System.Data.SqlDbType.DateTime;

                    cmd.Parameters.Add(i1);
                    cmd.Parameters.Add(i2);
                    cmd.Parameters.Add(i3);
                    cmd.Parameters.Add(i4);
                    cmd.Parameters.Add(i5);

                    cmd.ExecuteNonQuery();
                    //int id_inscripcion_curso = (int)cmd.ExecuteScalar();
                }
            }
        }

        public static List<InscripcionCurso> ObtenerCursosDeAlumno(Alumno alumno)
        {
            InscripcionCurso icd;
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCMD = "SELECT * FROM Inscripcion_Curso_Detalle Where alumno = @id ";

                SqlCommand cmd = new SqlCommand(textoCMD, con);

                SqlParameter p1 = new SqlParameter("@id", alumno.Id);
                p1.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(p1);

                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                while (elLectorDeDatos.Read())
                {

                    icd = new InscripcionCurso();
                    icd.Id = elLectorDeDatos.GetInt32(0);
                    icd.Curso = Curso.ObtenerCurso(elLectorDeDatos.GetInt32(1));
                    //icd.Precio = elLectorDeDatos.GetFloat(2);
                    icd.Alumno = Alumno.ObtenerAlumno(elLectorDeDatos.GetInt32(3));
                    icd.Estado = (EstadoInscripcion)elLectorDeDatos.GetInt32(4);
                    icd.FechaInscripcion = elLectorDeDatos.GetDateTime(5);

                    //ciudad.Departamento = (Departamento)elLectorDeDatos.GetInt32(2);
                    listaInscripciones.Add(icd);
                    //MessageBox.Show(icd.ToString());
                }
                con.Close();
                return listaInscripciones;
            }
        }
        /*public static void AgregarInscripto(InscripcionCurso i, Curso Curso)
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
        }*/


    }
}

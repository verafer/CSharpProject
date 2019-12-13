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
        //public int Id { get; set; }
        //public Curso Curso { get; set; }
        //public float Precio { get; set; }
        //public Alumno alumno { get; set; }
        // EstadoInscripcion estado { get; set; }
        public DateTime FechaInscripcion { get; set; }

        //public List<InscripcionCurso> listaDic = new List<InscripcionCurso>();
        //public List<InscripcionCurso> listaDicGrilla = new List<InscripcionCurso>();

        //public static List<InscripcionCurso> listaInscripciones = new List<InscripcionCurso>();
        public static List<InscripcionCurso> listaInscripciones = new List<InscripcionCurso>();
        public List<InscripcionCursoDetalle> listaInscripcionesD = new List<InscripcionCursoDetalle>();
        public static List<InscripcionCursoDetalle> listaInscripcionesDe = new List<InscripcionCursoDetalle>();
        public static List<InscripcionCursoDetalle> listaCursosAlumno = new List<InscripcionCursoDetalle>();
        public static List<InscripcionCursoDetalle> listaCursosDisponible = new List<InscripcionCursoDetalle>();

        public InscripcionCurso() { }

        public static int Agregar(InscripcionCurso i)
        {
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                
                //cabecera
                string textoCMD = "INSERT INTO Inscripcion_Curso (alumno_id, estado, fecha_inscripcion) output INSERTED.inscripcion_curso_id VALUES (@alumno_id, @estado, @fecha_inscripcion)";
                SqlCommand cmd = new SqlCommand(textoCMD, con);

                //parametros
                SqlParameter i1 = new SqlParameter("@alumno_id", i.Alumno.Id);
                SqlParameter i2 = new SqlParameter("@estado", i.Estado);
                SqlParameter i3 = new SqlParameter("@fecha_inscripcion", DateTime.Now);


                i1.SqlDbType = SqlDbType.Int;
                i2.SqlDbType = SqlDbType.Int;
                i3.SqlDbType = SqlDbType.DateTime;
                cmd.Parameters.Add(i1);
                cmd.Parameters.Add(i2);
                cmd.Parameters.Add(i3);
                
                int id_inscripcion_curso = (int)cmd.ExecuteScalar();

                //DETALLE inscripcion a curso
                foreach (InscripcionCursoDetalle icd in i.listaInscripcionesD)
                {
                    string textoCMD2 = "INSERT INTO Inscripcion_Curso_Detalle (curso_id, precio, inscripcion_curso_id) output INSERTED.ins_curso_detalle_id VALUES (@curso_id, @precio, @inscripcion_curso_id)";
                    SqlCommand cmd2 = new SqlCommand(textoCMD2, con);

                    //parametros
                    SqlParameter i4 = new SqlParameter("@curso_id", icd.Curso.Id);
                    SqlParameter i5 = new SqlParameter("@precio", icd.Precio);
                    SqlParameter i6 = new SqlParameter("@inscripcion_curso_id", id_inscripcion_curso);

                    i4.SqlDbType = SqlDbType.Int;
                    i5.SqlDbType = SqlDbType.Float;
                    i6.SqlDbType = SqlDbType.Int;

                    cmd2.Parameters.Add(i4);
                    cmd2.Parameters.Add(i5);
                    cmd2.Parameters.Add(i6);

                    cmd2.ExecuteNonQuery();
                }

                InsertarExamenes(id_inscripcion_curso);
                con.Close();

                return id_inscripcion_curso;
            }
        }
        
        private static void InsertarExamenes(int id)
        {
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                listaCursosAlumno.Clear();
                listaCursosAlumno = ObtenerInscripcion(id);

                foreach (InscripcionCursoDetalle icd in listaCursosAlumno)
                {
                    string textoCMD3 = "INSERT INTO Examen (parcial_1, parcial_2, parcial_3, final, inscripcion_curso_detalle_id) VALUES (@parcial_1, @parcial_2, @parcial_3, @final, @inscripcion_curso_detalle_id)";
                    SqlCommand cmd3 = new SqlCommand(textoCMD3, con);

                    //parametros
                    SqlParameter e1 = new SqlParameter("@parcial_1", 1);
                    SqlParameter e2 = new SqlParameter("@parcial_2", 1);
                    SqlParameter e3 = new SqlParameter("@parcial_3", 1);
                    SqlParameter e4 = new SqlParameter("@final", 1);
                    SqlParameter e5 = new SqlParameter("@inscripcion_curso_detalle_id", icd.Id);

                    e1.SqlDbType = SqlDbType.Int;
                    e2.SqlDbType = SqlDbType.Int;
                    e3.SqlDbType = SqlDbType.Int;
                    e4.SqlDbType = SqlDbType.Int;
                    e5.SqlDbType = SqlDbType.Int;

                    cmd3.Parameters.Add(e1);
                    cmd3.Parameters.Add(e2);
                    cmd3.Parameters.Add(e3);
                    cmd3.Parameters.Add(e4);
                    cmd3.Parameters.Add(e5);

                    cmd3.ExecuteNonQuery();
                }
                con.Close();
            }
        }

        public static List<InscripcionCursoDetalle> ObtenerInscripcion(int id)
        {
            InscripcionCursoDetalle icd;
            listaCursosAlumno.Clear();

            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();

                string textoCMD = "SELECT * FROM Inscripcion_Curso_Detalle WHERE inscripcion_curso_id = " + id;
                SqlCommand cmd = new SqlCommand(textoCMD, con);
                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                while (elLectorDeDatos.Read())
                {

                    icd = new InscripcionCursoDetalle();
                    icd.Id = elLectorDeDatos.GetInt32(0);
                    icd.Curso = Curso.ObtenerCurso(elLectorDeDatos.GetInt32(1));
                    icd.Precio = elLectorDeDatos.GetDouble(2);

                    listaCursosAlumno.Add(icd);
                }
                con.Close();
                return listaCursosAlumno;
            }
        }

        public static List<InscripcionCursoDetalle> ObtenerCursosDeAlumno(Alumno alumno)
        {
            try
            {
                InscripcionCursoDetalle icd;
                listaCursosAlumno.Clear();

                using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
                {
                    con.Open();
                    string textoCMD = "SELECT ins_curso_detalle_id, curso_id, precio FROM Inscripcion_Curso_Detalle icd JOIN Inscripcion_Curso ic ON icd.inscripcion_curso_id = ic.inscripcion_curso_id WHERE alumno_id = @id ";

                    SqlCommand cmd = new SqlCommand(textoCMD, con);

                    SqlParameter p1 = new SqlParameter("@id", alumno.Id);
                    p1.SqlDbType = SqlDbType.Int;
                    cmd.Parameters.Add(p1);

                    SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                    while (elLectorDeDatos.Read())
                    {

                        icd = new InscripcionCursoDetalle();
                        icd.Id = elLectorDeDatos.GetInt32(0);
                        icd.Curso = Curso.ObtenerCurso(elLectorDeDatos.GetInt32(1));
                        icd.Precio = elLectorDeDatos.GetDouble(2);

                        listaCursosAlumno.Add(icd);
                    }
                    con.Close();
                    return listaCursosAlumno;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Atencion", "Error al ObtenerCursosDeAlumno!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return listaCursosAlumno;
            }
        }

        


        /*public Object ObtenerCurso(int id)
        {
            InscripcionCursoDetalle inscripcioncurso = null;

            if (listaInscripcionesDe.Count == 0)
            {
                ObtenerCursos();
            }

            foreach (InscripcionCursoDetalle icd in listaInscripcionesDe)
            {
                if (icd.Id == id)
                {
                    inscripcioncurso = icd;
                    break;
                }
            }

            return inscripcioncurso;
        }*/

        /*public static List<InscripcionCursoDetalle> ObtenerCursos()
        {
            InscripcionCursoDetalle icd;
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCMD = "SELECT * FROM Inscripcion_Curso_Detalle ";

                SqlCommand cmd = new SqlCommand(textoCMD, con);

                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();


                while (elLectorDeDatos.Read())
                {

                    icd = new InscripcionCursoDetalle();
                    icd.Id = elLectorDeDatos.GetInt32(0);
                    icd.Curso = Curso.ObtenerCurso(elLectorDeDatos.GetInt32(1));
                    icd.Precio = elLectorDeDatos.GetFloat(2);

                    listaInscripcionesDe.Add(icd);
                    //MessageBox.Show(icd.ToString());
                }
                con.Close();
                return listaInscripcionesDe;
            }
        }*/

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

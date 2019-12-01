using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesInscripcion
{
    public class InscripcionExamenEx
    {
        public Alumno Alumno { get; set; }
        public Curso Curso { get; set; }

        public string examen { get; set; }

        public DateTime FechaInscripcion { get; set; }

        public List<InscripcionExamenEx> listaInsExamen = new List<InscripcionExamenEx>();

        public InscripcionExamenEx() { }

        public InscripcionExamenEx(Alumno alumno, Carrera carrera, DateTime fechaInscripcion)
        {
            this.Alumno = alumno;
            
            this.FechaInscripcion = fechaInscripcion;
        }
       public static void Agregar(InscripcionExamenEx i)
        {
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();

                //cabecera
                string textoCMD = "INSERT INTO Inscripcion_Examen (alumno_id, curso_id, examen, fecha_inscripcion, precio) VALUES (@alumno_id, @curso_id, @examen, @fecha_inscripcion, @precio)";
                SqlCommand cmd = new SqlCommand(textoCMD, con);

                //parametros
                SqlParameter i1 = new SqlParameter("@alumno_id", i.Alumno.Id);
                SqlParameter i2 = new SqlParameter("@curso_id", i.Curso.Id);
                SqlParameter i3 = new SqlParameter("@examen", i.examen);
                SqlParameter i4 = new SqlParameter("@fecha_inscripcion", DateTime.Now);
                SqlParameter i5 = new SqlParameter("@precio", Convert.ToDouble(85000));

                i1.SqlDbType = System.Data.SqlDbType.Int;
                i2.SqlDbType = System.Data.SqlDbType.Int;
                i3.SqlDbType = System.Data.SqlDbType.VarChar;
                i4.SqlDbType = System.Data.SqlDbType.DateTime;
                i5.SqlDbType = System.Data.SqlDbType.Float;

                cmd.Parameters.Add(i1);
                cmd.Parameters.Add(i2);
                cmd.Parameters.Add(i3);
                cmd.Parameters.Add(i4);
                cmd.Parameters.Add(i5);

                cmd.ExecuteNonQuery();
            }
        }

    }
}

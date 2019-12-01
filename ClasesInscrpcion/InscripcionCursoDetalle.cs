using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesInscripcion
{
    public class InscripcionCursoDetalle
    {
        public int Id { get; set; }
        public Curso Curso { get; set; }
        public double Precio { get; set; }
        //public Alumno alumno { get; set; }

        //public EstadoInscripcion estado { get; set; }
        //public DateTime FechaInscripcion  { get; set; }

        public InscripcionCursoDetalle ObtenerCursoAlumno(int id)
        {
            InscripcionCursoDetalle icd = null;
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCMD = "SELECT * FROM Inscripcion_Curso_Detalle WHERE ins_curso_detalle_id = @id ";

                SqlCommand cmd = new SqlCommand(textoCMD, con);

                SqlParameter p1 = new SqlParameter("@id", id);
                p1.SqlDbType = System.Data.SqlDbType.Int;
                cmd.Parameters.Add(p1);

                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                while (elLectorDeDatos.Read())
                {

                    icd = new InscripcionCursoDetalle();
                    icd.Id = elLectorDeDatos.GetInt32(0);
                    icd.Curso = Curso.ObtenerCurso(elLectorDeDatos.GetInt32(1));
                    icd.Precio = elLectorDeDatos.GetDouble(2);
                }
                con.Close();
                return icd;
            }
        }

        public override string ToString()
        {
            return this.Curso + " - " + this.Precio;
        }



    }

}

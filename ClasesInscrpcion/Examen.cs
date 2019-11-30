using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ClasesInscripcion
{
    public enum RindioParcial
    {
        Si,
        No
    }

    public class Examen
    {
        /*public string detalle { get; set; }
        public bool asistio { get; set; } // Indica si el alumno asistió o no al examen*/
        public int Id { get; set; }
        public RindioParcial PrimerParcial { get; set; }
        public RindioParcial TercerParcial { get; set; }
        public RindioParcial SegundoParcial { get; set; }
        public RindioParcial Final { get; set; }
        public InscripcionCursoDetalle InscripcionCursoDetalleId { get; set; }
        public static List<Examen> listaExamen = new List<Examen>();

        /*public static lis Examen ObtenerExamenDeAlumno(InscripcionCursoDetalle inscripcioncurso)
        {
            Examen examen;
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCMD = "SELECT * FROM Examen Where inscripcion_curso_detalle_id = @id ";

                SqlCommand cmd = new SqlCommand(textoCMD, con);

                SqlParameter p1 = new SqlParameter("@id", inscripcioncurso.Id);
                p1.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(p1);

                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();


                while (elLectorDeDatos.Read())
                {
                    examen = new Examen();
                    examen.Id = elLectorDeDatos.GetInt32(0);
                    examen.PrimerParcial = (RindioParcial)elLectorDeDatos.GetInt32(1);
                    //icd.Precio = elLectorDeDatos.GetFloat(2);
                    examen.SegundoParcial = (RindioParcial)elLectorDeDatos.GetInt32(2);
                    examen.TercerParcial = (RindioParcial)elLectorDeDatos.GetInt32(3);
                    examen.Final = (RindioParcial)elLectorDeDatos.GetInt32(4);
                    examen.InscripcionCursoDetalleId = InscripcionCurso.ObtenerCurso(elLectorDeDatos.GetInt32(5));
                    //ciudad.Departamento = (Departamento)elLectorDeDatos.GetInt32(2);
                    //listaExamen.Add(examen);
                    //MessageBox.Show(icd.ToString());
                    return examen;
                }
                con.Close();
                //return examen;
            }
        }*/

        public static List<Examen> ObtenerExamenDeAlumno()
        {
            Examen ex;
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCMD = "SELECT * FROM Examen ";

                SqlCommand cmd = new SqlCommand(textoCMD, con);

                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();


                while (elLectorDeDatos.Read())
                {

                    ex = new Examen();
                    ex.Id = elLectorDeDatos.GetInt32(0);
                    ex.PrimerParcial = (RindioParcial)elLectorDeDatos.GetInt32(1);
                    ex.SegundoParcial = (RindioParcial)elLectorDeDatos.GetInt32(2);
                    ex.TercerParcial = (RindioParcial)elLectorDeDatos.GetInt32(3);
                    ex.Final = (RindioParcial)elLectorDeDatos.GetInt32(4);
                    ex.InscripcionCursoDetalleId = InscripcionCurso.ObtenerCurso(elLectorDeDatos.GetInt32(5));

                    listaExamen.Add(ex);
                }
                con.Close();
                return listaExamen;
            }
        }

        public static Examen ObtenerExamen(int CursoDetalleId)
        {
            Examen ex = null;

            if (listaExamen.Count == 0)
            {
                ObtenerExamenDeAlumno();
            }

            foreach (Examen e in listaExamen)
            {
                if (e.InscripcionCursoDetalleId.Id == CursoDetalleId)
                {
                    ex = e;
                    break;
                }
            }

            return ex;
        }

    }

}

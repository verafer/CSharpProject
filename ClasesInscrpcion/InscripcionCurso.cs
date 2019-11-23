using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

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

        public List<InscripcionCursoDetalle> detalle_inscripcion_cursos = new List<InscripcionCursoDetalle>();

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
                //cabecera
                string textoCMD = "INSERT INTO Inscripcion_Curso (alumno, estado, fecha_inscripcion) output INSERTED.id VALUES (@alumno, @estado, @fecha_inscripcion)";
                SqlCommand cmd = new SqlCommand(textoCMD, con);

                //parametros
                SqlParameter i1 = new SqlParameter("@alumno", i.Alumno.Id);
                SqlParameter i2 = new SqlParameter("@estado", i.Estado);
                SqlParameter i3 = new SqlParameter("@fecha_inscripcion", DateTime.Now);

                i1.SqlDbType = System.Data.SqlDbType.Int;
                i2.SqlDbType = System.Data.SqlDbType.Int;
                i3.SqlDbType = System.Data.SqlDbType.DateTime;
                cmd.Parameters.Add(i1);
                cmd.Parameters.Add(i2);
                cmd.Parameters.Add(i3);

                int id_inscripcion_curso = (int)cmd.ExecuteScalar();


                //DETALLE
                foreach (InscripcionCursoDetalle dic in i.detalle_inscripcion_cursos)
                {
                    //insert para el detalle
                    string textoCMD2 = "INSERT INTO Inscripcion_Curso_Detalle(curso_id, precio, inscripcion_curso_id) VALUES (@curso_id, @precio, @inscripcion_curso_id)";
                    SqlCommand cmd2 = new SqlCommand(textoCMD2, con);

                    //Pasamos los parametros

                    SqlParameter i4 = new SqlParameter("@curso_id", dic.Curso.Id);
                    SqlParameter i5 = new SqlParameter("@precio", dic.Precio);
                    SqlParameter i6 = new SqlParameter("@inscripcion_curso_id", id_inscripcion_curso);

                    cmd2.Parameters.Add(i4);
                    cmd2.Parameters.Add(i5);
                    cmd2.Parameters.Add(i6);

                    cmd2.ExecuteNonQuery();
                }
            }
        }

        public static List<Curso> ObtenerCursosDeAlumno(Alumno alumno)
        {
            
            List<Curso> listaCursos = new List<Curso>();
            foreach (Curso c in Curso.ObtenerCursos())
            {
                foreach (InscripcionCurso ic in c.listaInscriptos)
                {
                    if (alumno == ic.Alumno)
                    {
                    
                            listaCursos.Add(c);
                        
                        
                    }
                }
            }
            return listaCursos;
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

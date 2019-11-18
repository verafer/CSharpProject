using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ClasesInscripcion
{
    public class Alumno : Persona
    {
        public static List<Alumno> listaAlumno = new List<Alumno>();
        public Alumno() { }

        public Alumno(string nroDocumento, TipoDocumento tipoDocumento, DateTime fechaNacimiento, string nombre, string apellido)
        {
            this.NroDocumento = nroDocumento;
            this.TipoDocumento = tipoDocumento;
            this.FechaNacimiento = fechaNacimiento;
            this.Nombre = nombre;
            this.Apellido = apellido;
        }
        public static void AgregarAlumno(Alumno a)
        {
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open(); //Abrimos la conex con la BD
                string textoCmd = "insert into Alumno (nro_documento,tipo_documento, nombre, apellido, fecha_nacimiento, direccion, ciudad, email, telefono) VALUES (@nro_documento,@tipo_documento, @nombre, @apellido, @fecha_nacimiento, @direccion, @ciudad, @email, @telefono)";
                SqlCommand cmd = new SqlCommand(textoCmd, con);

                //PARAMETROS
                SqlParameter p1 = new SqlParameter("@nro_documento", a.NroDocumento);
                SqlParameter p2 = new SqlParameter("@tipo_documento", a.TipoDocumento);
                SqlParameter p3 = new SqlParameter("@nombre", a.Nombre);
                SqlParameter p4 = new SqlParameter("@apellido", a.Apellido);
                SqlParameter p5 = new SqlParameter("@fecha_nacimiento", a.FechaNacimiento);
                SqlParameter p6 = new SqlParameter("@direccion", a.Direccion);
                SqlParameter p7 = new SqlParameter("@ciudad", a.Ciudad.Id);
                SqlParameter p8 = new SqlParameter("@email", a.Email);
                SqlParameter p9 = new SqlParameter("@telefono",a.Telefono);

                //Le decimos a los parametros de que tipo de datos son
                p1.SqlDbType = SqlDbType.VarChar;
                p2.SqlDbType = SqlDbType.Int;
                p3.SqlDbType = SqlDbType.VarChar;
                p4.SqlDbType = SqlDbType.VarChar;
                p5.SqlDbType = SqlDbType.DateTime;
                p6.SqlDbType = SqlDbType.VarChar;
                p7.SqlDbType = SqlDbType.Int;
                p8.SqlDbType = SqlDbType.VarChar;
                p9.SqlDbType = SqlDbType.VarChar;

                //Agragamos los parametros al command
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);
                cmd.Parameters.Add(p5);
                cmd.Parameters.Add(p6);
                cmd.Parameters.Add(p7);
                cmd.Parameters.Add(p8);
                cmd.Parameters.Add(p9);

                cmd.ExecuteNonQuery();

            }
        }

        public static void EditarAlumno(Alumno a, int indice)
        {
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCMD = "UPDATE Alumno SET nro_documento = @nro_documento,tipo_documento=@tipo_documento, nombre = @nombre, apellido = @apellido, fecha_nacimiento = @fecha_nacimiento, direccion=@direccion, ciudad=@ciudad, email=@email, telefono = @telefono where alumno_id = @Id";

                SqlCommand cmd = new SqlCommand(textoCMD, con);

                //PARAMETROS
                SqlParameter p1 = new SqlParameter("@nro_documento", a.NroDocumento);
                SqlParameter p2 = new SqlParameter("@tipo_documento", a.TipoDocumento);
                SqlParameter p3 = new SqlParameter("@nombre", a.Nombre);
                SqlParameter p4 = new SqlParameter("@apellido", a.Apellido);
                SqlParameter p5 = new SqlParameter("@fecha_nacimiento", a.FechaNacimiento);
                SqlParameter p6 = new SqlParameter("@direccion", a.Direccion);
                SqlParameter p7 = new SqlParameter("@ciudad", a.Ciudad.Id);
                SqlParameter p8 = new SqlParameter("@email", a.Email);
                SqlParameter p9 = new SqlParameter("@telefono", a.Telefono);
                SqlParameter p10 = new SqlParameter("@Id", indice);

                //Le decimos a los parametros de que tipo de datos son
                p1.SqlDbType = SqlDbType.VarChar;
                p2.SqlDbType = SqlDbType.Int;
                p3.SqlDbType = SqlDbType.VarChar;
                p4.SqlDbType = SqlDbType.VarChar;
                p5.SqlDbType = SqlDbType.DateTime;
                p6.SqlDbType = SqlDbType.VarChar;
                p7.SqlDbType = SqlDbType.Int;
                p8.SqlDbType = SqlDbType.VarChar;
                p9.SqlDbType = SqlDbType.VarChar;
                p10.SqlDbType = SqlDbType.Int;

                //Agragamos los parametros al command
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);
                cmd.Parameters.Add(p5);
                cmd.Parameters.Add(p6);
                cmd.Parameters.Add(p7);
                cmd.Parameters.Add(p8);
                cmd.Parameters.Add(p9);
                cmd.Parameters.Add(p10);

                cmd.ExecuteNonQuery();
            }

        }
        public static void EliminarAlumno(Alumno alumno)
        {
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string SENTENCIA_SQL = "delete from Alumno where alumno_id = @Id";

                SqlCommand cmd = new SqlCommand(SENTENCIA_SQL, con);
                SqlParameter p1 = new SqlParameter("@Id", alumno.Id);
                p1.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(p1);

                cmd.ExecuteNonQuery();
            }
        }

        public static List<Alumno> ObtenerAlumnos()
        {
            Alumno alumno;
            listaAlumno.Clear();
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open();
                string textoCMD = "Select * from Alumno";

                SqlCommand cmd = new SqlCommand(textoCMD, con);

                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                while (elLectorDeDatos.Read())
                {
                    alumno = new Alumno();
                    alumno.Id = elLectorDeDatos.GetInt32(0);
                    alumno.NroDocumento = elLectorDeDatos.GetString(1);
                    alumno.TipoDocumento = (TipoDocumento)elLectorDeDatos.GetInt32(2);
                    alumno.Nombre = elLectorDeDatos.GetString(3);
                    alumno.Apellido = elLectorDeDatos.GetString(4);
                    alumno.FechaNacimiento = elLectorDeDatos.GetDateTime(5);
                    alumno.Direccion = elLectorDeDatos.GetString(6);
                    alumno.Ciudad = Ciudad.ObtenerCiudad(elLectorDeDatos.GetInt32(7));
                    alumno.Email = elLectorDeDatos.GetString(8);
                    alumno.Telefono = elLectorDeDatos.GetString(9);
                    listaAlumno.Add(alumno);
                }
                return listaAlumno;
            }
        }

        public static Alumno ObtenerAlumnoPorNroDoc(string nroDocumento, TipoDocumento tipoDocumento)
        {
            Alumno alumno = null;

            if (listaAlumno.Count == 0)
            {
                Alumno.ObtenerAlumnos();
            }

            foreach (Alumno a in listaAlumno)
            {
                if (a.NroDocumento == nroDocumento && a.TipoDocumento == tipoDocumento)
                {
                    alumno = a;
                    break;
                }
            }

            return alumno;
        }

        public override string ToString()
        {
            return this.Nombre + " " + this.Apellido;
        }
    }
}

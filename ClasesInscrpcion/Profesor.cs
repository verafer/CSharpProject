using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesInscripcion
{
    public class Profesor : Persona
    {
        public string NroMatricula { get; set; }
        public string TituloObtenido { get; set; }
        public static List<Profesor> listaProfesor = new List<Profesor>();

        public Profesor() { }

        public Profesor(string nroDocumento, TipoDocumento tipoDocumento, DateTime fechaNacimiento, string nombre, string apellido, DateTime fechaIngreso)
        {
            this.NroDocumento = nroDocumento;
            this.TipoDocumento = tipoDocumento;
            this.FechaNacimiento = fechaNacimiento;
            this.Nombre = nombre;
            this.Apellido = apellido;
          
        }

        public static void AgregarProfesor(Profesor p)
        {
            //listaProveedores.Add(p);
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open(); //Abrimos la conex con la BD
                string textoCmd = "insert into Profesor (nro_documento, tipo_documento,nombre," +
                    "apellido,fecha_nacimiento, direccion,ciudad,email," +
                    "telefono,nro_matricula,titulo_obtenido)" +
                    " VALUES (@nro_documento, @tipo_documento,@nombre,@apellido,@fecha_nacimiento, @direccion,@ciudad,@email,@telefono,@nro_matricula,@titulo_obtenido)";
                SqlCommand cmd = new SqlCommand(textoCmd, con);

                //PARAMETROS
                SqlParameter p1 = new SqlParameter("@nro_documento", p.NroDocumento);
                SqlParameter p2 = new SqlParameter("@tipo_documenton", p.TipoDocumento);
                SqlParameter p3 = new SqlParameter("@nombre", p.Nombre);
                SqlParameter p4 = new SqlParameter("@apellido", p.Apellido);
                SqlParameter p5 = new SqlParameter("@fecha_nacimiento", p.FechaNacimiento);
                SqlParameter p6 = new SqlParameter("@direccion", p.Direccion);
                SqlParameter p7 = new SqlParameter("@ciudad", p.Ciudad.Id);
                SqlParameter p8 = new SqlParameter("@email", p.Email);
                SqlParameter p9 = new SqlParameter("@telefono", p.Telefono);
                SqlParameter p10 = new SqlParameter("@nro_matricula", p.NroMatricula);
                SqlParameter p11 = new SqlParameter("@titulo_obtenido", p.TituloObtenido);
                

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
                p10.SqlDbType = SqlDbType.VarChar;
                p11.SqlDbType = SqlDbType.VarChar;
              

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
                cmd.Parameters.Add(p11);
                
                cmd.ExecuteNonQuery();

            }



        }
        public static void EliminarProfesor(Profesor p)
        {
            //listaProveedores.Remove(p);
            //listaProveedores.Add(p);
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open();
                string SENTENCIA_SQL = "delete from Profesor where Id = @profesor_id";

                SqlCommand cmd = new SqlCommand(SENTENCIA_SQL, con);
                SqlParameter p12 = new SqlParameter("@profesor_id", p.Id);
                p12.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(p12);

                cmd.ExecuteNonQuery();
            }
        }

        public static void EditarProfesor(int index, Profesor p)
        {
            //listaProveedores[index] = p;
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCMD = "UPDATE Profesor SET nro_documento=@nro_documento, tipo_documento=@tipo_documento,nombre=@nombre,apellido=@apellido,fecha_nacimiento=@fecha_nacimiento, direccion=@direccion,ciudad=@ciudad,email=@email," +
                    "telefono=@telefono,nro_matricula=@nro_matricula,titulo_obtenido =@titulo_obtenido  where Id = @profesor_id";

                SqlCommand cmd = new SqlCommand(textoCMD, con);

                SqlParameter p1 = new SqlParameter("@nro_documento", p.NroDocumento);
                SqlParameter p2 = new SqlParameter("@tipo_documenton", p.TipoDocumento);
                SqlParameter p3 = new SqlParameter("@nombre", p.Nombre);
                SqlParameter p4 = new SqlParameter("@apellido", p.Apellido);
                SqlParameter p5 = new SqlParameter("@fecha_nacimiento", p.FechaNacimiento);
                SqlParameter p6 = new SqlParameter("@direccion", p.Direccion);
                SqlParameter p7 = new SqlParameter("@ciudad", p.Ciudad.Id);
                SqlParameter p8 = new SqlParameter("@email", p.Email);
                SqlParameter p9 = new SqlParameter("@telefono", p.Telefono);
                SqlParameter p10 = new SqlParameter("@nro_matricula", p.NroMatricula);
                SqlParameter p11 = new SqlParameter("@titulo_obtenido", p.TituloObtenido);
                SqlParameter p12 = new SqlParameter("@profesor_id", p.Id);

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
                p10.SqlDbType = SqlDbType.VarChar;
                p11.SqlDbType = SqlDbType.VarChar;
                p12.SqlDbType = SqlDbType.Int;

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
                cmd.Parameters.Add(p11);
                cmd.Parameters.Add(p12);
                cmd.ExecuteNonQuery();
            }
        }

       

 

        public override string ToString()
        {
            //return "R. Social: " + RazonSocial +"; " + "Direcc: " + Direccion + ";" + "Contacto: " + Contacto;
            return Nombre;
        }
    }
}
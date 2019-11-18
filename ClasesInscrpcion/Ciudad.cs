using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ClasesInscripcion
{
    public enum Departamento
    {
        Central,
        Cordillera,
        Guairá
    }

    public class Ciudad : Objeto
    {
        public string Nombre { get; set; }
        public Departamento Departamento { get; set; }

        public static List<Ciudad> listaCiudades = new List<Ciudad>();

        public static void AgregarCiudad(Ciudad c)
        {
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open(); //Abrimos la conex con la BD
                string textoCmd = "insert into Ciudad (descripcion, departamento) VALUES (@nombre,@departamento)";
                SqlCommand cmd = new SqlCommand(textoCmd, con);

                //PARAMETROS
                SqlParameter p1 = new SqlParameter("@nombre", c.Nombre);
                SqlParameter p2 = new SqlParameter("@departamento", c.Departamento);

                //Le decimos a los parametros de que tipo de datos son
                p1.SqlDbType = SqlDbType.VarChar;
                p2.SqlDbType = SqlDbType.Int;

                //Agregamos los parametros al command
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);

                cmd.ExecuteNonQuery();

            }
        }

        public static void EditarCiudad(Ciudad c, int indice)
        {
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string textoCMD = "UPDATE Ciudad SET descripcion = @nombre, departamento = @departamento where ciudad_id = @Id";

                SqlCommand cmd = new SqlCommand(textoCMD, con);

                //PARAMETROS
                SqlParameter p1 = new SqlParameter("@nombre", c.Nombre);
                SqlParameter p2 = new SqlParameter("@departamento", c.Departamento);
                SqlParameter p3 = new SqlParameter("@Id", indice);

                //Le decimos a los parametros de que tipo de datos son
                p1.SqlDbType = SqlDbType.VarChar;
                p2.SqlDbType = SqlDbType.Int;
                p3.SqlDbType = SqlDbType.Int;

                //Agregamos los parametros al command
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);

                cmd.ExecuteNonQuery();
            }

        }
        public static void EliminarCiudad(Ciudad c)
        {
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))
            {
                con.Open();
                string SENTENCIA_SQL = "delete from Ciudad where ciudad_id = @Id";

                SqlCommand cmd = new SqlCommand(SENTENCIA_SQL, con);
                SqlParameter p1 = new SqlParameter("@Id", c.Id);
                p1.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(p1);

                cmd.ExecuteNonQuery();
            }
        }

        public static List<Ciudad> ObtenerCiudades()
        {
                Ciudad ciudad;
                listaCiudades.Clear();
                using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

                {
                    con.Open();
                    string textoCMD = "Select * from Ciudad";

                    SqlCommand cmd = new SqlCommand(textoCMD, con);

                    SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                    while (elLectorDeDatos.Read())
                    {
                        ciudad = new Ciudad();
                        ciudad.Id = elLectorDeDatos.GetInt32(0);
                        ciudad.Nombre = elLectorDeDatos.GetString(1);
                        ciudad.Departamento = (Departamento)elLectorDeDatos.GetInt32(2);
                        listaCiudades.Add(ciudad);
                    }
                    return listaCiudades;
                }
        }

        public static Ciudad ObtenerCiudad(int id)
        {
            Ciudad ciudad = null;

            if (listaCiudades.Count == 0)
            {
                Ciudad.ObtenerCiudades();
            }

            foreach (Ciudad d in listaCiudades)
            {
                if (d.Id == id)
                {
                    ciudad = d;
                    break;
                }
            }

            return ciudad;
        }

        public override string ToString()
        {
            return Nombre + " - " + Departamento;
        }
    }
}

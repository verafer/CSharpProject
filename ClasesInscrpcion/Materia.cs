using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ClasesInscripcion
{
    public class Materia : Objeto
    {
        public string Descripcion { get; set; }
        public Profesor Profesor { get; set; }
        public int creditosClases { get; set; }
        public int creditosPractica { get; set; }
        public static List<Materia> listaMateria = new List<Materia>();

        public Materia() { }
        public Materia(int id,string descripcion, Profesor profesor ) {
            this.Id = id;
            this.Descripcion = descripcion;
            this.Profesor = profesor;
        }
        public static void AgregarMateria(Materia m)
        {
            listaMateria.Add(m);
        }

        public static void EditarMateria(Materia m, int indice)
        {
            Materia.listaMateria[indice] = m;

        }
        public static void EliminarMateria(Materia materia)
        {
            listaMateria.Remove(materia);
        }

        public static List<Materia> ObtenerMaterias()
        {

            Materia materia;
            listaMateria.Clear();
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open();
                string textoCMD = "Select * from Materia";

                SqlCommand cmd = new SqlCommand(textoCMD, con);

                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                while (elLectorDeDatos.Read())
                {
                    materia = new Materia();
                    materia.Id = elLectorDeDatos.GetInt32(0);
                    materia.Descripcion = elLectorDeDatos.GetString(1);
                    materia.Profesor = Profesor.ObtenerProfesor(elLectorDeDatos.GetInt32(2));
                    materia.creditosClases = elLectorDeDatos.GetInt32(3);
                    materia.creditosPractica = elLectorDeDatos.GetInt32(4);

                    listaMateria.Add(materia);
                }

                return listaMateria;

            }
        }

        public static Materia ObtenerMateria(int id)
        {
            Materia materia = null;

            if (listaMateria.Count == 0)
            {
                Materia.ObtenerMaterias();
            }

            foreach (Materia m in listaMateria)
            {
                if (m.Id == id)
                {
                    materia = m;
                    break;
                }
            }

            return materia;
        }

        public override string ToString()
        {
            return this.Descripcion ;
        }

        public string  ObtenerDatosMateria() {
            return Descripcion;
        }
    }
}

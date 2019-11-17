using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ClasesInscripcion
{
    public class Profesor : Persona
    {
        public string NroMatricula { get; set; }
        public string TituloObtenido { get; set; }
        public DateTime FechaIngreso { get; set; }
        public static List<Profesor> listaProfesor = new List<Profesor>();

        public Profesor() { }

        public Profesor(string nroDocumento, TipoDocumento tipoDocumento, DateTime fechaNacimiento, string nombre, string apellido, DateTime fechaIngreso)
        {
            this.NroDocumento = nroDocumento;
            this.TipoDocumento = tipoDocumento;
            this.FechaNacimiento = fechaNacimiento;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.FechaIngreso = fechaIngreso;
        }

        public static void AgregarProfesor(Profesor p)
        {
            listaProfesor.Add(p);
        }

        public static void EditarProfesor(Profesor p, int indice)
        {
            Profesor.listaProfesor[indice] = p;

        }
        public static void EliminarProfesor(Profesor profesor)
        {
            listaProfesor.Remove(profesor);
        }

        public static List<Profesor> ObtenerProfesores()
        {
            Profesor profesor;
            listaProfesor.Clear();
            using (SqlConnection con = new SqlConnection(SqlServer.CADENA_CONEXION))

            {
                con.Open();
                string textoCMD = "Select * from Profesor";

                SqlCommand cmd = new SqlCommand(textoCMD, con);

                SqlDataReader elLectorDeDatos = cmd.ExecuteReader();

                while (elLectorDeDatos.Read())
                {
                    profesor = new Profesor();
                    profesor.Id = elLectorDeDatos.GetInt32(0);
                    profesor.NroDocumento = elLectorDeDatos.GetString(1);
                    profesor.TipoDocumento = (TipoDocumento)elLectorDeDatos.GetInt32(2);
                    profesor.Nombre = elLectorDeDatos.GetString(3);
                    profesor.Apellido = elLectorDeDatos.GetString(4);
                    profesor.FechaNacimiento = elLectorDeDatos.GetDateTime(5);
                    profesor.Direccion = elLectorDeDatos.GetString(6);
                    profesor.Ciudad = Ciudad.ObtenerCiudad(elLectorDeDatos.GetInt32(7));
                    profesor.Email = elLectorDeDatos.GetString(8);
                    profesor.Telefono = elLectorDeDatos.GetString(9);
                    profesor.NroMatricula = elLectorDeDatos.GetString(10);
                    profesor.TituloObtenido = elLectorDeDatos.GetString(10);
                    listaProfesor.Add(profesor);
                }
                return listaProfesor;
            }
        }

        public static Profesor ObtenerProfesor(int id)
        {
            Profesor profesor = null;

            if (listaProfesor.Count == 0)
            {
                Profesor.ObtenerProfesores();
            }

            foreach (Profesor p in listaProfesor)
            {
                if (p.Id == id)
                {
                    profesor = p;
                    break;
                }
            }

            return profesor;
        }

        /*public override string ToString()
        {
            return $"Nro Matricula: {NroMatricula} \nTitulo: {TituloObtenido} \nFecha de Ingreso: {FechaIngreso}\n";
        }*/

        public override string ToString()
        {
            return this.Nombre + " " + this.Apellido;
        }
    }
}

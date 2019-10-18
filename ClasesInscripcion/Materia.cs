using System;
using System.Collections.Generic;
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

        public static List<Materia> ObtenerMateria()
        {
            return listaMateria;
        }
        public void obtenerDatosMateria() { }
    }
}

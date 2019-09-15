using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesInscripcion
{
    public class Materia : Objeto
    {
        public string Descripcion { get; set; }
        public Profesor Profesor { get; set; }

        public Materia(int id,string descripcion, Profesor profesor ) {
            this.Id = id;
            this.Descripcion = descripcion;
            this.Profesor = profesor;
        }

        public void obtenerDatosMateria() { }
    }
}

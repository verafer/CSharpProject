using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesInscripcion
{
    public class Curso : Objeto
    {  
        public Materia Materia { get; set; }
        public Turno Turno { get; set; }
        public string Modalidad { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }

        public Curso() {
        }
        public override string ToString()
        {
            return $"Nro Curso: {Id} Materia: {Materia.Descripcion} Profesor: {Materia.Profesor} Turno: {Turno}";
        }
        public string ObtenerDatosCurso()
        {
            return $"nro curso{Id} {Materia.Descripcion} Profesor: {Materia.Profesor} Turno: {Turno} {Modalidad} Fecha Inicio: {FechaInicio} Fecha Fin:{FechaFin} ";
        }

        public void BajaCurso() { }
    }
}

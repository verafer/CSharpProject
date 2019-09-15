using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesInscripcion
{
    public class Facultad : Objeto
    {
        public string Nombre { get; set; }

        public Funcionario Decano { get; set; }

        public List<Funcionario> Funcionarios { get; set; }

        public List<Carrera> Carreras { get; set; }

        public Facultad() { }

        public void agregarFacultad() { }

    }
}

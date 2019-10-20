using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesInscripcion
{
    public class Turno : Objeto
    {
        public string Descripcion { get; set; }
        public static List<Turno> listaTurno = new List<Turno>();

        public Turno() { }

        
        public static void AgregarTurno(Turno t)
        {
            listaTurno.Add(t);
        }

        public static void EditarTurno(Turno t, int indice)
        {
            Turno.listaTurno[indice] = t;

        }
        public static void EliminarTurno(Turno turno)
        {
            listaTurno.Remove(turno);
        }

        public static List<Turno> ObtenerTurno()
        {
            return listaTurno;
        }
    }
}

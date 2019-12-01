using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazInscripcion
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void alumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlumno frmAlumno = new frmAlumno();
            frmAlumno.Show();
        }

        private void profesorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProfesor frmProfesor = new frmProfesor();
            frmProfesor.Show();
        }

        private void inscripciónACursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInscripcionCurso frmInscripcionCurso = new frmInscripcionCurso();
            frmInscripcionCurso.Show();
        }

        private void inscripciónAExamenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInscripcionExamen frmInscripcionExamenExt = new frmInscripcionExamen();
            frmInscripcionExamenExt.Show();
        }

        private void ciudadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCiudad frmCiudad = new frmCiudad();
            frmCiudad.Show();
        }

        private void cursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCurso frmCurso = new frmCurso();
            frmCurso.Show();
        }

        private void materiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMateria frmMateria = new frmMateria();
            frmMateria.Show();
        }
    }
}

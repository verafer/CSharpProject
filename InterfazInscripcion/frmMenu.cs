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
            frmInscripcionExamenExt frmInscripcionExamenExt = new frmInscripcionExamenExt();
            frmInscripcionExamenExt.Show();
        }

        private void CursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCurso frmCurso = new frmCurso();
            frmCurso.Show();
        }
    }
}

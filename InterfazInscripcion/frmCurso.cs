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
    public partial class frmCurso : Form
    {
        public frmCurso()
        {
            InitializeComponent();
        }
        private void LimpiarFormulario()
        {
            txtNumeroCurso.Text = "";
            cboMateria.SelectedItem = 0;
            cboProfesor.SelectedItem = 0;
            cboTurno.SelectedItem = 0;
            rbuDistancia.Checked = false;
            rbuPresencial.Checked = false;
            dtpFechaInicio.Value = DateTime.Now;
            dtpFechaFin.Value = DateTime.Now;
        }
        private void LblNumeroCurso_Click(object sender, EventArgs e)
        {

        }
    }
}

using ClasesInscripcion;
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
    public partial class frmCrearUsuario : Form
    {
        public frmCrearUsuario()
        {
            InitializeComponent();
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario.CrearUsuario(txtUsuario.Text, txtPassword.Text);
                MessageBox.Show("Usuario creado exitosamente");
            }
            catch (Exception)
            {
                MessageBox.Show("Error al Crear Usuario!");
            }
        }
    }
}

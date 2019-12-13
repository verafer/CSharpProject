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
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void BtnAcceder_Click(object sender, EventArgs e)
        {
           
                    if (txtUsuario.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Favor Ingresa el Usuario");
                return;
            }

            if (txtPassword.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Favor Ingresa la clave");
                return;
            }
            try
            {
                if (Usuario.Autenticar(txtUsuario.Text, txtPassword.Text))
                {
                    this.Hide();
                    MessageBox.Show("Bienvenido " + txtUsuario.Text);
                    frmMenu elmenuPrincipal = new frmMenu();
                    elmenuPrincipal.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ha ocurrido un error: " + ex.Message);
            }

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;

            //Estilo al Formulario
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void LklCrearUsuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCrearUsuario crearUsuario = new frmCrearUsuario();
            crearUsuario.ShowDialog();
        }
    }
    }


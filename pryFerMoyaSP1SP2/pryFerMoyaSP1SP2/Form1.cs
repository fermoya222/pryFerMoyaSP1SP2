using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryFerMoyaSP1SP2
{
    public partial class FormLogin : Form
    {
        int intentos = 0;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if ((txtUsuario.Text == "Administrador" &&
                txtContrasenia.Text == "adm135$") || (txtUsuario.Text == "Operador" &&
                txtContrasenia.Text == "ope246$"))
            {
                var frmInicio1 = new FrmInicio(); 
                frmInicio1.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Datos incorrectos. Acceso Denegado.");
                intentos++;
                if (intentos == 3)
                {
                    this.Close();
                }

            }
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); // cierra el formulario
        }
    }
}
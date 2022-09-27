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
    public partial class frmLogin : Form
    {
        int intentos = 0;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if ((txtUsuario.Text == "Administrador" &&
                txtContrasenia.Text == "adm135$") || (txtUsuario.Text == "Operador" &&
                txtContrasenia.Text == "ope246$"))
            {
                var frmInicio1 = new frmInicio(); 
                frmInicio1.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Datos incorrectos. Acceso Denegado.");
                intentos++;
                if (intentos == 3)
                {
                    this.Close(); //lo cierra
                }

            }
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); // cierra el formulario
        }
    }
}
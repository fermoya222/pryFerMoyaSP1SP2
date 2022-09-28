using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMoyaSP2
{
    public partial class frmCabañas : Form
    {
        private readonly object Total;

        public frmCabañas()
        {
            InitializeComponent();

        }

        private void frmCabañas_Load(object sender, EventArgs e)
        {
            lstTipo.SelectedIndex = 0;

            txtDias.SelectedText = "1";

            lstPersonas.SelectedIndex = 0;
        }

        private void LstTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTipo.SelectedIndex != -1)
            {
                lstPersonas.Enabled = true;
            }
            else
            {
                lstPersonas.Enabled = false;
            }

            if (lstTipo.Text == "A")
            {
                lstPersonas.Items.Clear();
                lstPersonas.Items.Add(1);
                lstPersonas.Items.Add(2);
                lstPersonas.Items.Add(3);
                lstPersonas.Items.Add(4);

            }
            if (lstTipo.Text == "B")
            {
                lstPersonas.Items.Clear();
                lstPersonas.Items.Add(1);
                lstPersonas.Items.Add(2);
                lstPersonas.Items.Add(3);
                lstPersonas.Items.Add(4);
                lstPersonas.Items.Add(5);
                lstPersonas.Items.Add(6);
                lstPersonas.Items.Add(7);
                lstPersonas.Items.Add(8);


            }

        }

        private void lstPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPersonas.SelectedIndex != -1)
            {
                txtDias.Enabled = true; 
            }
            else
            {
                txtDias.Enabled = false; 
            }
        }

        private void txtDias_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            if (optEfectivo.Checked == true)
            {
                lstTarjetas.Enabled = false;
            }
            else
            {
                lstTarjetas.Enabled = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if (optTarjeta.Checked == true)
            {
                lstTarjetas.SelectedIndex = 0;
            }
            else
            {
                lstTarjetas.SelectedIndex = -1;
            }
        }

        private void mrcFormas_Enter(object sender, EventArgs e)
        {
            
        }

      

        private void btnAceptar_Click(object sender, EventArgs e)
        {
           this.Close();

        }

        private void txtTelefonosTitular_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtDias.Text) > 0 && txtNombreTitular.Text != "" && txtTelefonosTitular.Text != "")
            {
                btnAceptar.Enabled = true;
            }
            else
            {
                btnAceptar.Enabled = false;
            }
        }

        private void txtDias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;   

            }

        }

        private void txtTelefonosTitular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;

            }
        }
    }
}

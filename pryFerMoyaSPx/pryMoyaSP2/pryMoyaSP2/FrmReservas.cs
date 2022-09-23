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
    public partial class FrmCabañas : Form
    {
        public FrmCabañas()
        {
            InitializeComponent();
        }

        private void LstTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LstTipo.SelectedIndex != -1)
            {
                lstPersonas.Enabled = true;
            }
            else
            {
                lstPersonas.Enabled = false;
            }

            if (LstTipo.Text == "A")
            {
                lstPersonas.Items.Clear();
                lstPersonas.Items.Add(1);
                lstPersonas.Items.Add(2);
                lstPersonas.Items.Add(3);
                lstPersonas.Items.Add(4);

            }
            if (LstTipo.Text == "B")
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
    }
}

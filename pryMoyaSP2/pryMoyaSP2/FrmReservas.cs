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
        }

        private void lstPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPersonas.SelectedIndex != -1)// S
            {
                txtDias.Enabled = true; //
            }
        }
    }
}

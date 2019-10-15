using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RossesGym.ControlDietetico
{
    public partial class CalcularMedidas : Form
    {
        public CalcularMedidas()
        {
            InitializeComponent();
        }

        private void CalcularMedidas_Load(object sender, EventArgs e)
        {

        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que dese salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtPeso_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

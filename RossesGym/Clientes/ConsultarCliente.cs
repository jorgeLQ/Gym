using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RossesGym.Clientes
{
    public partial class ConsultarCliente : Form
    {
        public ConsultarCliente()
        {
            InitializeComponent();
        }

        private void ConsultarCliente_Load(object sender, EventArgs e)
        {

        }

        private void TxtCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TxtFechaNac_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtTelefonoCelular_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtTelefonoConvencional_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void RbtFem_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RbtMasc_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TxtSegundoNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtPrimerNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtApellidoPaterno_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtApellidoMaterno_TextChanged(object sender, EventArgs e)
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
    }
}

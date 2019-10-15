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
    public partial class ActualizarCliente : Form
    {
        public ActualizarCliente()
        {
            InitializeComponent();
        }

        Inicio ocultar = new Inicio();

        private void BtnVerificar_Click(object sender, EventArgs e)
        {
            txtCedula.Enabled = false;
            btnHuella.Enabled = false;
            txtPrimerNombre.Enabled = true;
            txtSegundoNombre.Enabled = true;
            txtApellidoMaterno.Enabled = true;
            txtApellidoPaterno.Enabled = true;
            txtDireccion.Enabled = true;
            txtTelefonoCelular.Enabled = true;
            txtTelefonoConvencional.Enabled = true;
            txtCorreo.Enabled = true;
            btnActualizar.Enabled = true;
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que dese salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(result == DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void ActualizarCliente_MouseDown(object sender, MouseEventArgs e)
        {
         
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace RossesGym.ControlDietetico
{
    public partial class RegistrarMedidas : Form
    {

        public RegistrarMedidas()
        {
            InitializeComponent();
        }

        private void BtnRegistrarCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio Principal = new Inicio();
            Principal.AbrirFormularioEnPanel(new RegistrarCliente());
            Principal.Show();

        }

        private void RegistrarMedidas_MouseClick(object sender, MouseEventArgs e)
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

        private void RegistrarMedidas_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}

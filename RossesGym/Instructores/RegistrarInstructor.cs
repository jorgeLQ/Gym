using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RossesGym;

namespace RossesGym.Instructor
{
    public partial class RegistrarInstructor : Form
    {
        public RegistrarInstructor()
        {
            InitializeComponent();
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que dese salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void BtnHuella_Click(object sender, EventArgs e)
        {
            HuellaDigital Huella = new HuellaDigital();
            Huella.Show();
        }
    }
}

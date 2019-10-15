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

namespace RossesGym
{
    public partial class Loggin : Form
    {
        public Loggin()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void TxtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO:")
            {
                txtUsuario.Text = "";
                //txtUsuario.ForeColor = Color.LightBlue;

            }
        }

        private void TxtUsuario_Leave(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO:";
            }
        }

        private void TxtClave_Enter(object sender, EventArgs e)
        {
            if (txtClave.Text == "CONTRASEÑA:")
            {
                txtClave.Text = "";
                //txtUsuario.ForeColor = Color.LightBlue;
                txtClave.UseSystemPasswordChar = true;

            }
        }

        private void TxtClave_Leave(object sender, EventArgs e)
        {
            if(txtClave.Text == "")
            {
                txtClave.Text = "CONTRASEÑA:";
                txtClave.UseSystemPasswordChar = false;
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Loggin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0); 
        }

        private void BtnAcceder_Click(object sender, EventArgs e)
        {
            Inicio Principal = new Inicio();
            this.Hide();
            Principal.Show();
        }
    }
}

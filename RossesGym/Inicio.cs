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
using RossesGym.Clientes;
using RossesGym.Instructor;
using RossesGym.ControlAsistencia.Cliente;
using RossesGym.ControlAsistencia.Instructor;
using RossesGym.ControlDietetico;
using RossesGym.MovimientoEconomico;
using RossesGym.Administracion;


namespace RossesGym
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
      
        public void AbrirFormularioEnPanel(object formularioHijo)
        {
            if(this.panelFormularios.Controls.Count > 0)
            {
                this.panelFormularios.Controls.RemoveAt(0);
            }
            Form fh = formularioHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelFormularios.Controls.Add(fh);
            fh.Show();
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            panelCliente.Visible = true;
            panelInstructor.Visible = false;
            panelControlAsis.Visible = false;
            panelControlDietetico.Visible = false;
            panelMovEconomico.Visible = false;
            panelAsisCli.Visible = false;
            panelAsistenciaIn.Visible = false;
            panelAdministracion.Visible = false;
        }

        private void PanelFormularios_MouseClick(object sender, MouseEventArgs e)
        {
            panelCliente.Visible = false;
            panelInstructor.Visible = false;
            panelControlAsis.Visible = false;
            panelControlDietetico.Visible = false;
            panelMovEconomico.Visible = false;
            panelAsisCli.Visible = false;
            panelAsistenciaIn.Visible = false;
            panelAdministracion.Visible = false;

        }

        private void Inicio_MouseClick(object sender, MouseEventArgs e)
        {
            panelCliente.Visible = false;
            panelInstructor.Visible = false;
            panelControlAsis.Visible = false;
            panelControlDietetico.Visible = false;
            panelMovEconomico.Visible = false;
            panelAsisCli.Visible = false;
            panelAdministracion.Visible = false;
            panelAsistenciaIn.Visible = false;
        }

        private void PanelUsuario_MouseClick(object sender, MouseEventArgs e)
        {
            panelCliente.Visible = false;
            panelInstructor.Visible = false;
            panelControlAsis.Visible = false;
            panelControlDietetico.Visible = false;
            panelMovEconomico.Visible = false;
            panelAsisCli.Visible = false;
            panelAsistenciaIn.Visible = false;
            panelAdministracion.Visible = false;
        }

        private void PanelMenu_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void BtnInstructor_Click(object sender, EventArgs e)
        {
            panelInstructor.Visible = true;
            panelCliente.Visible = false;
            panelControlAsis.Visible = false;
            panelControlDietetico.Visible = false;
            panelMovEconomico.Visible = false;
            panelAsisCli.Visible = false;
            panelAsistenciaIn.Visible = false;
            panelAdministracion.Visible = false;
        }

        private void BtnAsistencia_Click(object sender, EventArgs e)
        {
            panelControlAsis.Visible = true;
            panelInstructor.Visible = false;
            panelCliente.Visible = false;
            panelControlDietetico.Visible = false;
            panelMovEconomico.Visible = false;
            panelAsisCli.Visible = false;
            panelAsistenciaIn.Visible = false;
            panelAdministracion.Visible = false;
        }

        private void BtnDieta_Click(object sender, EventArgs e)
        {
            panelControlAsis.Visible = false;
            panelInstructor.Visible = false;
            panelCliente.Visible = false;
            panelControlDietetico.Visible = true;
            panelMovEconomico.Visible = false;
            panelAsisCli.Visible = false;
            panelAsistenciaIn.Visible = false;
            panelAdministracion.Visible = false;
        }

        private void BtnEconomico_Click(object sender, EventArgs e)
        {
            panelControlAsis.Visible = false;
            panelInstructor.Visible = false;
            panelCliente.Visible = false;
            panelControlDietetico.Visible = false;
            panelMovEconomico.Visible = true;
            panelAsisCli.Visible = false;
            panelAsistenciaIn.Visible = false;
            panelAdministracion.Visible = false;
        }

        private void BtnAsistenciaCl_Click(object sender, EventArgs e)
        {
            panelControlAsis.Visible = true;
            panelInstructor.Visible = false;
            panelCliente.Visible = false;
            panelControlDietetico.Visible = false;
            panelMovEconomico.Visible = false;
            panelAsisCli.Visible = true;
            panelAsistenciaIn.Visible = false;
            panelAdministracion.Visible = false;
        }

        private void BtnAsistenciaIn_Click(object sender, EventArgs e)
        {
            panelControlAsis.Visible = true;
            panelInstructor.Visible = false;
            panelCliente.Visible = false;
            panelControlDietetico.Visible = false;
            panelMovEconomico.Visible = false;
            panelAsisCli.Visible = false;
            panelAsistenciaIn.Visible = true;
            panelAdministracion.Visible = false;
        }

        private void BtnAdministracion_Click(object sender, EventArgs e)
        {
            panelControlAsis.Visible = false;
            panelInstructor.Visible = false;
            panelCliente.Visible = false;
            panelControlDietetico.Visible = false;
            panelMovEconomico.Visible = false;
            panelAsisCli.Visible = false;
            panelAsistenciaIn.Visible = false;
            panelAdministracion.Visible = true;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que dese salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void BtnMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnRest.Visible = true;
            btnMax.Visible = false;
        }

        private void BtnRest_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRest.Visible = false;
            btnMax.Visible = true;
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PanelMenu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

            panelControlAsis.Visible = false;
            panelInstructor.Visible = false;
            panelCliente.Visible = false;
            panelControlDietetico.Visible = false;
            panelMovEconomico.Visible = false;
            panelAsisCli.Visible = false;
            panelAsistenciaIn.Visible = false;
            panelAdministracion.Visible = false;
        }

        private void BtnRegistrarC_Click(object sender, EventArgs e)
        {

            AbrirFormularioEnPanel(new RegistrarCliente());
            panelCliente.Visible = false;
            
        }

        private void BtnConsultarC_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new ConsultarCliente());
            panelCliente.Visible = false;
        }

        private void PanelMenu_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void BtnActualizarC_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new ActualizarCliente());
            panelCliente.Visible = false;
        }

        private void BtnBajaC_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new DarDeBajaCliente());
            panelCliente.Visible = false;
        }

        private void BtnAltaC_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new DarDeAltaCliente());
            panelCliente.Visible = false;
        }

        private void BtnRegistrarI_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new RegistrarInstructor());
            panelInstructor.Visible = false;
        }

        private void BtnConsultarI_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new ConsultarInstructor());
            panelInstructor.Visible = false;
        }

        private void BtnActualizarI_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new ActualizarInstructor());
            panelInstructor.Visible = false;
        }

        private void BtnBajaI_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new DarDeBajaInstructor());
            panelInstructor.Visible = false;
        }

        private void BtnAltaI_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new DarDeAltaInstructor());
            panelInstructor.Visible = false;
        }

        private void BtnRegistrarAC_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new RegistrarAsistenciaCliente());
            panelControlAsis.Visible = false;
            panelAsisCli.Visible = false;
        }

        private void BtnConsultarAC_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new ConsultarAsistenciaCliente());
            panelControlAsis.Visible = false;
            panelAsisCli.Visible = false;
        }

        private void BtnHistorialAC_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new HistorialAsistenciaCliente());
            panelControlAsis.Visible = false;
            panelAsisCli.Visible = false;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new RegistrarAsistenciaInstructor());
            panelControlAsis.Visible = false;
            panelAsistenciaIn.Visible = false;
        }

        private void BtnConsultarAI_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new ConsultarAsistenciaInstructor());
            panelControlAsis.Visible = false;
            panelAsistenciaIn.Visible = false;
        }

        private void BtnHistorialAI_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new HistorialAsistenciaInstructor());
            panelControlAsis.Visible = false;
            panelAsistenciaIn.Visible = false;
        }

        private void BtnRegistrarMedAntr_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new RegistrarMedidas());
            panelControlDietetico.Visible = false;
        }

        private void BtnCalcularMedidAntro_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new CalcularMedidas());
            panelControlDietetico.Visible = false;
        }

        private void BtnElaborarDieta_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new ElaborarDieta ());
            panelControlDietetico.Visible = false;
        }

        private void BtnGenerarReporteDiario_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new GenerarReporteDiario());
            panelMovEconomico.Visible = false;
        }

        private void BtnGenerarReporteEntreFechas_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new GenerarReporteEntreFechas());
            panelMovEconomico.Visible = false;
        }

        private void BtnGenerarReporteMensual_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new GenerarReporteMensual());
            panelMovEconomico.Visible = false;
        }

        private void BtnGenerarFactura_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new GenerarFactura());
            panelMovEconomico.Visible = false;
        }

        private void BtnBuscarFactura_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new BuscarFactura());
            panelMovEconomico.Visible = false;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
            lblFecha.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
        }

        private void BtnAdminSistema_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new AdministracionSistema());
            panelAdministracion.Visible = false;
        }
    }
}

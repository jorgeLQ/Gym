using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxZKFPEngXControl;
using System.Media;
using System.Runtime.InteropServices;

namespace RossesGym
{
    public partial class HuellaDigital : Form
    {
        private AxZKFPEngX ZkFprint = new AxZKFPEngX();
        private bool Check;

        public HuellaDigital()
        {
            InitializeComponent();

        }

        SoundPlayer Sonido;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Form1_Load(object sender, EventArgs e)
        {

            Controls.Add(ZkFprint);
            InitialAxZkfp();
        }

        private void InitialAxZkfp()
        {
            try
            {

                ZkFprint.OnImageReceived += zkFprint_OnImageReceived;
                ZkFprint.OnFeatureInfo += zkFprint_OnFeatureInfo;
                //zkFprint.OnFingerTouching 
                //zkFprint.OnFingerLeaving
                ZkFprint.OnEnroll += zkFprint_OnEnroll;

                if (ZkFprint.InitEngine() == 0)
                {
                    ZkFprint.FPEngineVersion = "9";
                    ZkFprint.EnrollCount = 3;
                    deviceSerial.Text += " " + ZkFprint.SensorSN + " Count: " + ZkFprint.SensorCount.ToString() + " Index: " + ZkFprint.SensorIndex.ToString();
                    ShowHintInfo("SENSOR BIOMETRICO CONECTADO EXITOSAMENTE.");
                }

            }
            catch(Exception ex)
            {
                ShowHintInfo("ERROR EN LA CONEXIÓN CON EL SENSOR: " + ex.Message);
            }
        }

    private void zkFprint_OnImageReceived(object sender, IZKFPEngXEvents_OnImageReceivedEvent e)
        {
            Graphics g = fpicture.CreateGraphics();
            Bitmap bmp = new Bitmap(fpicture.Width, fpicture.Height);
            g = Graphics.FromImage(bmp);
            int dc = g.GetHdc().ToInt32();
            ZkFprint.PrintImageAt(dc, 0, 0, bmp.Width, bmp.Height);
            g.Dispose();
            fpicture.Image = bmp;
        }

        private void zkFprint_OnFeatureInfo(object sender, IZKFPEngXEvents_OnFeatureInfoEvent e)
        {

            String strTemp = string.Empty;
            if (ZkFprint.EnrollIndex != 1)
            {
                if (ZkFprint.IsRegister)
                {
                    if (ZkFprint.EnrollIndex - 1 > 0)
                    {
                        int eindex = ZkFprint.EnrollIndex - 1;
                        strTemp = "POR FAVOR ESCANEE SU DEDO NUEVAMENTE " + eindex;
                    }
                }
            }
            ShowHintInfo(strTemp);
        }
        private void zkFprint_OnEnroll(object sender, IZKFPEngXEvents_OnEnrollEvent e)
        {
            if (e.actionResult)
            {

                string template = ZkFprint.EncodeTemplate1(e.aTemplate);
                txtTemplate.Text = template;
                //Sonido = new SoundPlayer(@"D:\ASUS\Programas C#\RossesGym\RossesGym\Audio\huella.wav");
                //Sonido.Play();

                MessageBox.Show("HUELLA DIGITAL REGISTRADA EXITOSAMENTE", "HUELLA DIGITAL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //ShowHintInfo("Registration successful. You can verify now");
                btnRegister.Enabled = false;
                btnVerify.Enabled = true;
            }
            else
            {
                ShowHintInfo("ERRO AL LEER LA HUELLA DIGITAL");

            }
        }
        private void zkFprint_OnCapture(object sender, IZKFPEngXEvents_OnCaptureEvent e)
        {
            string template = ZkFprint.EncodeTemplate1(e.aTemplate);


            if (ZkFprint.VerFingerFromStr(ref template, txtTemplate.Text, false, ref Check))
            {
                ShowHintInfo("VERIFICADO");
            }
            else
                ShowHintInfo("ERROR");

        }



        private void ShowHintInfo(String s)
        {
              prompt.Text = s;
        }

      
        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (ZkFprint.IsRegister)
            {
                ZkFprint.CancelEnroll();
            }
            ZkFprint.OnCapture += zkFprint_OnCapture;
            ZkFprint.BeginCapture();
            ShowHintInfo("POR FAVOR DE UN EJEMPLO DE SU HUELLA DIGITAL");
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            ZkFprint.CancelEnroll();
            ZkFprint.EnrollCount = 3;
            ZkFprint.BeginEnroll();
            ShowHintInfo("POR FAVOR DE UN EJEMPLO DE SU HUELLA DIGITAL");
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            fpicture.Image = null;
        }

        private void Fpicture_Click(object sender, EventArgs e)
        {

        }

        private void TxtTemplate_TextChanged(object sender, EventArgs e)
        {
        }

        private void Prompt_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void PanelBarra_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnMax_Click(object sender, EventArgs e)
        {

        }

        private void BtnRest_Click(object sender, EventArgs e)
        {
        }

        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void deviceSerial_Click(object sender, EventArgs e)
        {

        }
    }
}

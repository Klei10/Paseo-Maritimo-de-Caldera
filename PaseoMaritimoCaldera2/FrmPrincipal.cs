using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace PaseoMaritimoCaldera2
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            MostrarLogo();
        }
        int lx, ly;
        int sw, sh;
        //Metodo para arratrar la ventana por la parte superior
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void PanelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Metodos para cerrar, restaurar, maximizar y minimizar la ventana
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea cerrar el programa?","Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void BtnRestaurar_Click(object sender, EventArgs e)
        {
            this.Size = new Size(sw,sh);
            this.Location = new Point(lx,ly);
            BtnRestaurar.Visible = false;
            BtnMaximizar.Visible = true;
        }

        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            BtnMaximizar.Visible = false;
            BtnRestaurar.Visible = true;
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Metodo para la animacion del boton menu
        private void BtnMenu_Click(object sender, EventArgs e)
        {
            //Con efecto de Slide
            if(PanelIzquierdo.Width == 230)
            {
                this.TimerOcultar.Enabled = true;
            }
            else if(PanelIzquierdo.Width == 55)
            {
                this.TimerMostrar.Enabled = true;
            }
            //Sin efecto slide
            //if (panelMenu.Width == 230)
            //{
            //    panelMenu.Width = 55;
            //}
            //else
            //    panelMenu.Width = 230;
        }

        private void TimerOcultar_Tick(object sender, EventArgs e)
        {
            if (PanelIzquierdo.Width <= 55)
                this.TimerOcultar.Enabled = false;
            else
                PanelIzquierdo.Width = PanelIzquierdo.Width - 35;
        }

        private void TimerMostrar_Tick(object sender, EventArgs e)
        {
            if (PanelIzquierdo.Width >= 230)
                this.TimerMostrar.Enabled = false;
            else
                PanelIzquierdo.Width = PanelIzquierdo.Width + 35;
        }

        private void PanelIzquierdo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TimerFechaHora_Tick(object sender, EventArgs e)
        {
            LblHora.Text = DateTime.Now.ToString("HH:mm:ssss");
            LblFecha.Text = DateTime.Now.ToString("dddd,' 'd MMMM,' 'yyyy");
        }

        private void LblFecha_TextChanged(object sender, EventArgs e)
        {
            LblFecha.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(LblFecha.Text);
        }

        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmInicioSesion());
        }

        //Metodo para abrir un formulario dentro del panel
        private void AbrirFormEnPanel(object formHijo)
        {
            if (this.PanelCentral.Controls.Count > 0)
                this.PanelCentral.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.PanelCentral.Controls.Add(fh);
            this.PanelCentral.Tag = fh;
            fh.Show();
        }

        //Metodo para mostrar el formulario de logo al iniciar
        private void MostrarLogo()
        {
            AbrirFormEnPanel(new FrmLogo());
        }


    }
}

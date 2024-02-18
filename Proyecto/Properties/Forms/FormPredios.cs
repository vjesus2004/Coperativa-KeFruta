using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class FormPredios : Form
    {
        
        public FormPredios()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        //Minimizar,Cerrar,Maximizar,Restaurar
        private void picCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picRes_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            picRes.Visible = false;
            picMax.Visible = true;
        }

        private void picMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            picMax.Visible = false;
            picRes.Visible = true;
        }

        private void picMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //Mover ventana
        private void pnlBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
       
        //btnVolver
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormGestion_Load(object sender, EventArgs e)
        {
            Metodos.pnlTrasparencia(pnlContenedor);
            Metodos.btnMod(btnSalir);
            Metodos.btnMod(btnVolver);
            Metodos.btnMod(btnMod);
            ;
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}

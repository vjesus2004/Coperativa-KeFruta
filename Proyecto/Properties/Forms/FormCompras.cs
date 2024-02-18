using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class FormCompras : Form
    {
        public FormCompras()
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
            Application.Exit();

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
       
       

        private void btnVolver_Click(object sender, EventArgs e)
        {
           
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Mover ventana
        private void pnlBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pnlCatalogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormCompras_Load(object sender, EventArgs e)
        {
            Metodos.pnlTrasparencia(pnlCatalogo);
            Metodos.btnMod(btnVolver);
            Metodos.btnMod(btnSalir);
            Metodos.btnMod(btnOrdenar);
        }
    }
}




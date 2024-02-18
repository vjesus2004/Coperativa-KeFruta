using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Ke_Fruta : Form
    {
        
        public Ke_Fruta()
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
        //Mover ventana
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //formFunciones
        private void btnFunciones_Click(object sender, EventArgs e)
        {
            Form formFunciones = new Frm_Funciones();
            formFunciones.Show();
             
        }
      
        private void btnLogout_Click(object sender, EventArgs e)
        {
         
        }
        //label hora y fecha
        private void fechahora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString()+" p.m.";
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }
        //submenu gestion



        private void btnCompras_Click(object sender, EventArgs e)
        {
            Form FCompras = new FormCompras();
            FCompras.Show();
            
        }
  //Llamado al Formulario de Login
        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            Form FLogin = new FormLogin();
            FLogin.Show();
            this.Close();
            
        }

        private void btnComprasProd_Click(object sender, EventArgs e)
        {
            Form comprasprod = new FormComprasProd();
            comprasprod.Show();
        }

        private void btn_GestionDatos_Click(object sender, EventArgs e)
        {
            Form gdatos = new FormGestionDatos();
            gdatos.Show();
        }

        private void btnPredios_Click(object sender, EventArgs e)
        {
            Form predios = new FormPredios();
            predios.Show();
        }

        private void btnCosechas_Click(object sender, EventArgs e)
        {
            Form cosecha = new FormCosecha();
            cosecha.Show();
        }

        private void btnFechas_Click(object sender, EventArgs e)
        {
            Form fechas = new FormFechas();
            fechas.Show();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            Form ventas = new FormVentas();
            ventas.Show();
        }
    }
}

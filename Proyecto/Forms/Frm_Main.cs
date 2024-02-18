using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Negocios;
namespace Proyecto
{
    public partial class Ke_Fruta : Form
    {
        string usuario;
        public Ke_Fruta(string user)
        {
            InitializeComponent();
            usuario = user;
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
            Form FCompras = new Frm_Compras(usuario);
            FCompras.Show();
            
        }
  //Llamado al Formulario de Login
        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            Form FLogin = new Frm_Login();
            FLogin.Show();
            this.Close();
            
        }

     

        private void btn_GestionDatos_Click(object sender, EventArgs e)
        {
            Form gdatos = new Frm_DatosProd(usuario);
            gdatos.Show();
        }

        private void btnPredios_Click(object sender, EventArgs e)
        {
            Form predios = new Frm_Predios( usuario);
            predios.Show();
        }

        private void btnCosechas_Click(object sender, EventArgs e)
        {
            Form cosecha = new Frm_Cosecha(usuario);
            cosecha.Show();
        }

        private void btnFechas_Click(object sender, EventArgs e)
        {
            Form fechas = new Frm_Fechas();
            fechas.Show();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            Form ventas = new Frm_Ventas(usuario);
            ventas.Show();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            Form ventas = new Frm_FuncionesProductos();
            ventas.Show();
        }

        private void btnSectores_Click(object sender, EventArgs e)
        {
            Form ventas = new Frm_FuncionesSector();
            ventas.Show();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            Form f = new Frm_Gestion();
            f.Show();
        }
    }
}

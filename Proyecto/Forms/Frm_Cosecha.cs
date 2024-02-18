using Negocios;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Frm_Cosecha : Form
    {
        string usuario;
        public Frm_Cosecha(string user)
        {
            InitializeComponent();
            usuario = user;
        }
        ConexionSQLN cn = new ConexionSQLN();

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        //Minimizar,Cerrar,Maximizar,Restaurar
        private void picCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
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
            cn.setTPCSUser(usuario);
            cn.CBXCOSECHA(cbxTipoProd);

            Metodos.pnlTrasparencia(pnlFechas);
            Metodos.btnMod(btnSalir);
            Metodos.btnMod(btnVolver);
  ;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string tipo = Convert.ToString(cbxTipoProd.SelectedItem);
            cn.setTipoC(tipo);
            pnlFechas.Visible = true;
            cn.ConsultFecha(txtSiembra,txtCultivo);
        }
        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            
        }
        private void cbxTipoProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void picCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

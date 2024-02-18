using Negocios;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Frm_DatosProd : Form
    {
        string usuario;
        public Frm_DatosProd(string user)
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
            Metodos.pnlTrasparencia(pnlDatosActual);
            Metodos.btnMod(btnVolver);
            Metodos.btnMod(btnConfirmar);
        }

    

        private void picCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

      
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            ConexionSQLN cn = new ConexionSQLN();
            cn.BuscarUser(usuario);
            cn.ConsultUser(txtNombreAct, txtApeAct, txtCalleAct, txtActUser, txtActPass, txtNpAtc, txtCI, txtTelAct);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
        
            ConexionSQLN cn = new ConexionSQLN();
            cn.UpdateProd(txtCI, txtNombreAct, txtApeAct, txtActUser, txtActPass, txtCalleAct, txtNpAtc,txtTelAct );

        }

        private void txtCI_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtNombreAct_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.letras(e);
        }

        private void txtApeAct_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.letras(e);
        }

        private void txtTipoAct_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.letras(e);
        }

        private void txtTelAct_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.numeros(e);
        }

        private void txtNpAtc_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.numeros(e);
        }
    }
}

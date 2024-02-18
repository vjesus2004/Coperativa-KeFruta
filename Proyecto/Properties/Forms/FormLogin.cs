using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Negocios;

namespace Proyecto
{
    public partial class FormLogin : Form
    {

        ConexionSQLN cn = new ConexionSQLN();

        public FormLogin()
        {
            InitializeComponent();
        }

        //Variables LogIn
        int trys = 2;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        public void btnConfirmar_Click(object sender, EventArgs e)
        { 
            lblErrorVacio.Visible = false;
            this.AcceptButton = this.btnConfirmar;
            if (cn.conSQL(txtUser.Text,txtPass.Text) == 1 )
            {

                if (cn.RolSQL(txtUser.Text, txtPass.Text) == "P")
                {
                    Ke_Fruta f1 = new Ke_Fruta();
                    f1.btnComprasProd.Visible = true;
                    f1.btnCosechas.Visible = true;
                    f1.btn_GestionDatos.Visible = true;
                    f1.btnPredios.Visible = true;
                    f1.btnCompras.Visible = true;
                    f1.Show();
                    this.Hide();
                }
                if (cn.RolSQL(txtUser.Text, txtPass.Text) == "C")
                {
                    Ke_Fruta f1 = new Ke_Fruta();
                    f1.btnCompras.Visible = true;
                    f1.Show();
                    this.Hide();
                }
                if (cn.RolSQL(txtUser.Text, txtPass.Text) == "A")
                {
                    Ke_Fruta f1 = new Ke_Fruta();
                    f1.btnFunciones.Visible = true;
                    f1.btnVentas.Visible = true;
                    f1.btnFechas.Visible = true;
                    f1.Show();
                    this.Hide();
                }
            }
            else
            {
                if (txtPass.Text == "" || txtUser.Text == "")
                {
                    lblErrorVacio.Visible = true;
                    lblError.Visible = false;
                }
                else
                {
                    if (cn.conSQL(txtUser.Text, txtPass.Text) == 0)
                    {
                        lblError.Text = "Error de Inicio de Sesion." +
                                    "Intentos restantes:" + trys;
                    lblError.Visible = true;
                    trys--;

                    
                    if (trys == 0)
                    {
                        MessageBox.Show("Ha llegado al número máximo de intentos.");
                        Application.Exit();
                    }
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnl_TituloLigin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
        
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;//elimina el sonido
                btnConfirmar_Click(sender, e);//llama al evento click del boton
            }
        }
        private void pcbLogo_Click(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            Metodos.btnMod(btnConfirmar);
        }
    }
}



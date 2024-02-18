using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class FormComprasProd : Form
    {
        public FormComprasProd()
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
       
       

        private void btnVolver_Click(object sender, EventArgs e)
        {
           
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
            //Seleccion de catalogo
            if (cmbCatalogo.SelectedItem.Equals("Fertilizante")){
                pnlCatalogo.BringToFront();
            }else{
                if (cmbCatalogo.SelectedItem.Equals("Semillas"))
                {
                    pnlSemillas.BringToFront();
                }
                else
                {
                    if (cmbCatalogo.SelectedItem.Equals("Fungicidas"))
                    {
                        pnlFungicida.BringToFront();
                    }
                }
            }
            //Diseño
            Metodos.btnMod(btnVolver);
            Metodos.btnMod(btnSalir);
            Metodos.btnMod(btnCalcular);
            Metodos.btnMod(btnComprar);
            Metodos.btnMod(btnComprarF);
            Metodos.btnMod(btnCalcularF);
            Metodos.btnMod(btnCalcularF);
            Metodos.btnMod(btnCalcPrecio);
            Metodos.btnMod(btnComprarSemillas);
        }

        private void lblcompras_Click(object sender, EventArgs e)
        {

        }

       
        private void lblTipoCompra_Click(object sender, EventArgs e)
        {
           
        }
    }
}






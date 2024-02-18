using Negocios;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Frm_Compras : Form
    {
        string usuario;
        public Frm_Compras(string user)
        {
            InitializeComponent();
            usuario=user;
        }
        ConexionSQLN cn = new ConexionSQLN();
        LogicaCompra log = new LogicaCompra();
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

    
        private void FormCompras_Load(object sender, EventArgs e)
        {
            
            cn.Catalogo(usuario,lblCatalogo);
            if (lblCatalogo.Text== "Catalogo del productor de Frutas")
            {
                pnlCatalogoFrutas.Visible = false;
            }else if (lblCatalogo.Text == "Catalogo del productor de Verduras")
            {
                pnlCatalogoVerduras.Visible = false;
            }else if (lblCatalogo.Text == "Catalogo del productor de Cereales")
            {
                pnlCatalogoCereales.Visible = false;
                picfert.Visible = true;
                NupFertilizante.Visible = true;
                lblfert.Visible=true;
            }
            Metodos.pnlTrasparencia(pnlCatalogoVerduras);
            Metodos.pnlTrasparencia(pnlCatalogoCereales);
            Metodos.pnlTrasparencia(pnlCatalogoFrutas);
            Metodos.btnMod(btnVolver);
            Metodos.btnMod(btnSalir);
            Metodos.btnMod(btnOrdenar);
        }
        private void btnOrdenar_Click(object sender, EventArgs e)
        {   
            log.SetCantidades(NuopManzana,NupNaranja,NupLimon,NupPapa,nUpZapallo,NupCebada,NupTrigo,NupFertilizante,nupFungicida,NupSemillas);
            log.SetFactura(lstFactura,usuario);
        }
    }
}




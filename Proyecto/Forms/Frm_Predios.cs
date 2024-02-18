using Negocios;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Frm_Predios : Form
    {
        string usuario;
        public Frm_Predios(string user)
        {
            InitializeComponent();
            usuario =user;
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
            ConexionSQLN cn = new ConexionSQLN();
            cn.CISector(usuario,cbxSector);
            Metodos.pnlTrasparencia(pnlContenedor);
            Metodos.btnMod(btnVolver);
            Metodos.btnMod(btnMod);
            
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {

        }

        private void picCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxSector_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConexionSQLN cn = new ConexionSQLN();

            cn.IdSectortoHectareas(cbxSector.Text, TXThECTAREAS);
            cn.IdSectortoEstado(cbxSector.Text,txtEstado);
            cbxProd.Items.Clear();
            cbxProd.Text = "";
            cn.IdSectortoProxCosecha(cbxSector.Text,cbxProd);
            if (cbxProd.Text == "Trigo" || cbxProd.Text == "Cebada") { btnFert.Enabled = true; }
            if (txtEstado.Text == "En Uso") 
            {
                chkProxCosecha.Enabled = false;
            }
            else if (txtEstado.Text == "En Descanso") 
            {
                chkProxCosecha.Enabled = true; 
            }
            if (cbxProd.Text=="Trigo" || cbxProd.Text == "Cebada")
            {
                btnFert.Visible = true;
            }
        }

        private void chkProxCosecha_CheckedChanged(object sender, EventArgs e)
        {
            if (chkProxCosecha.Checked == true)
            {
                ConexionSQLN cn = new ConexionSQLN();
                cn.setTPCSUser(usuario);
                cn.CBXCOSECHA(cbxProd);
            }
         
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            ConexionSQLN cn = new ConexionSQLN();
            cn.UpdateProxCosecha(cbxSector,cbxProd);
        }

        private void btnFert_Click(object sender, EventArgs e)
        {
            Frm_Fert f = new Frm_Fert(cbxSector.Text);
            f.Show();
            this.Hide();
        }
    }
}

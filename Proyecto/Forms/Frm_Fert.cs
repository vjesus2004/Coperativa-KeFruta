using Negocios;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Frm_Fert : Form
    {
        string sector;
        public Frm_Fert(string sectorr)
        {
            InitializeComponent();
            sector =sectorr;
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
           
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormGestion_Load(object sender, EventArgs e)
        {
            ConexionSQLN cn = new ConexionSQLN();
            cn.Fertilizante(sector, cbxFert);
            Metodos.pnlTrasparencia(pnlcereales);Metodos.pnlTrasparencia(pnlfert);
            Metodos.btnMod(btnVolver); Metodos.btnMod(btnVolver);
            cbxsectorf.Text = sector;
       
        }
        private void picCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxFert_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxFert.Text=="Z2.2")
            {
                NupNitrogenoSuelo.Enabled = true;
                NupNitrogenoPlanta.Enabled = false;
                NupFosforo.Enabled = false;
            }if (cbxFert.Text == "Z3.0")
            {
                NupNitrogenoSuelo.Enabled = false;
                NupNitrogenoPlanta.Enabled = true;
                NupFosforo.Enabled = false;
            }
            if (cbxFert.Text == "Fosforo")
            {
                NupNitrogenoSuelo.Enabled = false;
                NupNitrogenoPlanta.Enabled = false;
                NupFosforo.Enabled = true;
            }
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            pnlfert.Visible = true;

            if (cbxFert.Text == "Z2.2")
            {
                ConexionSQLN cn = new ConexionSQLN();
                cn.IdSectortoHectareasFert(cbxsectorf.Text);
                txtTotal.Text = cn.CalculoZ2(NupNitrogenoSuelo, cbxsectorf.Text).ToString();
            }
            if (cbxFert.Text == "Z3.0")
            {
                ConexionSQLN cn = new ConexionSQLN();
                cn.IdSectortoHectareasFert(cbxsectorf.Text);
                txtTotal.Text = cn.CalculoZ3(NupNitrogenoPlanta, cbxsectorf.Text).ToString();
            }
            if (cbxFert.Text == "Fosforo")
            {
                ConexionSQLN cn = new ConexionSQLN();
                cn.IdSectortoHectareasFert(cbxsectorf.Text);
                txtTotal.Text= cn.CalculoFosforo(NupFosforo, cbxsectorf.Text).ToString();

            }
            NupFosforo.Value         = 0;
            NupNitrogenoSuelo.Value  = 0;
            NupNitrogenoPlanta.Value = 0; 

        }

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fertilizacion Iniciada, Proceda a comprar los insumos");
        }
    }
}




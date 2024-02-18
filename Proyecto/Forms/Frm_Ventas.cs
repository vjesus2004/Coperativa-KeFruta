using Negocios;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Frm_Ventas : Form
    {
        string usuario;
        public Frm_Ventas(string user)
        {
            usuario = user;
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        ConexionSQLN cn = new ConexionSQLN();
        LogicaCompra log = new LogicaCompra();
      
        //Minimizar,Cerrar,Maximizar,Restaurar
        private void picCerrar_Click(object sender, EventArgs e)
        {
            this.Close();       }

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
            
            Metodos.btnMod(btnVolver);
  ;
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
            Application.Exit();
        }

        private void picCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ckbBaja_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbBaja.Checked)
            {
                ckbIdVenta.Checked = false;
                ckbProductor.Checked = false;
                ckbTipoProd.Checked = false;
            }
        }

        private void ckbIdVenta_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbIdVenta.Checked == true)
            {
                ckbBaja.Checked = false;
                ckbProductor.Checked = false;
                ckbTipoProd.Checked = false;

            }
        }

        private void ckbTipoProd_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbTipoProd.Checked == true)
            {
                ckbBaja.Checked = false;
                ckbProductor.Checked = false;
                ckbIdVenta.Checked = false;

            }
        }

        private void ckbProductor_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbProductor.Checked == true)
            {
                ckbBaja.Checked = false;
                ckbTipoProd.Checked = false;
                ckbIdVenta.Checked = false;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtVenta.Text == "" && ckbIdVenta.Checked == false && ckbTipoProd.Checked == false && ckbBaja.Checked == false && ckbProductor.Checked == false)
            {
                cn.ConsultVentasDT(dtTabla);
            }
            else if  (txtVenta.Text != "" && ckbIdVenta.Checked == true){

    
                cn.ConsultVentasDTIdVentas(dtTabla,txtVenta.Text);
            }else if (txtVenta.Text == "" && ckbIdVenta.Checked == true)
            {
                MessageBox.Show("Error no deje el criterio de busqueda en blanco");


            } else if (txtID.Text != "" && ckbTipoProd.Checked == true)
            {
           
                cn.ConsultVentasCodProducto(dtTabla,txtID.Text);
            }
            else if (txtID.Text == "" && ckbTipoProd.Checked == true)
            {
                MessageBox.Show("Error no deje el criterio de busqueda en blanco");
            }
            else if (txtCiProductor.Text != "" && ckbProductor.Checked == true)
            {

                cn.ConsultVentasCI(dtTabla, txtCiProductor.Text);
            }
            else if (txtCiProductor.Text == "" && ckbProductor.Checked == true)
            {
                MessageBox.Show("Error no deje el criterio de busqueda en blanco");
            }else if (txtVenta.Text != "" && ckbBaja.Checked == true)
            {

                cn.ConsultVentasBajaIdVentas(dtTabla, txtVenta.Text);
            }else if (txtVenta.Text == "" && ckbBaja.Checked == true)
            {

                cn.ConsultVentasBaja(dtTabla);

            }
    }

        private void btnPendiente_Click(object sender, EventArgs e)
        {

            cn.ConsultVentasPendientes(dtTabla);
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {   
            cn.AprobarCompra(txtVenta);
            cn.AddVentaandVentaProd(usuario);
        }
    }
}







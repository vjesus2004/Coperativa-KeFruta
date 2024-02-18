using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Negocios;


namespace Proyecto
{
    public partial class Frm_FuncionesSector : Form
    {
        
        public Frm_FuncionesSector()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Validaciones,Diseño
        Metodos val = new Metodos();
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
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Boton Volver y Salir

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

         
            //Load para el diseño
             private void Frm_Funciones_Load(object sender, EventArgs e)
        {
            pnlAdd.BackColor = Color.FromArgb   (100, 0, 0, 0);
         
            Metodos.btnMod(btnAdd);
            Metodos.btnMod(btnBuscar);
            Metodos.btnMod(btnEliminar);
            Metodos.btnMod(btnVolver);

        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {   int estado=0;
            if(cbxEstado.Text=="En uso")
            {estado = 1; }
            else { if (cbxEstado.Text == "En Descanso") 
                { estado = 0; }}
            
            ConexionSQLN cn = new ConexionSQLN();
            cn.setTPCS(cboTipoProduccion.Text);
            cn.GetTipodeCosecha(cbxProd.Text);
            cn.addSector(txtID,txtCI,cbxProd.Text,estado,txtTamaño);
            txtCI.Text = "";
            txtID.Text = "";
            txtTamaño.Text = "";
            cbxEstado.SelectedIndex = cbxEstado.FindStringExact("");
            cbxProd.SelectedIndex = cbxProd.FindStringExact("");

        }
            

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            ConexionSQLN cn=new ConexionSQLN();
            cn.delsector(txtID.Text);
            txtCI.Text = "";
            txtID.Text = "";
            txtTamaño.Text = "";
            cbxEstado.SelectedIndex = cbxEstado.FindStringExact("");
            cbxProd.SelectedIndex = cbxProd.FindStringExact("");


        }

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

                if (txtID.Text != "")
                {
                    ConexionSQLN conexionSQLN = new ConexionSQLN();
                    conexionSQLN.ConsultaSectorDT1(dtTabla, txtID);
                    txtCI.Text = "";
                    txtTamaño.Text = "";
                    cbxEstado.SelectedIndex = cbxEstado.FindStringExact("");
                    cbxProd.SelectedIndex = cbxProd.FindStringExact("");
                }
                else
                {
                    ConexionSQLN conexionSQLN = new ConexionSQLN();
                    conexionSQLN.ConsultaSectorDT(dtTabla);
                    txtCI.Text = "";
                    txtTamaño.Text = "";
                    cbxEstado.SelectedIndex = cbxEstado.FindStringExact("");
                    cbxProd.SelectedIndex = cbxProd.FindStringExact("");
                }
 }


        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.numeros(e);
        }

        private void cboTipoProduccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxProd.Items.Clear();
            if (cboTipoProduccion.Text == "Frutas") 
            {     
                lblTipoProd1.Visible = true; cbxProd.Visible = true;
                cbxProd.Items.Add("Manzana");
                cbxProd.Items.Add("Limon");
                cbxProd.Items.Add("Naranja");
                cbxProd.Items.Remove("Trigo");
                cbxProd.Items.Remove("Cebada");
                cbxProd.Items.Remove("Papa Rosada");
                cbxProd.Items.Remove("Zapallo"); ;

            } else if (cboTipoProduccion.Text == "Verdura")
            {
                lblTipoProd1.Visible = true; cbxProd.Visible = true;
                cbxProd.Items.Add("Papa Rosada");
                cbxProd.Items.Add("Zapallo Criollo");
                cbxProd.Items.Remove("Manzanas");
                cbxProd.Items.Remove("Limones");
                cbxProd.Items.Remove("Naranjas");
                cbxProd.Items.Remove("Trigo");
                cbxProd.Items.Remove("Cebada");
            }
            else if (cboTipoProduccion.Text == "Cereales")
            {
                lblTipoProd1.Visible = true;cbxProd.Visible = true;
                cbxProd.Items.Add("Trigo");
                cbxProd.Items.Add("Cebada");
                cbxProd.Items.Remove("Manzanas");
                cbxProd.Items.Remove("Limones");
                cbxProd.Items.Remove("Naranjas");
                cbxProd.Items.Remove("Papa Rosada");
                cbxProd.Items.Remove("Zapallo"); ;
             }
    }

        private void btnMod_Click(object sender, EventArgs e)
        {

        }
    }
}

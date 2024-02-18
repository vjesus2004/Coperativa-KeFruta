using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Negocios;


namespace Proyecto
{
    public partial class Frm_Funciones : Form
    {
        
        public Frm_Funciones()
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
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtNpuerta_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.numeros(e);
        }

        private void txtaddCI_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.numeros(e);
        }
             
        private void txtaddID_KeyPress(object sender, KeyPressEventArgs e)
        {
             Metodos.numeros(e);
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.numeros(e);
        }

        private void txtEliminar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.numeros(e);
        }
        private void txtApe_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.letras(e);
        }
        //Load para el diseño
        private void Frm_Funciones_Load(object sender, EventArgs e)
        {


            pnlAdd.BackColor = Color.FromArgb   (100, 0, 0, 0);
         
            Metodos.btnMod(btnAdd);
            Metodos.btnMod(btnBuscar);
            Metodos.btnMod(btnEliminar);
            Metodos.btnMod(btnVolver);
            Metodos.btnMod(btnMod);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {//validacion de primary key

            

            
            string tipo="";
            if (cbxTipo.Text=="")
            {
                MessageBox.Show("Asigne tipo de Funcionario");
            
            }else if (cbxTipo.Text=="Administrativo")
                 {tipo = "A"; }
                else
                if (cbxTipo.Text == "Productor")
                {tipo = "P";
 
                }else{ MessageBox.Show("Seleccione un rol de Funcionario"); }

            ConexionSQLN conexionSQLNn = new ConexionSQLN();
            if (txtaddCI.Text.Length <8)
            {
                MessageBox.Show("La ci debe contener 8 digitos");
            }else{            conexionSQLNn.adduser(txtNombre.Text,txtaddCI.Text,txtApe.Text,txtCalle.Text,txtNpuerta.Text,txtPass.Text,txtUsuario.Text,tipo,cboTipoProd.Text);
            conexionSQLNn.addtel(txtaddCI.Text, txtTel.Text);
            txtaddCI.Text = ""; txtNombre.Text = ""; txtApe.Text = ""; txtCalle.Text = ""; txtNpuerta.Text = ""; txtPass.Text = ""; txtUsuario.Text = ""; cbxTipo.SelectedIndex = cbxTipo.FindStringExact(""); txtTel.Text = ""; ;
            cboTipoProd.SelectedIndex = cboTipoProd.FindStringExact("");
            txtaddCI.Focus();


            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtaddCI.Text.Length < 8)
            {
                MessageBox.Show("La ci debe contener 8 digitos");
            }
            else
            {
                ConexionSQLN conexionSQLN=new ConexionSQLN();
            conexionSQLN.deluser(txtaddCI.Text);
            txtaddCI.Text = ""; txtNombre.Text = ""; txtApe.Text = ""; txtCalle.Text = ""; txtNpuerta.Text = ""; txtPass.Text = ""; txtUsuario.Text = "";txtTel.Text = ""; cbxTipo.SelectedIndex = cbxTipo.FindStringExact("");
            cboTipoProd.SelectedIndex = cboTipoProd.FindStringExact("");
            txtaddCI.Focus();

            }
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
            
                if (ckbBaja.Checked == true)
            {
                if (txtaddCI.Text != "")
                {
                    ConexionSQLN conexionSQLN = new ConexionSQLN();
                    conexionSQLN.ConsultaBajaDT1(dtTabla, txtaddCI);
                 txtNombre.Text = ""; txtApe.Text = ""; txtCalle.Text = ""; txtNpuerta.Text = ""; txtPass.Text = ""; txtUsuario.Text = ""; cbxTipo.SelectedIndex = cbxTipo.FindStringExact(""); txtTel.Text = "";
                    cboTipoProd.SelectedIndex = cboTipoProd.FindStringExact("");
                    txtaddCI.Focus();

                }
                else
                {
                    ConexionSQLN conexionSQLN = new ConexionSQLN();
                    conexionSQLN.ConsultaBajaDT(dtTabla);
                     txtNombre.Text = ""; txtApe.Text = ""; txtCalle.Text = ""; txtNpuerta.Text = ""; txtPass.Text = ""; txtUsuario.Text = ""; cbxTipo.SelectedIndex = cbxTipo.FindStringExact(""); txtTel.Text = "";
                    cboTipoProd.SelectedIndex = cboTipoProd.FindStringExact("");
                    txtaddCI.Focus();
                }
            }
            else { 

                if (txtaddCI.Text != ""){
                ConexionSQLN conexionSQLN = new ConexionSQLN();
                conexionSQLN.ConsultaDT1(dtTabla,txtaddCI);
                     txtNombre.Text = ""; txtApe.Text = ""; txtCalle.Text = ""; txtNpuerta.Text = ""; txtPass.Text = ""; txtUsuario.Text = ""; cbxTipo.SelectedIndex = cbxTipo.FindStringExact(""); txtTel.Text = "";
                    cboTipoProd.SelectedIndex = cboTipoProd.FindStringExact("");
                    txtaddCI.Focus();
                }
            else{
                ConexionSQLN conexionSQLN = new ConexionSQLN();
                conexionSQLN.ConsultaDT(dtTabla);
                    ; txtNombre.Text = ""; txtApe.Text = ""; txtCalle.Text = ""; txtNpuerta.Text = ""; txtPass.Text = ""; txtUsuario.Text = ""; cbxTipo.SelectedIndex = cbxTipo.FindStringExact("");txtTel.Text = "";
                    cboTipoProd.SelectedIndex = cboTipoProd.FindStringExact("");
                    txtaddCI.Focus();
                }
                }
            }
        


        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.letras(e);
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.numeros(e);
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            ConexionSQLN cn = new ConexionSQLN();
            cn.UpdateUser(txtaddCI, txtNombre, txtApe, txtUsuario, txtPass, txtCalle,txtNpuerta, txtTel);
            txtaddCI.Text = ""; txtNombre.Text = ""; txtApe.Text = ""; txtCalle.Text = ""; txtNpuerta.Text = ""; txtPass.Text = ""; txtUsuario.Text = ""; cbxTipo.SelectedIndex = cbxTipo.FindStringExact("");
            cboTipoProd.SelectedIndex = cboTipoProd.FindStringExact("");
            txtaddCI.Focus();
        }

        private void chbNuevo_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void chbNuevo_Click(object sender, EventArgs e)
        {
       
        }

        private void cbxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTipo.Text=="Productor") { lbltipoProd.Visible = true;cboTipoProd.Visible = true; 
            }else{
                lbltipoProd.Visible = false; cboTipoProd.Visible = false;
            }
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            ConexionSQLN cn = new ConexionSQLN();
            cn.ConsultHistorico(dtTabla);
        }
    }
}

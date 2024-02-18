using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Negocios;


namespace Proyecto
{
    public partial class Frm_FuncionesProductos : Form
    {
        
        public Frm_FuncionesProductos()
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
            Metodos.btnMod(btnMod);

        }
        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ConexionSQLN cn = new ConexionSQLN();
            cn.addprod(txtID,txtNombreProd,cbxTipo.Text,txtPrecio,txtStock);
            txtID.Text = "";
            txtNombreProd.Text = "";
            cbxTipo.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
        }
            

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            ConexionSQLN cn=new ConexionSQLN();
            cn.delprod(txtID.Text);
            txtID.Text = "";
            txtNombreProd.Text = "";
            cbxTipo.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";

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
                if (txtID.Text != "")
                {
                    ConexionSQLN conexionSQLN = new ConexionSQLN();
                    conexionSQLN.ConsultaProdBajaDT1(dtTabla, txtID);

                }
                else
                {
                    ConexionSQLN conexionSQLN = new ConexionSQLN();
                    conexionSQLN.ConsultaProdBajaDT(dtTabla);
                }

            }
            else
            {
                if (txtID.Text != "")
                {ConexionSQLN conexionSQLN = new ConexionSQLN();
                    conexionSQLN.ConsultaProdDT1(dtTabla, txtID);}
                else
                { ConexionSQLN conexionSQLN = new ConexionSQLN();
                    conexionSQLN.ConsultaProdDT(dtTabla); }
            }
    }

        private void txtNombreProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.letras(e);
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.numeros(e);
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.numeros(e);
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.numeros(e);
        }

        private void txtNombreNew_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.letras(e);
        }

        private void btnMod_Click(object sender, EventArgs e)
        { 
            ConexionSQLN conexionSQLN = new ConexionSQLN();
            conexionSQLN.UpdateProducto(txtID, txtNombreProd,cbxTipo.Text, txtPrecio, txtStock);
            txtID.Text = "";
            txtNombreProd.Text = "";
            cbxTipo.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
        }
                    
            
        }
    }
                 
       

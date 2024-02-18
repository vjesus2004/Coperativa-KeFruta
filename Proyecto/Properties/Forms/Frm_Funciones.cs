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
             
        private void txtaddID_TextChanged(object sender, EventArgs e)
        {
            
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

        private void Frm_Funciones_Load(object sender, EventArgs e)
        {
            pnlAdd.BackColor = Color.FromArgb   (100, 0, 0, 0);
            pnlDel.BackColor = Color.FromArgb(100, 0, 0, 0);
            pnlBuscar.BackColor = Color.FromArgb(100, 0, 0, 0);
            Metodos.btnMod(btnAdd);
            Metodos.btnMod(btnBuscar);
            Metodos.btnMod(btnEliminar);
            Metodos.btnMod(btnVolver);
            Metodos.btnMod(btnSalir);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string tipo="";
            if (cbxTipo.SelectedItem.Equals("Administrativo"))
            {tipo = "A"; }
            else
                if (cbxTipo.SelectedItem.Equals("Productor"))
                {tipo = "P"; }
            else{
                    if (cbxTipo.SelectedItem.Equals("Cliente"))
                    {tipo = "C"; }}
            ConexionSQLN conexionSQLN = new ConexionSQLN();
            conexionSQLN.adduser(txtNombre.Text,txtaddCI.Text,txtApe.Text,txtCalle.Text,txtNpuerta.Text,txtPass.Text,txtUsuario.Text,tipo);
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ConexionSQLN conexionSQLN=new ConexionSQLN();
            conexionSQLN.deluser(txtEliminar.Text);
        }
    }
}

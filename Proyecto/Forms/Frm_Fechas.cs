using System;
using System.Drawing;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Negocios;

namespace Proyecto
{
    public partial class Frm_Fechas : Form
    {
        
        public Frm_Fechas()
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
         
            Metodos.btnMod(btnSalir);
            Metodos.btnMod(btnVolver);
            Metodos.pnlTrasparencia(pnlContenedor);
        }

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNot_Click(object sender, EventArgs e)
        {
          
            DateTime d1= DateTime.Now;
            DateTime MaxFechaCosecha = DateTime.Now;
            DateTime MaxFechaCultiva = DateTime.Now;
            DateTime FechaCultiva = DateTime.ParseExact(txtCultiva.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None);
            DateTime FechaCosecha = DateTime.ParseExact(txtCosecha.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None);
            MaxFechaCosecha.AddYears(2);
            MaxFechaCultiva.AddYears(2);
            int a = DateTime.Compare(d1,FechaCultiva);
            int b = DateTime.Compare(d1, FechaCosecha);
            int c = DateTime.Compare(FechaCultiva, FechaCosecha);
            int d = DateTime.Compare(FechaCultiva, MaxFechaCultiva);
            int f = DateTime.Compare(FechaCosecha, MaxFechaCosecha);

            try { 
            if (a > 0 || b > 0 )
            {
                MessageBox.Show("Ingrese fechas futuras.");
            }else if (c > 0 )
            {
                 MessageBox.Show("La fecha de cosecha no puede ser anterior a la siembra");
                }
            else 
            {       ConexionSQLN conexionSQLN = new ConexionSQLN();
                    string tipo = cbxProd.Text;
                     conexionSQLN.fechasact(FechaCultiva,FechaCosecha,tipo);
               
            }
            }
            catch (Exception error) { MessageBox.Show(error.ToString()); }
            
            
       }

        private void txtCultiva_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.numeros(e);
        }

        private void txtCosecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            Metodos.numeros(e);
        }
    }
}

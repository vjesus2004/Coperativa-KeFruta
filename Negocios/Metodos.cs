using System;
using System.Drawing;
using System.Windows.Forms;
namespace Proyecto

{
    public class Metodos
    {
        public static void letras(KeyPressEventArgs e)
        {
            //condicion para solo letras
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            //para backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            //para que admita tecla de espacio
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            //si no cumple nada de lo anterior que no lo deje pasar
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten letras", "validación de texto",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public static void numeros( KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            //para tecla backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            //si no se cumple nada de lo anterior entonces que no lo deje pasar
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos numéricos", "validación de números"
                    , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public static void Vacio (TextBox txt,Label error)
        {
            if(txt.Text == "")
            {error.Visible = true;
            }

        }
        public static void pnlTrasparencia (Panel p)
        {
            p.BackColor = Color.FromArgb(100, 0, 0, 0);

        }

        public static void btnMod(Button b)
        {
            b.BackColor = Color.Black;
            b.ForeColor = Color.White;
            b.FlatAppearance.BorderColor =Color.White;
            b.FlatAppearance.MouseOverBackColor = Color.DarkOliveGreen;

        }
        
      
    }
}



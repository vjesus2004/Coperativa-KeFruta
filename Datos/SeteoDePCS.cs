using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Data.Odbc;

namespace Datos
{
 

    public class SeteoDePCS
    {
             static string conexionstring = "server = 192.168.2.53; database = jvillalba; Uid = jvillalba; pwd = 56251736";
             MySqlConnection con = new MySqlConnection(conexionstring);
        //Seteo de precios y stock
        Usuarios usuario = new Usuarios();
        public void SetPSManzana(Productos prod)
        {
            con.Open();
            string sql = "SELECT stock,precio FROM Productos WHERE nombre='Manzana'";
            MySqlCommand comando = new MySqlCommand(sql, con);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.Read() == true)
            {
                prod.STOCKmanzana = Convert.ToInt32(reader["stock"]);
                prod.PKmanzana = Convert.ToInt32(reader["precio"]);
            }con.Close();
        }
        public void SetPSnaranja(Productos prod)
        {
            con.Open();
            string sql = "SELECT stock,precio FROM Productos WHERE nombre=N'aranja'";
            MySqlCommand comando = new MySqlCommand(sql, con);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.Read() == true)
            {
                prod.STOCKnaranja = Convert.ToInt32(reader["stock"]);
                prod.PKnaranja = Convert.ToInt32(reader["precio"]);
            }
            con.Close();
        }
        public void SetPSlimones(Productos prod)
        {
            con.Open();
            
            string sql = "SELECT stock,precio FROM Productos WHERE nombre='Limones'";
            MySqlCommand comando = new MySqlCommand(sql, con);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.Read() == true)
            {
                prod.STOCKlimones = Convert.ToInt32(reader["stock"]);
                prod.PKlimones = Convert.ToInt32(reader["precio"]);
            }
            con.Close();
        }
        public void SetPSpapa(Productos prod)
        {
            con.Open();
            string sql = "SELECT stock,precio FROM Productos WHERE nombre='Papa Rosada'";
            MySqlCommand comando = new MySqlCommand(sql, con);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.Read() == true)
            {
                prod.STOCKpapas = Convert.ToInt32(reader["stock"]);
                prod.PKpapas = Convert.ToInt32(reader["precio"]);
            }
            con.Close();
        }
        public void SetPSzapallo(Productos prod)
        {
            con.Open();
            string sql = "SELECT stock,precio FROM Productos WHERE nombre='Zapallo Criollo'";
            MySqlCommand comando = new MySqlCommand(sql, con);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.Read() == true)
            {
                prod.STOCKzapallo = Convert.ToInt32(reader["stock"]);
                prod.PKzapallo = Convert.ToInt32(reader["precio"]);
            }
            con.Close();
        }
        public void SetPSCebada(Productos prod)
        {
            con.Open();
            string sql = "SELECT stock,precio FROM Productos WHERE nombre='Cebada'";
            MySqlCommand comando = new MySqlCommand(sql, con);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.Read() == true)
            {
                prod.STOCKcebada = Convert.ToInt32(reader["stock"]);
                prod.PKcebada = Convert.ToInt32(reader["precio"]);
            }
            con.Close();
        }
        public void SetPSTrigo(Productos prod)
        {
            con.Open();
            string sql = "SELECT stock,precio FROM Productos WHERE nombre='Trigo'";
            MySqlCommand comando = new MySqlCommand(sql, con);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.Read() == true)
            {
                prod.STOCKtrigo = Convert.ToInt32(reader["stock"]);
                prod.PKtrigo = Convert.ToInt32(reader["precio"]);
            }
            con.Close();
        }
        public void SetPSFert(Productos prod)
        {
            con.Open();
            string sql = "SELECT stock,precio FROM Productos WHERE nombre='Fertilizante'";
            MySqlCommand comando = new MySqlCommand(sql, con);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.Read() == true)
            {
                prod.STOCKfertilizante = Convert.ToInt32(reader["stock"]);
                prod.PKfertilizante = Convert.ToInt32(reader["precio"]);
            }
            con.Close();
        }
        public void SetPSFungicida(Productos prod)
        {
            con.Open();
            string sql = "SELECT stock,precio FROM Productos WHERE nombre='Fungicida'";
            MySqlCommand comando = new MySqlCommand(sql, con);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.Read() == true)
            {
                prod.STOCKfungicida = Convert.ToInt32(reader["stock"]);
                prod.PKfungicida = Convert.ToInt32(reader["precio"]);
            }
            con.Close();
        }
        public void SetPSSemillas(Productos prod)
        {
            con.Open();
            string sql = "SELECT stock,precio FROM Productos WHERE nombre='Plantines'";
            MySqlCommand comando = new MySqlCommand(sql, con);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.Read() == true)
            {
                prod.STOCKsemillas = Convert.ToInt32(reader["stock"]);
                prod.PKsemillas = Convert.ToInt32(reader["precio"]);
            }
            con.Close();
        }
        int a=0;
        public void stock(Productos prod) {

            
            if(prod.STOCKlimones < prod.CANTlimones    || prod.STOCKmanzana < prod.CANTmanzana                   ||
                prod.STOCKnaranja < prod.CANTnaranja   || prod.STOCKpapas < prod.CANTpapas                       ||
                prod.STOCKzapallo < prod.CANTzapallo   || prod.STOCKcebada < prod.CANTcebada                     ||
                prod.STOCKtrigo < prod.CANTtrigo       || prod.STOCKfertilizante < prod.CANTfertilizante         ||
                prod.STOCKsemillas < prod.CANTsemillas || prod.STOCKfungicida < prod.CANTfungicida                 )
            {
                a = 1;
                    MessageBox.Show("no contamos con stock actualmente, profavor intente mas tarde"); 
            }else if(prod.STOCKlimones > prod.CANTlimones && prod.STOCKmanzana > prod.CANTmanzana &&
                prod.STOCKnaranja > prod.CANTnaranja && prod.STOCKpapas > prod.CANTpapas &&
                prod.STOCKzapallo > prod.CANTzapallo && prod.STOCKcebada > prod.CANTcebada &&
                prod.STOCKtrigo > prod.CANTtrigo && prod.STOCKfertilizante > prod.CANTfertilizante &&
                prod.STOCKsemillas > prod.CANTsemillas && prod.STOCKfungicida > prod.CANTfungicida) {
                
            }

            
        }

          public void Factura(Productos prod,ListBox lst){
            if (a == 0) { 
           prod.PTotal = prod.CANTmanzana * prod.PKmanzana
         + prod.CANTnaranja * prod.PKnaranja
         + prod.CANTlimones * prod.PKlimones
         + prod.CANTpapas * prod.PKpapas
         + prod.CANTzapallo * prod.PKzapallo
         + prod.CANTcebada * prod.PKcebada
         + prod.CANTtrigo * prod.PKtrigo
         +prod.CANTfertilizante*prod.PKfertilizante
         + prod.CANTsemillas * prod.PKsemillas
         + prod.CANTfungicida * prod.PKfungicida;
           prod.CANTTotal = prod.CANTnaranja + prod.CANTlimones + prod.CANTpapas + prod.CANTzapallo + prod.CANTcebada + prod.CANTtrigo;


            lst.Items.Clear();  
            lst.Items.Add("Se ha procesado su factura:");
            lst.Items.Add("---------------------------");
            if (prod.CANTmanzana >0)
            {
             lst.Items.Add(prod.CANTmanzana + " Kg de Manzana $" + prod.PKmanzana+ "C/u");
            }
            if (prod.CANTnaranja > 0)
            {
                lst.Items.Add(prod.CANTnaranja+ " Kg de Naranja $" + prod.PKnaranja + "C/u");
            }
            if (prod.CANTlimones > 0)
            {
                lst.Items.Add(prod.CANTlimones+ " Kg de Limones $" + prod.PKlimones + "C/u");
            }
            if (prod.CANTpapas > 0)
            {
                lst.Items.Add(prod.CANTpapas + " Kg de Papas $" + prod.PKpapas + "C/u");
            }
            if (prod.CANTzapallo > 0)
            {
                lst.Items.Add(prod.CANTzapallo+ " Kg de zapallo $" + prod.PKzapallo + "C/u");
            }
            if (prod.CANTcebada > 0)
            {
                lst.Items.Add(prod.CANTcebada+" Kg  de cebada $"+prod.PKcebada + "C/u");
            }
            if (prod.CANTtrigo > 0)
            {
                lst.Items.Add(prod.CANTtrigo + " Kg de trigo $"+prod.PKtrigo + "C/u");
            }
            if (prod.CANTfertilizante > 0)
            {
                lst.Items.Add(prod.CANTfertilizante + " Kg de fertilizante $" + prod.PKfertilizante + "C/u");
            }
            if (prod.CANTsemillas > 0)
            {
                lst.Items.Add(prod.CANTsemillas + " Kg de semillas $" + prod.PKsemillas + "C/u");
            }
            if (prod.CANTfungicida > 0) 
            {
                lst.Items.Add(prod.CANTfungicida + " Kg de fungicida $" + prod.PKfungicida+ "C/u");
            }
            lst.Items.Add("-------------------------------");
            lst.Items.Add("Total mas impuestos: $"+prod.PTotal );
            if (prod.CANTmanzana > 0)
            {
                prod.StringCod.Add("002");
            }
            if (prod.CANTnaranja > 0)
            {
               prod.StringCod.Add("007");
            }
            if (prod.CANTlimones > 0)
            {
                prod.StringCod.Add("005");
            }
            if (prod.CANTpapas > 0)
            {
                prod.StringCod.Add("001");
            }
            if (prod.CANTzapallo > 0)
            {
                prod.StringCod.Add("004");
            }
            if (prod.CANTcebada > 0)
            {
                prod.StringCod.Add("006");
            }
            if (prod.CANTtrigo > 0)
            {prod.StringCod.Add("003");
            }
            if (prod.CANTfertilizante > 0)
            {
                prod.StringCod.Add("009");
            }
            if (prod.CANTsemillas > 0)
            {
                prod.StringCod.Add("008");
            }
            if (prod.CANTfungicida > 0)
            {
                prod.StringCod.Add("010");
            }
            //cant
            if (prod.CANTmanzana > 0)
            {
                prod.StringCant.Add(prod.CANTmanzana.ToString());
            }
            if (prod.CANTnaranja > 0)
            {
                prod.StringCant.Add(prod.CANTnaranja.ToString());
            }
            if (prod.CANTlimones > 0)
            {
                prod.StringCant.Add(prod.CANTlimones.ToString()); 
            }
            if (prod.CANTpapas > 0)
            {
                prod.StringCant.Add(prod.CANTpapas.ToString());
            }
            if (prod.CANTzapallo > 0)
            {
                prod.StringCant.Add(prod.CANTzapallo.ToString());
            }
            if (prod.CANTcebada > 0)
            {
                prod.StringCant.Add(prod.CANTcebada.ToString());
            }
            if (prod.CANTtrigo > 0)
            {
                prod.StringCant.Add(prod.CANTtrigo.ToString());
            }
            if (prod.CANTfertilizante > 0)
            {
                prod.StringCant.Add(prod.CANTfertilizante.ToString());
            }
            if (prod.CANTsemillas > 0)
            {
                prod.StringCant.Add(prod.CANTsemillas.ToString());
            }
            if (prod.CANTfungicida > 0)
            {
                prod.StringCant.Add(prod.CANTfungicida.ToString());
            }
            }
        }
        public Usuarios ConsultaPorUser(string user)
        {
            con.Open();
            Usuarios usuario = new Usuarios();
            string sql = "SELECT * FROM Persona WHERE usuario=@user";
            MySqlCommand comando = new MySqlCommand(sql, con);
            comando.Parameters.AddWithValue("@user", user);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.Read() == true)
            {

                usuario.CI = reader["ci"].ToString();
                usuario.Nombre = reader["nombre"].ToString();
                usuario.Apellido = reader["apellido"].ToString();
                usuario.Usuario = reader["usuario"].ToString();
                usuario.Password = reader["contrasenia"].ToString();
                usuario.Calle = reader["calle"].ToString();
                usuario.N_Puerta = reader["n_Puerta"].ToString();
                usuario.Rol = reader["rol"].ToString();
                
            }
            else
            {
                MessageBox.Show("el usuario no existe");
            }
            con.Close();
            return usuario;
        }
        public void AddCompra(Usuarios u, Productos p)
        {
            con.Open();
            string sql = "INSERT INTO Compras (ciProd,cod_prod,cantidad,fecha) VALUES(@ciProd,@cod_prod,@cantidad,@fecha);" +
                "INSERT INTO ventaproducto (cod_prod,idVentas,cant,total) VALUES(@cod_prod,@cod,@cantidad,@total);" +
                         "INSERT INTO HISTORICO(nom_op,tabla,ci_op,fecha) VALUES ('INSERT','Compra',@ci,@fecha);" +
                         "INSERT INTO HISTORICO(nom_op,tabla,ci_op,fecha) VALUES ('INSERT','ventaProducto',@ci,@fecha);";
            MySqlCommand comando = new MySqlCommand(sql, con);

            for (int i=0; i < p.StringCod.Count; i++)
            {string code=p.StringCod[i];
                string cant = p.StringCant[i];
                comando.Parameters.AddWithValue("@cod_prod", code);
                comando.Parameters.AddWithValue("@cod", u.Cod_Compra);
                comando.Parameters.AddWithValue("@total", p.PTotal);
                comando.Parameters.AddWithValue("@ciProd", u.CI);
                comando.Parameters.AddWithValue("@ci", u.CI);
                comando.Parameters.AddWithValue("@cantidad", cant);
                comando.Parameters.AddWithValue("@fecha", DateTime.Now.ToString("yyyy'-'MM'-'dd HH:mm:ss"));
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                
            }
            con.Close();
            
        
        }
        public string Selectidventa(Usuarios u)
        {
            con.Open();
            string sql = "SELECT cod_compra FROM Compras ORDER BY cod_compra DESC  LIMIT 1 ";
            MySqlCommand comando = new MySqlCommand(sql, con);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.Read() == true)
            {
                u.Cod_Compra = reader["cod_compra"].ToString();
            }
            con.Close();
            return u.Cod_Compra;


        }

    }

}


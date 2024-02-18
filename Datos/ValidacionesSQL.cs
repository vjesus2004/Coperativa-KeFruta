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


namespace Datos
{
    public class ValidacionesSQL
    {


        static string conexionstring = "server = 192.168.2.53; database = jvillalba; Uid = jvillalba; pwd = 56251736";
        MySqlConnection con = new MySqlConnection(conexionstring);

        public void existeUsuario(Usuarios usuario)
        {
            MySqlDataReader reader;
            con.Open();
            string sql = "SELECT ci FROM Persona WHERE ci LIKE @ci";
            MySqlCommand comando = new MySqlCommand(sql, con);
            comando.Parameters.AddWithValue("@ci", usuario.CI);
            reader = comando.ExecuteReader();
           
            if (reader.HasRows)
            {   usuario.ExUsuario = 1;
                if (usuario.ExUsuario == 1)
                {
                    MessageBox.Show("Esa CI ya esta registrada");
                }
            }
            else { usuario.ExUsuario = 0; }
            con.Close();

        }
        public void existeUsername(Usuarios usuario)
        {
            MySqlDataReader reader;
            con.Open();
            string sql = "SELECT usuario FROM Persona WHERE usuario LIKE @user";
            MySqlCommand comando = new MySqlCommand(sql, con);
            comando.Parameters.AddWithValue("@user", usuario.Usuario);
            reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                usuario.ExUsuario = 1;
                if (usuario.ExUsuario == 1)
                {
                    MessageBox.Show("El usuario ya existe");
                }
            }
            else { usuario.ExUsuario = 0; }
            con.Close();

        }
        public void existeUsuarioBaja(Usuarios usuario)
        {
            MySqlDataReader reader;
            con.Open();
            string sql = "SELECT ci FROM Persona WHERE ci LIKE @ci AND baja LIKE 1";
            MySqlCommand comando = new MySqlCommand(sql, con);
            comando.Parameters.AddWithValue("@ci", usuario.CI);
            reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                usuario.ExUserBaja = 1;
                if (usuario.ExUserBaja == 1)
                {
                    MessageBox.Show("Usuario Dado de Alta");
                }
            }
            else { usuario.ExUserBaja = 0; }
            con.Close();

        }
        public void existeTel(Usuarios usuario)
        {
            MySqlDataReader reader;
            con.Open();
            string sql = "SELECT telefono FROM PersTelefono WHERE telefono LIKE @user";
            MySqlCommand comando = new MySqlCommand(sql, con);
            comando.Parameters.AddWithValue("@user", usuario.Telefono);
            reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                usuario.ExUsuario = 1;
                if (usuario.ExUsuario == 1)
                {
                    MessageBox.Show("El Telefono ya existe");
                }
            }
            else { usuario.ExUsuario = 0; }
            con.Close();

        }
        public void NoExisteUsuario(Usuarios usuario)
        {
            MySqlDataReader reader;
            con.Open();
            string sql = "SELECT ci FROM Persona WHERE ci LIKE @ci";
            MySqlCommand comando = new MySqlCommand(sql, con);
            comando.Parameters.AddWithValue("@ci", usuario.CI);
            reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                usuario.ExUsuario = 1;
                if (usuario.ExUsuario != 1)
                {
                    MessageBox.Show("El productor no existe");
                }
            }
            else { usuario.ExUsuario = 1; }
            con.Close();

        }



        public void existeProd(Usuarios usuario)
        {
            MySqlDataReader reader;
            con.Open();
            string sql = "SELECT cod_prod FROM Productos WHERE cod_prod LIKE @cod";
            MySqlCommand comando = new MySqlCommand(sql, con);
            comando.Parameters.AddWithValue("@cod", usuario.IdProd);

            reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                usuario.ExUsuario = 1;
                if (usuario.ExUsuario == 1)
                {
                    MessageBox.Show("El Producto ya existe");
                }
            }
            else { usuario.ExUsuario = 0; }
            con.Close();
        }
        public void NoExisteProd(Usuarios usuario)
        {
            MySqlDataReader reader;
            con.Open();
            string sql = "SELECT cod_prod FROM Productos WHERE cod_prod LIKE @cod";
            MySqlCommand comando = new MySqlCommand(sql, con);
            comando.Parameters.AddWithValue("@cod", usuario.IdProd);

            reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                usuario.ExisteProd = 1;
                if (usuario.ExisteProd != 1)
                {
                    MessageBox.Show("El Producto no existe");
                }
            }
            else { usuario.ExisteProd = 0; }
            con.Close();
        }
        public void NoExisteVenta(Usuarios usuario)
        {
            MySqlDataReader reader;
            con.Open();
            string sql = "SELECT idVentas FROM Ventas WHERE idVentas LIKE @id";
            MySqlCommand comando = new MySqlCommand(sql, con);
            comando.Parameters.AddWithValue("@id", usuario.IdVenta);
            reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                usuario.ExisteVenta = 1;
                if (usuario.ExisteVenta != 1)
                {
                    MessageBox.Show("La venta no existe");
                }
            }
            else { usuario.ExisteVenta = 0; }
            con.Close();
        }
        public void existeSector(Usuarios usuario)
        {
            MySqlDataReader reader;
            con.Open();
            string sql = "SELECT idSector FROM Sectores WHERE idSector LIKE @idsector";
            MySqlCommand comando = new MySqlCommand(sql, con);
            comando.Parameters.AddWithValue("@idsector", usuario.IdSector);
            reader = comando.ExecuteReader();
            if (reader.HasRows){usuario.ExUsuario = 1;
                if (usuario.ExUsuario == 1)
                {MessageBox.Show("El sector ya existe");}
            }
            else { usuario.ExUsuario = 0; }
            con.Close();
        }
        public void SectorNoProd(Usuarios usuario)
        {
            MySqlDataReader reader;
            con.Open();
            string sql = "SELECT rol FROM Persona WHERE ci LIKE @ci";
            MySqlCommand comando = new MySqlCommand(sql, con);
            comando.Parameters.AddWithValue("@ci", usuario.CI);
            reader = comando.ExecuteReader();
          
            if (reader.Read() == true)
            {
                usuario.Rol = reader["rol"].ToString();
            }
            else
            {if (usuario.Rol != "R") {MessageBox.Show("El usuario no es un productor");}
               
            }
            con.Close();
        }
        private string generarSHA1(string cadena)
        {
            UTF8Encoding enc = new UTF8Encoding();
            byte[] data = enc.GetBytes(cadena);
            byte[] result;

            SHA1CryptoServiceProvider sha = new SHA1CryptoServiceProvider();

            result = sha.ComputeHash(data);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {

                if (result[i] < 16)
                {
                    sb.Append("0");
                }
                sb.Append(result[i].ToString("x"));
            }

            return sb.ToString();
        }
        public void SelectTipoProductor(Usuarios usuario)
        {
            MySqlDataReader reader;
            con.Open();
            string sql = "SELECT tipoProduccion FROM Persona WHERE ci=@ci";
            MySqlCommand comando = new MySqlCommand(sql, con);
            comando.Parameters.AddWithValue("@ci", usuario.CI);
            reader = comando.ExecuteReader();
            if (reader.Read() == true)
            {
                usuario.TipoProduccion = reader["tipoProduccion"].ToString();
            }
            con.Close();
        }
        public void SelectTipoProductorPorUser(Usuarios usuario)
        {
            MySqlDataReader reader;
            con.Open();
            string sql = "SELECT tipoProduccion FROM Persona WHERE usuario=@user";
            MySqlCommand comando = new MySqlCommand(sql, con);
            comando.Parameters.AddWithValue("@user", usuario.Usuario);

            reader = comando.ExecuteReader();
            if (reader.Read() == true)
            {
                usuario.TipoProduccion = reader["tipoProduccion"].ToString();

            }
            con.Close();
        }
        public void AddCompra(Usuarios usuario)
        {
            MySqlDataReader reader;
            con.Open();
            string sql = "SELECT tipoProduccion FROM Persona WHERE usuario=@user";
            MySqlCommand comando = new MySqlCommand(sql, con);
            comando.Parameters.AddWithValue("@user", usuario.Usuario);

            reader = comando.ExecuteReader();
            if (reader.Read() == true)
            {
                usuario.TipoProduccion = reader["tipoProduccion"].ToString();

            }
            else
            {

            }
            con.Close();
        }
        public void ConsutlComprasPendientes(DataGridView dt)
        {
            con.Open();
            string sql = "SELECT cod_compra, ciProd, cod_prod,cantidad FROM Compras WHERE pendiente = 1";
            MySqlCommand comando = new MySqlCommand(sql, con);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            dt.DataSource = tabla;
            con.Close();
        }
    }
 }


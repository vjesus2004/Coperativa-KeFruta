using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Globalization;

namespace Datos

{
    public class ConexionSQL
    {    
        
            static string conexionstring= "server = 192.168.2.53; database = jvillalba; Uid = jvillalba; pwd = 56251736";
            MySqlConnection con = new MySqlConnection(conexionstring);
            
    public int consultaLogin (string user, string pass)
        {
            int count;
            con.Open();
            string query = "Select count(*) from Persona where usuario = '" + user + "' and contrasenia ='" + pass +"'";
            MySqlCommand cmd = new MySqlCommand(query, con);
            count = Convert.ToInt32(cmd.ExecuteScalar());

            con.Close();
            return count;
        }
        public string consultaRol(string user, string pass)
        {
            string rol;
            con.Open();
            string query = "Select rol from Persona where usuario = '" + user + "' and contrasenia ='" + pass + "'";
            MySqlCommand cmd = new MySqlCommand(query, con);
            rol = Convert.ToString(cmd.ExecuteScalar());
            con.Close();
            return rol;        
        }

       
        public int registro(Usuarios usuario)
        {
            con.Open();
         

            string sql = "INSERT INTO Persona (ci,nombre, apellido,usuario,contrasenia,calle,n_Puerta,rol,tipoProduccion,baja) " +
                "VALUES(@ci, @nombre, @apellido, @Usuario, @contraseña, @calle, @n_Puerta,@rol,@tipoProduccion, 0);" +
                         "INSERT INTO HISTORICO(nom_op,tabla,ci_op,fecha) VALUES ('INSERT','Productos',@ci,@fecha);"; ;
            MySqlCommand comando = new MySqlCommand(sql, con);
            comando.Parameters.AddWithValue("@usuario", usuario.Usuario);
            comando.Parameters.AddWithValue("@contraseña", usuario.Password);
            comando.Parameters.AddWithValue("@nombre", usuario.Nombre);
            comando.Parameters.AddWithValue("@apellido", usuario.Apellido);
            comando.Parameters.AddWithValue("@calle", usuario.Calle);
            comando.Parameters.AddWithValue("@n_Puerta", usuario.N_Puerta);
            comando.Parameters.AddWithValue("@rol", usuario.Rol);
            comando.Parameters.AddWithValue("@tipoProduccion",usuario.TipoProduccion);
            comando.Parameters.AddWithValue("@ci", usuario.CI);
            comando.Parameters.AddWithValue("@fecha", DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss"));

            int resultado = comando.ExecuteNonQuery();
            if (resultado != -1){
                MessageBox.Show("Usuario registrado con exito");
            }
            con.Close();
            return resultado;
        }
        public int registroAlta(Usuarios usuario)
        {
            con.Open();

            string sql = "UPDATE Persona SET baja=1 WHERE ci=@ci;" +
                         "INSERT INTO HISTORICO(nom_op,tabla,ci_op,fecha) VALUES ('UPDATE','Persona',@ci,@fecha);"; ;
            MySqlCommand comando = new MySqlCommand(sql, con);
            comando.Parameters.AddWithValue("@ci", usuario.CI);
            comando.Parameters.AddWithValue("@fecha", DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss"));

            int resultado = comando.ExecuteNonQuery();
            if (resultado != -1)
            {
                MessageBox.Show("Usuario registrado con exito");
            }
            con.Close();
            return resultado;
        }

        public int registroProd(Usuarios usuario)
        {
            con.Open();
            string sql = "INSERT INTO Productos (cod_prod,nombre,tipo,precio,stock,baja) VALUES(@cod, @nombre, @tipo, @precio, @stock,0);" +
                         "INSERT INTO HISTORICO(nom_op,tabla,ci_op,fecha) VALUES ('INSERT','Productos',@ci,@fecha);" ;
            MySqlCommand comando = new MySqlCommand(sql, con);
            comando.Parameters.AddWithValue("@cod", usuario.CodProd);
            comando.Parameters.AddWithValue("@nombre", usuario.NombreProd);
            comando.Parameters.AddWithValue("@tipo", usuario.TipoProd);
            comando.Parameters.AddWithValue("@precio", usuario.PrecioProd);
            comando.Parameters.AddWithValue("@stock", usuario.StockProd);
            comando.Parameters.AddWithValue("@ci", usuario.CI);
            comando.Parameters.AddWithValue("@fecha", DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss"));
            int resultado = comando.ExecuteNonQuery();
            if (resultado != -1){MessageBox.Show("Producto registrado con exito");}
            con.Close();
            return resultado;
        }

        
        public int DeleteUser(Usuarios usuario)
        {
            con.Open();


            string sql = "UPDATE Persona SET baja=1 WHERE ci=@ci;" +
                         "INSERT INTO HISTORICO(nom_op,tabla,ci_op,fecha) VALUES ('UPDATE','Persona',@ci,@fecha);";
            MySqlCommand comando = new MySqlCommand(sql, con);

            comando.Parameters.AddWithValue("@ci", usuario.CI);
            comando.Parameters.AddWithValue("@fecha", DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss"));
            int resultado = comando.ExecuteNonQuery();
            if (resultado != -1)
            {
                MessageBox.Show("Usuario eliminado con exito");
            }
            con.Close();
            return resultado;
        }
        public int DeleteProd(Usuarios usuario)
        {
            con.Open();


            string sql = "UPDATE Productos SET baja=1 WHERE cod_prod=@cod;";
            MySqlCommand comando = new MySqlCommand(sql, con);

            comando.Parameters.AddWithValue("@cod", usuario.CodProd);

            int resultado = comando.ExecuteNonQuery();
            if (resultado != -1)
            {
                MessageBox.Show("Producto dado de baja exito");
            }
            con.Close();
            return resultado;
        }

        public int ConsultaUsuario(Usuarios usuario)
        {
            con.Open();
    
            string sql = "SELECT * FROM Persona WHERE ci = @ci";
            MySqlCommand comando = new MySqlCommand(sql, con);
            comando.Parameters.AddWithValue("@ci", usuario.CI);
            MySqlDataReader reader = comando.ExecuteReader();
            int a = 0 ;
            if (reader.Read() == true){
             
                usuario.CI = reader["ci"].ToString();
                usuario.Nombre = reader["nombre"].ToString();
                usuario.Apellido = reader["apellido"].ToString();
                usuario.Usuario = reader["usuario"].ToString();
                usuario.Password = reader["contrasenia"].ToString();
                usuario.Calle = reader["calle"].ToString();
                usuario.N_Puerta = reader["n_Puerta"].ToString();
                usuario.Rol = reader["rol"].ToString();
                
            } else{
                MessageBox.Show("el usuario no existe");
            }
            con.Close();
           
            return a;
        }
        public void ConsultaUsuarioDataGrid(DataGridView dt)
        {   
            con.Open();
            string sql = "SELECT p.ci,nombre,apellido,pt.telefono,usuario,contrasenia,calle,n_puerta,rol,tipoProduccion FROM Persona p INNER JOIN PersTelefono pt ON p.ci=pt.ci WHERE p.baja = 0 ";
            MySqlCommand comando = new MySqlCommand(sql, con);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            dt.DataSource = tabla;
            con.Close();
        }
        public void ConsultaUsuarioDataGrid1(DataGridView dt,Usuarios usuario)
        {
            con.Open();
 
            string sql = "SELECT p.ci,nombre,apellido,pt.telefono,usuario,contrasenia,calle,n_puerta,rol FROM Persona p INNER JOIN PersTelefono pt ON p.ci=pt.ci  WHERE p.ci=@ci AND p.baja=1";
            MySqlCommand comando = new MySqlCommand(sql, con);
            comando.Parameters.AddWithValue("@ci", usuario.CI);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            dt.DataSource = tabla;
            con.Close();
            
        }
        public void ConsultaUsuarioBajaDataGrid(DataGridView dt)
        {
            con.Open();
            string sql = "SELECT p.ci,nombre,apellido,pt.telefono,usuario,contrasenia,calle,n_puerta,rol,baja FROM Persona p INNER JOIN PersTelefono pt ON p.ci=pt.ci AND baja=1 ";
            MySqlCommand comando = new MySqlCommand(sql, con);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            dt.DataSource = tabla;
            con.Close();
        }
        public void ConsultaUsuarioBajaDataGrid1(DataGridView dt, Usuarios usuario)
        {
            con.Open();

            string sql = "SELECT p.ci,nombre,apellido,pt.telefono,usuario,contrasenia,calle,n_puerta,rol,baja FROM Persona p INNER JOIN PersTelefono pt ON p.ci=pt.ci  WHERE ci=@ci AND baja=1";
            MySqlCommand comando = new MySqlCommand(sql, con);
            comando.Parameters.AddWithValue("@ci", usuario.CI);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            dt.DataSource = tabla;
            con.Close();

        }

        public Usuarios ConsultaPorUser( string user)
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
                con.Close();
                usuario.Telefono = BuscarTel(usuario.CI);
                usuario.TipoCosecha = BuscartipoProd(usuario.CI);
                }
            else
            {
                MessageBox.Show("el usuario no existe");
            }
           
            return usuario;
        }
        public Usuarios Hectareas(string id,TextBox txt)
        {
            con.Open();
            Usuarios usuario = new Usuarios();
            string sql = "SELECT tamanio FROM Sectores WHERE idSector=@id";
            MySqlCommand comando = new MySqlCommand(sql, con);
            comando.Parameters.AddWithValue("@id", id);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.Read() == true)
            {

                usuario.Tsector = Convert.ToInt32(reader["tamanio"]);
                txt.Text = reader["tamanio"].ToString();
            }
                con.Close();

            return usuario;
        }
        public Usuarios HectareasFert(string id)
        {
            con.Open();
            Usuarios usuario = new Usuarios();
            string sql = "SELECT tamanio FROM Sectores WHERE idSector=@id";
            MySqlCommand comando = new MySqlCommand(sql, con);
            comando.Parameters.AddWithValue("@id", id);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.Read() == true)
            {

                usuario.Tsector = Convert.ToInt32(reader["tamanio"]);
                
            }
        con.Close();
            return usuario;
        }
        public Usuarios EstadoSector(string id, TextBox txt)
        {
            con.Open();
            Usuarios usuario = new Usuarios();
            string sql = "SELECT estado FROM Sectores WHERE idSector=@id";
            MySqlCommand comando = new MySqlCommand(sql, con);
            comando.Parameters.AddWithValue("@id", id);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.Read() == true)
            { usuario.Tsector = Convert.ToInt32(reader["estado"]);
                if (usuario.Tsector==1) {
                    txt.Text = "En Uso";
                   

                }else{ txt.Text = "En Descanso"; }
               

                
                con.Close();
            }

            return usuario;
        }
        public Usuarios ProxCosecha(string id, ComboBox cbx)
        {
            con.Open();
            Usuarios usuario = new Usuarios();
            string sql = "SELECT proxCosecha FROM Sectores WHERE idSector=@id";
            MySqlCommand comando = new MySqlCommand(sql, con);
            comando.Parameters.AddWithValue("@id", id);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.Read() == true)
            {
                cbx.Items.Add(reader["proxCosecha"].ToString());
                cbx.SelectedText = "";
                cbx.SelectedText = (reader["proxCosecha"].ToString());
            }
            con.Close();
            return usuario;
        }
        public string BuscarTel(string CI )
        {
            con.Open();
         
            string sql = "SELECT telefono FROM PersTelefono WHERE ci=@ci";
            MySqlCommand comando = new MySqlCommand(sql, con);
            comando.Parameters.AddWithValue("@ci", CI);
            MySqlDataReader reader = comando.ExecuteReader();
            string telefono = "";
            if (reader.Read() == true)
            {
                telefono = reader["telefono"].ToString();
            }
            con.Close();
       
            return telefono;
        }

        public string BuscartipoProd(string CI)
        {
            con.Open();
            string sql = "SELECT tipoCosecha FROM PersonaCosecha p INNER JOIN cosechas c ON p.idCosecha=c.idCosecha WHERE ci=@ci;";
            MySqlCommand comando = new MySqlCommand(sql, con);
            comando.Parameters.AddWithValue("@ci", CI);
            MySqlDataReader reader = comando.ExecuteReader();
            string tipoCosecha = "";
            if (reader.Read() == true)
            {
                tipoCosecha = reader["tipoCosecha"].ToString();
            }
           
            con.Close();
            return tipoCosecha;
        }
        public int Update(Usuarios usuario)
        {
            con.Open();


            string sql = "UPDATE Cosechas SET fechaCultivos = @fechacultivo, fechaCosecha = @fechacosecha WHERE TipoCosecha = @tipocosecha; " +
                         "INSERT INTO HISTORICO(nom_op,tabla,ci_op,fecha) VALUES ('UPDATE','Cosecha',@ci,@fecha);";
            MySqlCommand comando = new MySqlCommand(sql, con);
            comando.Parameters.AddWithValue("@ci", usuario.CI);
            comando.Parameters.AddWithValue("@fecha", DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss"));
            comando.Parameters.AddWithValue("@fechacosecha", usuario.fechaCosecha);
            comando.Parameters.AddWithValue("@fechacultivo", usuario.fechaCultivo);
            comando.Parameters.AddWithValue("@tipoCosecha", usuario.TipoCosecha);


            int resultado = comando.ExecuteNonQuery();
            if (resultado != -1)
            {
                MessageBox.Show("Fechas de "+usuario.TipoCosecha+" actualizadas");

            }
            con.Close();
            return resultado;
        }
        public int registroTel(Usuarios usuario)
        {
            con.Open();


            string sql = "INSERT INTO perstelefono (ci,telefono) VALUES(@ci,@tel); "+
                         "INSERT INTO HISTORICO(nom_op,tabla,ci_op,fecha) VALUES ('INSERT','perstelefono',@ci,@fecha);";
            MySqlCommand comando = new MySqlCommand(sql, con);
            comando.Parameters.AddWithValue("@ci", usuario.CI);
            comando.Parameters.AddWithValue("@fecha", DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss"));
            comando.Parameters.AddWithValue("@tel", usuario.Telefono);

            int resultado = comando.ExecuteNonQuery();
           
            con.Close();
            return resultado;
        }


        public void SelectFecha(Usuarios usuario)
        {
            con.Open();
            string sql = "SELECT fechaCultivos,fechaCosecha FROM Cosechas WHERE tipoCosecha=@tipocosecha";
            MySqlCommand comando = new MySqlCommand(sql, con);
            comando.Parameters.AddWithValue("@tipoCosecha", usuario.TipoCosecha);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.Read() == true)
            {
                usuario.fechaCultivo = (DateTime)reader["fechaCultivos"];
                usuario.fechaCosecha = (DateTime)reader["fechaCosecha"];
            }
            con.Close();
        }
        public int UpdateUser(Usuarios usuario)
        {
            con.Open();
            string sql = "UPDATE Persona SET nombre=@nombre, apellido=@apellido,usuario=@usuario,contrasenia=@contrasenia,calle=@calle,n_Puerta=@n_Puerta,tipoProduccion=@tipo WHERE ci=@ci;" +
                         "INSERT INTO HISTORICO(nom_op,tabla,ci_op,fecha) VALUES ('UPDATE','Persona',@ci,@fecha);";
            MySqlCommand comando = new MySqlCommand(sql, con);
            comando.Parameters.AddWithValue("@ci", usuario.CI);
            comando.Parameters.AddWithValue("@fecha", DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss"));
            comando.Parameters.AddWithValue("@contrasenia", usuario.Password);
            comando.Parameters.AddWithValue("@usuario", usuario.Usuario);
            comando.Parameters.AddWithValue("@nombre", usuario.Nombre);
            comando.Parameters.AddWithValue("@apellido", usuario.Apellido);
            comando.Parameters.AddWithValue("@calle", usuario.Calle);
            comando.Parameters.AddWithValue("@n_Puerta", usuario.N_Puerta);
            comando.Parameters.AddWithValue("@tipo", usuario.TipoProduccion);
            int resultado = comando.ExecuteNonQuery();
            con.Close();
            return resultado;
        }
        public int UpdateUserTel(Usuarios usuario)
        {
            con.Open();
            string sql = "UPDATE PersTelefono SET telefono=@tel WHERE ci=@ci;" +
                         "INSERT INTO HISTORICO(nom_op,tabla,ci_op,fecha) VALUES ('UPDATE','PersTelefono',@ci,@fecha);";
            MySqlCommand comando = new MySqlCommand(sql, con);
            comando.Parameters.AddWithValue("@ci", usuario.CI);
            comando.Parameters.AddWithValue("@fecha", DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss"));
            comando.Parameters.AddWithValue("@tel", usuario.Telefono);
            int resultado = comando.ExecuteNonQuery();
            con.Close();
            return resultado;
        }
        public int UpdateProdTipo(Usuarios usuario)
        {
            con.Open();
            string sql = "UPDATE Cosechas SET TipoCosecha=@tipo WHERE idCosecha=@idcos" +
                         "INSERT INTO HISTORICO(nom_op,tabla,ci_op,fecha) VALUES ('UPDATE','Cosecha',@ci,@fecha);";
            MySqlCommand comando = new MySqlCommand(sql, con);
            comando.Parameters.AddWithValue("@ci", usuario.CI);
            comando.Parameters.AddWithValue("@fecha", DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss"));
            comando.Parameters.AddWithValue("@idcos", usuario.IdCosecha);
            comando.Parameters.AddWithValue("@tipo", usuario.TipoCosecha);
            int resultado = comando.ExecuteNonQuery();
            con.Close();
            return resultado;
        }

        public void GetIDCosecha(Usuarios usuario)
        {
            con.Open();
            string sql = "SELECT idCosecha FROM personacosecha WHERE ci=@ci";
            MySqlCommand comando = new MySqlCommand(sql, con);
            comando.Parameters.AddWithValue("@ci", usuario.CI);
            MySqlDataReader reader = comando.ExecuteReader();
            
            if (reader.Read() == true)
            {
              usuario.IdCosecha = reader["idCosecha"].ToString();
            }
            con.Close();
            
        }
        public void ConsultaProductoDataGrid(DataGridView dt)
        {
            con.Open();
            string sql = "SELECT cod_prod,nombre,tipo,precio,stock FROM Productos WHERE baja = 0 ";
            MySqlCommand comando = new MySqlCommand(sql, con);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            dt.DataSource = tabla;
            con.Close();
        }
        public void ConsultaProductoDataGrid1(DataGridView dt, Usuarios usuario)
        {
            con.Open();

            string sql = "SELECT cod_prod,nombre,tipo,precio,stock FROM Productos WHERE cod_prod=@idprod AND baja = 0 ";
            MySqlCommand comando = new MySqlCommand(sql, con);
            comando.Parameters.AddWithValue("@idprod", usuario.IdProd);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            dt.DataSource = tabla;
            con.Close();

        }
        public void ConsultaProductoBajaDataGrid(DataGridView dt)
        {
            con.Open();
            string sql = "SELECT cod_prod,nombre,tipo,precio,stock FROM Productos WHERE baja=1 ";
            MySqlCommand comando = new MySqlCommand(sql, con);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            dt.DataSource = tabla;
            con.Close();
        }
        public void ConsultaProductoBajaDataGrid1(DataGridView dt, Usuarios usuario)
        {
            con.Open();

            string sql = "SELECT cod_prod,nombre,tipo,precio,stock FROM Productos WHERE cod_prod=@idprod AND baja=1";
            MySqlCommand comando = new MySqlCommand(sql, con);
            comando.Parameters.AddWithValue("@idprod", usuario.IdProd);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            dt.DataSource = tabla;
            con.Close();
        
        }
        public void ConsultaSectorDataGrid(DataGridView dt)
        {
            con.Open();
            string sql = "SELECT s.idSector,p.ci,tamanio,C.tipoCosecha,estado FROM Sectores s INNER JOIN personacosecha p ON " +
                         "s.idsector=p.idsector INNER JOIN Cosechas c ON c.idcosecha=p.idcosecha";
            MySqlCommand comando = new MySqlCommand(sql, con);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            dt.DataSource = tabla;
            con.Close();
        }
        public void ConsultaSectorDataGrid1(DataGridView dt, Usuarios usuario)
        {
            con.Open();

            string sql = "SELECT s.idSector,p.ci,tamanio,C.tipoCosecha,estado FROM Sectores s INNER JOIN personacosecha p ON " +
                         "s.idsector=p.idsector INNER JOIN Cosechas c ON c.idcosecha=p.idcosecha WHERE s.idSector=@idsector";
            MySqlCommand comando = new MySqlCommand(sql, con);
            comando.Parameters.AddWithValue("@ci", usuario.CI);
            comando.Parameters.AddWithValue("@idsector", usuario.IdSector);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            dt.DataSource = tabla;
            con.Close();

        }
        public int registroSector(Usuarios usuario)
        {
            con.Open();
            string sql = "INSERT INTO Sectores (idsector,tamanio,proxCosecha,fertilizacion,estado) VALUES(@idsector,@tamaño,@proxCosecha,@fert,@estado);" +
                         "INSERT INTO HISTORICO(nom_op,tabla,ci_op,fecha) VALUES ('INSERT','Sectores',@ci,@fecha);";
            MySqlCommand comando = new MySqlCommand(sql, con);
            comando.Parameters.AddWithValue("@ci", usuario.CI);
            comando.Parameters.AddWithValue("@fecha", DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss"));
            comando.Parameters.AddWithValue("@idsector", usuario.IdSector);
            comando.Parameters.AddWithValue("@tamaño", usuario.Tsector);
            comando.Parameters.AddWithValue("@proxCosecha", usuario.ProxCosecha);
            if (usuario.ProxCosecha=="Trigo" || usuario.ProxCosecha == "Cebada")
            {
                comando.Parameters.AddWithValue("@fert", "--");
            }
            else { comando.Parameters.AddWithValue("@fert", ""); }
            comando.Parameters.AddWithValue("@estado", usuario.Esector);
            int resultado = comando.ExecuteNonQuery();
            con.Close();
            return resultado;
        }
        public int registroSectorPersona(Usuarios usuario)
        {
            con.Open();
            string sql = "INSERT INTO PersonaCosecha (ci,idsector,idcosecha) VALUES(@ci,@idsector,@idcosecha);" +
                         "INSERT INTO HISTORICO(nom_op,tabla,ci_op,fecha) VALUES ('INSERT','PersonaCosecha',@ci,@fecha);";
            MySqlCommand comando = new MySqlCommand(sql, con);
            comando.Parameters.AddWithValue("@fecha", DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss"));
            comando.Parameters.AddWithValue("@ci", usuario.CI);
            comando.Parameters.AddWithValue("@idsector", usuario.IdSector);
            comando.Parameters.AddWithValue("@idcosecha", usuario.IdCosecha);
            int resultado = comando.ExecuteNonQuery();
            con.Close();
            return resultado;
        }
        public int UpdateProducto(Usuarios usuario)
        {
            con.Open();
            string sql = "UPDATE Productos SET nombre=@nombre,tipo=@tipo,precio=@precio,stock=@stock WHERE cod_prod=@cod;" +
                         "INSERT INTO HISTORICO(nom_op,tabla,ci_op,fecha) VALUES ('UPDATE','Productos',@ci,@fecha);";
            MySqlCommand comando = new MySqlCommand(sql, con);
            comando.Parameters.AddWithValue("@ci", usuario.CI);
            comando.Parameters.AddWithValue("@fecha", DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss"));
            comando.Parameters.AddWithValue("@cod", usuario.IdProd);
            comando.Parameters.AddWithValue("@nombre", usuario.NombreProd);
            comando.Parameters.AddWithValue("@tipo", usuario.TipoProd);
            comando.Parameters.AddWithValue("@precio", usuario.PrecioProd);
            comando.Parameters.AddWithValue("@stock", usuario.StockProd);
            int resultado = comando.ExecuteNonQuery();
            MessageBox.Show("Producto actualizado correctamente");
            con.Close();
            return resultado;
        }
        public int DeleteSector(Usuarios usuario)
        {
            con.Open();
            string sql = "DELETE FROM sectores WHERE idsector=@cod";
            MySqlCommand comando = new MySqlCommand(sql, con);
            comando.Parameters.AddWithValue("@cod", usuario.IdSector);
            int resultado = comando.ExecuteNonQuery();
            MessageBox.Show("Sector dado de baja correctamente");
            con.Close();
            return resultado;
        }
        public int UpdatePCSector(Usuarios usuario)
        {
            con.Open();
            string sql = "UPDATE sectores SET proxCosecha=@proxx WHERE idsector=@cod";
            MySqlCommand comando = new MySqlCommand(sql, con);
            comando.Parameters.AddWithValue("@cod", usuario.IdSector);
            comando.Parameters.AddWithValue("@proxx", usuario.ProxCosecha);
            int resultado = comando.ExecuteNonQuery();
            MessageBox.Show("Rotacion Actualizada");
            con.Close();
            return resultado;
        }
        public int DeleteSector1(Usuarios usuario)
        {
            con.Open();
            string sql = "DELETE FROM personacosecha WHERE idsector=@cod;" +

                         "INSERT INTO HISTORICO(nom_op,tabla,ci_op,fecha) VALUES ('DELETE','personacosecha',@ci,@fecha);";
            MySqlCommand comando = new MySqlCommand(sql, con);
            comando.Parameters.AddWithValue("@ci", usuario.CI);
            comando.Parameters.AddWithValue("@fecha", DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss"));
            comando.Parameters.AddWithValue("@cod", usuario.IdSector);
            int resultado = comando.ExecuteNonQuery();
            con.Close();
            return resultado;
        }
        public void GetIDCosecha1(Usuarios usuario)
        {
            con.Open();
            string sql = "SELECT idCosecha FROM Cosechas WHERE tipoCosecha=@tipoCosecha";
            MySqlCommand comando = new MySqlCommand(sql, con);
            comando.Parameters.AddWithValue("@tipoCosecha", usuario.TipoCosecha);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.Read() == true)
            {
                usuario.IdCosecha = reader["idCosecha"].ToString();
            }
            con.Close();

        }
        public void ConsultaGeneralVentasDataGrid(DataGridView dt)
        {
            con.Open();
            string sql = "SELECT v.idVentas,v.ciAdmin AS Administrativo,c.ciProd AS Productor ,v.fecha,vp.cant,vp.total,p.Nombre FROM Ventas v " +
                         "INNER JOIN ventaproducto vp ON v.idVentas=vp.idVentas INNER JOIN Productos p ON p.cod_prod=vp.cod_prod " +
                         "INNER JOIN Compras c ON p.cod_prod=c.cod_prod GROUP BY v.idVentas;";
            MySqlCommand comando = new MySqlCommand(sql, con);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            dt.DataSource = tabla;
            con.Close();
        }
        public void ConsultaVentasIDDataGrid1(DataGridView dt, Usuarios usuario)
        {
            con.Open();
            string sql = "SELECT v.idVentas,v.ciAdmin AS Administrativo,c.ciProd AS Productor ,v.fecha,vp.cant,vp.total,p.Nombre FROM Ventas v " +
                         "INNER JOIN ventaproducto vp ON v.idVentas=vp.idVentas INNER JOIN Productos p ON p.cod_prod=vp.cod_prod " +
                         "INNER JOIN Compras c ON p.cod_prod=c.cod_prod WHERE v.idVentas=@idVentas GROUP BY v.idVentas;";
            MySqlCommand comando = new MySqlCommand(sql, con);
            comando.Parameters.AddWithValue("@idVentas", usuario.IdVenta);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            dt.DataSource = tabla;
            con.Close();

        }
        public void ConsultaVentasBAJADataGrid(DataGridView dt)
        {
            con.Open();
            string sql = "SELECT v.idVentas,v.ciAdmin AS Administrativo,c.ciProd AS Productor ,v.fecha,vp.cant,vp.total,p.Nombre FROM Ventas v " +
                "INNER JOIN ventaproducto vp  ON v.idVentas=vp.idVentas INNER JOIN Productos p ON p.cod_prod=vp.cod_prod " +
                "INNER JOIN Compras c ON p.cod_prod=c.cod_prod WHERE v.baja=1 GROUP BY v.idVentas ";
            MySqlCommand comando = new MySqlCommand(sql, con);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            dt.DataSource = tabla;
            con.Close();
        }
        public void ConsultaVentasBAJADataGrid1(DataGridView dt, Usuarios usuario)
        {
            con.Open();
            string sql = "SELECT v.idVentas,v.ciAdmin AS Administrativo,c.ciProd AS Productor ,v.fecha,vp.cant,vp.total,p.Nombre FROM Ventas v " +
                         "INNER JOIN ventaproducto vp ON v.idVentas=vp.idVentas INNER JOIN Productos p ON p.cod_prod=vp.cod_prod " +
                         "INNER JOIN Compras c ON p.cod_prod=c.cod_prod  WHERE v.idVentas=@idventas AND v.baja=1 GROUP BY v.idVentas;";
            MySqlCommand comando = new MySqlCommand(sql, con);
            comando.Parameters.AddWithValue("@idVentas", usuario.IdVenta);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            dt.DataSource = tabla;
            con.Close();

        }
        public void ConsultaCiVentasDataGrid(DataGridView dt, Usuarios usuario)
        {
            con.Open();
            string sql = "SELECT v.idVentas,v.ciAdmin AS Administrativo,c.ciProd AS Productor ,v.fecha,vp.cant,vp.total,p.Nombre FROM Ventas v " +
                         "INNER JOIN ventaproducto vp ON v.idVentas=vp.idVentas INNER JOIN Productos p ON p.cod_prod=vp.cod_prod " +
                         "INNER JOIN Compras c ON p.cod_prod=c.cod_prod WHERE c.ciProd=@ci GROUP BY v.idVentas;";
            MySqlCommand comando = new MySqlCommand(sql, con);
            comando.Parameters.AddWithValue("@ci", usuario.CI);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            dt.DataSource = tabla;
            con.Close();

        }
        public void ConsultaCodProductoVentasDataGrid(DataGridView dt, Usuarios usuario)
        {   con.Open();
            string sql = "SELECT v.idVentas,v.ciAdmin AS Administrativo,c.ciProd AS Productor ,v.fecha,vp.cant,vp.total,p.Nombre FROM Ventas v " +
                         "INNER JOIN ventaproducto vp ON v.idVentas=vp.idVentas INNER JOIN Productos p ON p.cod_prod=vp.cod_prod " +
                         "INNER JOIN Compras c ON p.cod_prod=c.cod_prod  WHERE c.cod_prod=@ci GROUP BY v.idVentas;";
            MySqlCommand comando = new MySqlCommand(sql, con);
            comando.Parameters.AddWithValue("@ci", usuario.CodProd);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            dt.DataSource = tabla;
            con.Close();
        }
        public int AddVenta(Usuarios usuario, Productos p)
        {
            con.Open();
            string sql = "INSERT INTO Ventas (ciAdmin,fecha,baja) VALUES(@ci,@fecha,0);" +
                         "INSERT INTO HISTORICO(nom_op,tabla,ci_op,fecha) VALUES ('INSERT','Ventas',@ci,@fecha);";
            MySqlCommand comando = new MySqlCommand(sql, con);
            comando.Parameters.AddWithValue("@ci", usuario.CI);
            comando.Parameters.AddWithValue("@cantidad", p.CANTTotal);
            comando.Parameters.AddWithValue("@fecha", DateTime.Now.ToString("yyyy'-'MM'-'dd HH:mm:ss"));
            int resultado = comando.ExecuteNonQuery();
            con.Close();
            return resultado;
        }
        
        public void AprobarVenta(Usuarios usuario)
        {
            con.Open();
            string sql = "UPDATE Compras SET pendiente=0 WHERE cod_compra=@cod;" +
                         "INSERT INTO HISTORICO(nom_op,tabla,ci_op,fecha) VALUES ('UPDATE','Compras',@ci,@fecha);";

            MySqlCommand comando = new MySqlCommand(sql, con);
            comando.Parameters.AddWithValue("@cod", usuario.Cod_Compra);
            comando.Parameters.AddWithValue("@ci", usuario.CI);
            comando.Parameters.AddWithValue("@fecha", DateTime.Now.ToString("yyyy'-'MM'-'dd HH:mm:ss"));
            int resultado = comando.ExecuteNonQuery();
            con.Close();
        }
        public void CacheVentaAprobada(Usuarios usuario, Productos p)
        {
            con.Open();
            string sql = "SELECT * FROM Compras WHERE cod_compra=@cod";
            MySqlCommand comando = new MySqlCommand(sql, con);
            comando.Parameters.AddWithValue("@cod", usuario.Cod_Compra);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.Read() == true)
            {

                usuario.CIProd = reader["ciProd"].ToString();
                p.CANTTotal = Convert.ToInt32(reader["cantidad"]);

                
            }
        con.Close();
        }
        public void SectorDeProd(Usuarios usuario, ComboBox cbx)
        {
            con.Open();
            string sql = "SELECT idSector FROM PersonaCosecha WHERE ci=@ci GROUP BY idSector";
            MySqlCommand comando = new MySqlCommand(sql, con);
            comando.Parameters.AddWithValue("@ci", usuario.CI);
            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                cbx.Items.Add(reader["idSector"]);
                
            }
            con.Close();
        }
        public void FertSector(Usuarios usuario, ComboBox cbx)
        {
            con.Open();
            string sql = "SELECT fertilizacion FROM Sectores WHERE idSector=@idSector";
            MySqlCommand comando = new MySqlCommand(sql, con);
            comando.Parameters.AddWithValue("@idSector", usuario.IdSector);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.Read()){
                usuario.EstadoFert = reader["Fertilizacion"].ToString();
                if (usuario.EstadoFert=="--")
                {
                    cbx.Items.Add("Z2.2");
                }
                if (usuario.EstadoFert == "Z2.2")
                {
                    cbx.Items.Add("Z3.0");
                }
                if (usuario.EstadoFert == "Z3.0")
                {
                    cbx.Items.Add("Fosforo");
                }
            }
            con.Close();
        }
        public void UpdateFert(Usuarios usuario)
        {
            con.Open();
            string sql = "UPDATE Sectores SET fertilizacion=@fert WHERE idSector=@id";

            MySqlCommand comando = new MySqlCommand(sql, con);
            comando.Parameters.AddWithValue("@id", usuario.IdSector);
            comando.Parameters.AddWithValue("@fert", usuario.Fertilizacion);
            comando.ExecuteNonQuery();

            con.Close();
        }
        public void ConsultaHISTORICO(DataGridView dt)
        {
            con.Open();
            string sql = "SELECT * FROM historico;";
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




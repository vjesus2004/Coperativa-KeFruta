using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;


namespace Negocios
{

    public class ConexionSQLN
    {
        ConexionSQL cn = new ConexionSQL();
        ValidacionesSQL add = new ValidacionesSQL();
        Usuarios u = new Usuarios();
        Productos p = new Productos();
        SeteoDePCS set = new SeteoDePCS();    
        
        public int conSQL(string user, string pass)
        {return cn.consultaLogin(user, pass);}
        public string RolSQL(string user, string pass)
        {return cn.consultaRol(user,pass);}
        public int Userreg(Usuarios usuario)
        {   add.existeUsuario(u);
            return cn.registro(usuario);
        }

        public void adduser(string nombre, string ci, string apellido, string calle, string n_Puerta, string contraseña, string usuario,string rol,string tipoprod)
        {
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(ci) || string.IsNullOrEmpty(apellido)
                || string.IsNullOrEmpty(calle) || string.IsNullOrEmpty(n_Puerta) || string.IsNullOrEmpty(contraseña) ||
                string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(rol))
            {
                MessageBox.Show("No deje espacios en blanco, llene los campos y reintente la operacion.");
            }
            else
            {
            u.Nombre = nombre;
            u.CI = ci;
            u.Apellido=apellido;
            u.Calle = calle;
            u.Usuario = usuario;
            u.Rol = rol;
            u.Password = contraseña;
            u.N_Puerta = n_Puerta;
            u.TipoProduccion= tipoprod;
            add.existeUsuario(u);
                if (u.ExUsuario == 1) {

                    add.existeUsuarioBaja(u);

                    if (u.ExUserBaja == 1)
                    {
                        cn.registroAlta(u);
                    }
                }
                else { cn.registro(u); }
            }
        }
        public void deluser(string ci)
        {
            
            u.CI=ci;
            cn.DeleteUser(u);
            
        }

        public void CIConsulta(string ci)
        {
            u.CI = ci;
            cn.ConsultaUsuario(u);
        }
        public void ConsultUser(TextBox nombre,TextBox apellido, TextBox calle,TextBox usuario, TextBox contraseña, TextBox n_Puerta, TextBox ci, TextBox tel)
        {
             nombre.Text =u.Nombre;
             apellido.Text=u.Apellido;
             calle.Text=u.Calle;
             usuario.Text=u.Usuario;
             contraseña.Text=u.Password;
             n_Puerta.Text=u.N_Puerta;
             ci.Text = u.CI;
             tel.Text = u.Telefono;
        }

        public void BuscarUser(string user)
        {   
            u = cn.ConsultaPorUser(user);
        }
        

        public void addtel(string ci, string tel)
        {
            if (string.IsNullOrEmpty(tel) || string.IsNullOrEmpty(ci))
            {
                MessageBox.Show("Llene el campo de telefono");
            }
            else { 
            u.CI = ci;
            u.Telefono = tel;

            cn.registroTel(u);
        }}

        
        public void fechasact(DateTime fechacultivo, DateTime fechacosecha ,string tipoCosecha)
        {
            u.fechaCosecha = fechacosecha;
            u.fechaCultivo = fechacultivo;
            u.TipoCosecha = tipoCosecha;
            cn.Update(u); 
        }
        public void setTipoC(string tipoCosecha)
        {
            u.TipoCosecha = tipoCosecha;
            cn.SelectFecha(u);
        }
        public void ConsultFecha(TextBox fechaSiembra, TextBox fechacosecha)
        {
            fechaSiembra.Text = u.fechaCultivo.ToString();
            fechacosecha.Text = u.fechaCosecha.ToString();
          
        }

        public void ConsultaDT(DataGridView dt)
        {
            cn.ConsultaUsuarioDataGrid(dt);
        }
        public void ConsultaDT1(DataGridView dt,TextBox txt)
        {
            u.CI  = txt.Text;
            cn.ConsultaUsuarioDataGrid1(dt,u);
            
        }
        public void ConsultaBajaDT(DataGridView dt)
        {
            cn.ConsultaUsuarioBajaDataGrid(dt);
        }
        public void ConsultaBajaDT1(DataGridView dt, TextBox txt)
        {
            u.CI = txt.Text;
            cn.ConsultaUsuarioBajaDataGrid1(dt, u);
        }
        public void UpdateProd(TextBox ci,TextBox nombre, TextBox apellido, TextBox user, TextBox pass, TextBox calle, TextBox npuerta,TextBox tel) {
            if (string.IsNullOrEmpty(ci.Text) || string.IsNullOrEmpty(nombre.Text) || string.IsNullOrEmpty(apellido.Text)
                || string.IsNullOrEmpty(user.Text) || string.IsNullOrEmpty(pass.Text) || string.IsNullOrEmpty(calle.Text) ||
                string.IsNullOrEmpty(npuerta.Text) || string.IsNullOrEmpty(tel.Text))
            {MessageBox.Show("No deje espacios en blanco, llene los campos y reintente la modificacion.");}
            else
            {
                u.Nombre = nombre.Text;
            u.CI = ci.Text;
            u.Apellido = apellido.Text;
            u.Calle = calle.Text;
            u.Usuario = user.Text;
            u.Password = pass.Text;
            u.N_Puerta = npuerta.Text;
            u.Telefono = tel.Text;
            cn.UpdateUser(u);
            cn.UpdateUserTel(u);
            cn.GetIDCosecha(u);
            nombre.Text = "";
            apellido.Text = "";
            ci.Text = "";
            user.Text = "";
            pass.Text = "";
            npuerta.Text = "";
            calle.Text = "";
            tel.Text = "";
            MessageBox.Show("Todos sus datos han sido actualizados correctamente");
            }
        }
        public void UpdateUser(TextBox ci, TextBox nombre, TextBox apellido, TextBox user, TextBox pass, TextBox calle, TextBox npuerta, TextBox tel)
        {
            if (string.IsNullOrEmpty(ci.Text) || string.IsNullOrEmpty(nombre.Text) || string.IsNullOrEmpty(apellido.Text)
                || string.IsNullOrEmpty(user.Text) || string.IsNullOrEmpty(pass.Text) || string.IsNullOrEmpty(calle.Text) ||
                string.IsNullOrEmpty(npuerta.Text) || string.IsNullOrEmpty(tel.Text))
            {
                MessageBox.Show("No deje espacios en blanco, llene los campos y reintente la modificacion.");
            }
            else
            {

            u.Nombre = nombre.Text;
            u.CI = ci.Text;
            u.Apellido = apellido.Text;
            u.Calle = calle.Text;
            u.Usuario = user.Text;
            u.Password = pass.Text;
            u.N_Puerta = npuerta.Text;
            u.Telefono = tel.Text;
            cn.UpdateUser(u);
            cn.UpdateUserTel(u);
            MessageBox.Show("Usuario: " + "`" + nombre.Text + "`" + " Actualizado Correctamente");
            nombre.Text = "";
            apellido.Text = "";
            ci.Text = "";
            user.Text = "";
            pass.Text = "";
            npuerta.Text = "";
            calle.Text = "";
            tel.Text = "";
            }
        }
        public void ConsultaProdDT(DataGridView dt)
        {
            cn.ConsultaProductoDataGrid(dt);
        }
        public void ConsultaProdDT1(DataGridView dt, TextBox txt)
        {
            u.IdProd = txt.Text;
            cn.ConsultaProductoDataGrid1(dt, u);

        }
        public void ConsultaProdBajaDT(DataGridView dt)
        {
            cn.ConsultaProductoBajaDataGrid(dt);
        }
        public void ConsultaProdBajaDT1(DataGridView dt, TextBox txt)
        {
            u.IdProd = txt.Text;
            cn.ConsultaProductoBajaDataGrid1(dt, u);

        }
        public void addprod(TextBox cod, TextBox nombre, string tipo, TextBox precio,TextBox stock)
        {
            u.NombreProd = nombre.Text;
            u.CodProd = cod.Text;
            u.TipoProd = tipo;
            u.PrecioProd =int.Parse(precio.Text);
            u.StockProd = int.Parse(stock.Text); ;
            cn.registroProd(u);
        }
        public void delprod(string cod)
        {
            u.CodProd = cod;
            cn.DeleteProd(u);
        }

        public void ConsultaSectorDT(DataGridView dt)
        {
            cn.ConsultaSectorDataGrid(dt);
        }
        public void ConsultaSectorDT1(DataGridView dt, TextBox txt)
        {
            u.IdSector = txt.Text;
            cn.ConsultaSectorDataGrid1(dt, u);

        }
       
        public void UpdateProducto(TextBox id, TextBox nombre,string tipo, TextBox precio, TextBox stock)
        {
            if (string.IsNullOrEmpty(id.Text) || string.IsNullOrEmpty(nombre.Text) || string.IsNullOrEmpty(tipo)
                || string.IsNullOrEmpty(precio.Text) || string.IsNullOrEmpty(stock.Text))
            {
                MessageBox.Show("No deje espacios en blanco, llene los campos y reintente la modificacion.");
            }
            else
            {
                u.Nombre = nombre.Text;
                u.IdProd = id.Text;
                u.NombreProd = nombre.Text;
                u.TipoProd = tipo;
                u.PrecioProd = int.Parse(precio.Text); 
                u.StockProd = int.Parse(stock.Text); 
                cn.UpdateProducto(u);
            
               
            }
        }
        public void addSector(TextBox id, TextBox ci, string tipo, int estado, TextBox tamaño)
        {
            if (string.IsNullOrEmpty(id.Text) || string.IsNullOrEmpty(ci.Text) || string.IsNullOrEmpty(tipo)
                || estado==null || string.IsNullOrEmpty(tamaño.Text))
            {MessageBox.Show("No deje espacios en blanco, llene los campos y reintente la modificacion.");}
            else
            {
                u.CI = ci.Text;
                u.IdSector = id.Text;
                u.TipoProd = tipo;
                u.Tsector = int.Parse(tamaño.Text);
                u.Esector = estado;
                u.ProxCosecha = tipo;
                string idd = "";
                
                add.existeSector(u);
                add.SectorNoProd(u);
                add.SelectTipoProductor(u);
                if (u.ExUsuario != 1)
                {
                
                if (u.Rol != "A")
                    {
                    if (u.TipoProduccion!=u.TipoProduccionSector){
                        MessageBox.Show("Este productor se dedica a la produccion exclusiva de"+u.TipoProduccion);
                        }
                        else {
                            if (tipo == "Limones") { u.IdCosecha = "136"; }else if (tipo == "Manzanas"){ u.IdCosecha = "135"; }
                            else if (tipo == "Naranjas") { u.IdCosecha = "135"; } else if (tipo == "Papa Rosada") { u.IdCosecha = "133";}
                            else if (tipo == "Zapallo Criollo") { u.IdCosecha = "134"; } else if (tipo == "Trigo") { u.IdCosecha = "138"; }
                            else if (tipo == "Cereales") { u.IdCosecha = "137"; }
                            
                            cn.registroSector(u);
                    cn.registroSectorPersona(u);
                     }
                   }
                }
            }
        }
        public void delsector(string cod)
        {
            add.existeSector(u);
            if (u.ExUsuario != 1)
            {  
                u.IdSector = cod;
                cn.DeleteSector(u);
                  cn.DeleteSector1(u);
            }
        }
        public void GetTipodeCosecha(string tipoCosecha)
        {
            u.TipoCosecha = tipoCosecha;
            cn.GetIDCosecha1(u);
        }
        public void setTPCS(string tipo)
        {
            u.TipoProduccionSector = tipo;
        }
        public void setTPCSUser(string user)
        {
            u.Usuario = user;
            add.SelectTipoProductorPorUser(u);

        }
        public void CBXCOSECHA(ComboBox cbxProd){

            add.SelectTipoProductorPorUser(u);
            if (u.TipoProduccion == "Frutas")
            {
                cbxProd.Items.Add("Manzana");
                cbxProd.Items.Add("Limon");
                cbxProd.Items.Add("Naranja");
            }
            else if (u.TipoProduccion == "Verduras")
            {
                cbxProd.Items.Add("Papa Rosada");
                cbxProd.Items.Add("Zapallo Criollo");
            }
            else if (u.TipoProduccion == "Cereales")
            {
                cbxProd.Items.Add("Trigo");
                cbxProd.Items.Add("Cebada");
            }
        }
        public void Catalogo(string user,Label Tipo)
        {
            setTPCSUser(user);
            add.SelectTipoProductorPorUser(u);
            Tipo.Text = "Catalogo del productor de "+u.TipoProduccion;
        }
        public void ConsultVentasCI(DataGridView dt, string cod)
        {
            u.CI = cod;
            add.NoExisteUsuario(u);
            add.SectorNoProd(u);
            if (u.ExUsuario==1)
            {
                if(u.Rol != "A") { cn.ConsultaCiVentasDataGrid(dt, u);}
            }
        }
        public void ConsultVentasCodProducto(DataGridView dt, string ci)
        {
            u.CodProd = ci;
            add.NoExisteProd(u);
            if (u.ExisteProd == 1)
            {
                cn.ConsultaCodProductoVentasDataGrid(dt, u);
            }
        }
        public void ConsultVentasDT(DataGridView dt)
        {
            cn.ConsultaGeneralVentasDataGrid(dt);
        }
        public void ConsultHistorico(DataGridView dt)
        {
            cn.ConsultaHISTORICO(dt);
        }
        public void ConsultVentasDTIdVentas(DataGridView dt,string idVentas)
        {
            u.IdVenta = idVentas;
            add.NoExisteVenta(u);
            if (u.ExisteVenta == 1)
            {
                cn.ConsultaVentasIDDataGrid1(dt,u);
            }
        }
        public void ConsultVentasBaja(DataGridView dt)
        {
            cn.ConsultaVentasBAJADataGrid(dt);
        }
        public void ConsultVentasBajaIdVentas(DataGridView dt,string id)
        {   u.IdVenta=id;
            add.NoExisteVenta(u);
            if (u.ExisteVenta == 1)
            {
                cn.ConsultaVentasBAJADataGrid1(dt,u);
            }
        }
        public void ConsultVentasPendientes(DataGridView dt)
        {
            add.ConsutlComprasPendientes(dt);
        }
        public void AprobarCompra(TextBox txt)
        {
                u.Cod_Compra = txt.Text;
                cn.AprobarVenta(u);
                cn.CacheVentaAprobada(u,p);
                MessageBox.Show("Venta aprobada correctamente.");
        }
        public void AddVentaandVentaProd(string user)
        {
            cn.AddVenta(set.ConsultaPorUser(user), p);

        }
      public void CISector(string txt,ComboBox cbx)
        {
            u = cn.ConsultaPorUser(txt);
            cn.SectorDeProd(u,cbx);

        }
        public void IdSectortoHectareas(string id,TextBox txt)
        {
            u = cn.Hectareas(id,txt);

        }
        public void IdSectortoEstado(string id, TextBox cbx)
        {   
            u = cn.EstadoSector(id, cbx);
        }
        public void IdSectortoProxCosecha(string id, ComboBox cbx)
        {
            u = cn.ProxCosecha(id, cbx);

        }
        public void UpdateProxCosecha(ComboBox cbx, ComboBox cbx1)
        {
            u.ProxCosecha = cbx1.Text;
            u.IdSector = cbx.Text;
            cn.UpdatePCSector(u);

        }
        public void Fertilizante(string id,ComboBox cbx)
        {
            u.IdSector = id;
            cn.FertSector(u,cbx);
        }
        public double CalculoZ2(NumericUpDown npNPP,string id)
        {
            int npp = Convert.ToInt32(npNPP.Value);
            double subtotal = (14 - npp) * 5;
            double total = subtotal * u.Tsector * 4;
            u.TotalZ2 = total;
            u.Fertilizacion = "Z2.2";
            u.IdSector = id;
            cn.UpdateFert(u);
           
            return total;
        }
        public double CalculoZ3(NumericUpDown npNPP, string id)
        {
            int npp = Convert.ToInt32(npNPP.Value);
            double subtotal = 45 * (14 - npp);
            double total = subtotal * u.Tsector * 4;
            u.TotalZ3 = total;
            u.Fertilizacion = "Z3.0";
            u.IdSector = id;
            cn.UpdateFert(u);
            return total;
        }
        public double CalculoFosforo(NumericUpDown npNPP, string id)
        {   
            int npp = Convert.ToInt32(npNPP.Value);
            double subtotal = (14 + npp) * 10;
            double total = subtotal *u.Tsector* 4;
            u.TotalFosforo = total;

            u.Fertilizacion = "Fosforo";
            u.IdSector = id;
            cn.UpdateFert(u);
            return total;
        }
        public void IdSectortoHectareasFert(string id)
        {
            u = cn.HectareasFert(id);

        }
    }
}




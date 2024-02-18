using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Usuarios
    {
        string nombre, apellido, usuario, password, calle, n_Puerta, rol, ci, tel, tipo,idcos, idprod, nombreprod, codprod, tipoprod, idsector;
        string tipoProduccion, tipoProduccionsec, idven,cod_compra,prodcant,ciprod,proxcosecha,estadofert,fertilizacion;
        int precioprod,stockprod,tsector,esector,existe,existeprod,existeventa,existeuserbaja;
        DateTime fcul, fcos;
        double totalz2, totalz3, totalfosforo;
        public string Usuario { get => usuario; set => usuario = value; }
        public string Password { get => password; set => password = value; }
        public string Calle { get => calle; set => calle = value; }
        public string N_Puerta { get => n_Puerta; set => n_Puerta = value; }
        public string Nombre { get => nombre; set => nombre = value;}
        public string Apellido { get => apellido; set => apellido = value;}
        public string CI { get => ci; set => ci = value;}
        public string Rol { get => rol; set => rol = value;}
        public string Telefono { get => tel; set => tel = value;}
        public string TipoCosecha { get => tipo; set => tipo = value;}
        public string Fertilizacion { get => fertilizacion; set => fertilizacion = value; }
        public DateTime fechaCultivo { get => fcul; set => fcul = value;}
        public DateTime fechaCosecha { get => fcos; set => fcos = value;}
        public string IdCosecha { get => idcos; set => idcos = value;}
        public string IdProd{ get => idprod; set => idprod = value;}
        public string NombreProd { get => nombreprod; set => nombreprod = value;}
        public int StockProd { get => stockprod; set => stockprod = value;}
        public string CodProd { get => codprod; set => codprod = value;}
        public int PrecioProd { get => precioprod; set => precioprod = value;}
        public string TipoProd{ get => tipoprod; set => tipoprod = value;}
        public string IdSector { get => idsector; set => idsector = value;}
        public int Tsector { get => tsector; set => tsector = value;}
        public int ExUserBaja { get => existeuserbaja; set => existeuserbaja = value; }
        public int Esector { get => esector; set => esector = value;}
        public int ExUsuario { get => existe; set => existe = value;} 
        public string TipoProduccion { get => tipoProduccion; set => tipoProduccion = value;}
        public string TipoProduccionSector { get => tipoProduccionsec; set => tipoProduccionsec = value; }
        public string IdVenta { get => idven; set => idven = value; }
        public string Cod_Compra { get => cod_compra; set => cod_compra = value; }
        public string ProdCant { get => prodcant; set => prodcant = value; }
        public int ExisteProd { get => existeprod; set => existeprod = value; }
        public int ExisteVenta { get => existeventa; set => existeventa = value; }
        public string CIProd { get => ciprod; set => ciprod = value; }
        public string ProxCosecha { get => proxcosecha; set => proxcosecha = value; }
        public string EstadoFert { get => estadofert; set => estadofert = value; }
        public double TotalZ2 { get => totalz2; set => totalz2 = value; }
        public double TotalZ3 { get => totalz3; set => totalz3 = value; }
        public double TotalFosforo { get => totalfosforo; set => totalfosforo = value; }

    }

}

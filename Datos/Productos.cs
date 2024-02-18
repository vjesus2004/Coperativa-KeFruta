using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Productos
    {
        int pkmanzana, pknaranja, pklimones, pkpapas, pkzapallo, pkcebada, pktrigo, pkfertilizante, pkfungicida, pksemillas;
        int cantmanzana, cantnaranja, cantlimones, cantpapas, cantzapallo, cantcebada, canttrigo, cantfertilizante, cantfungicida, cantsemillas;
        int stockmanzana, stocknaranja, stocklimones, stockpapas, stockzapallo, stockcebada, stocktrigo, stockfertilizante, stockfungicida, stocksemillas, canttotal;
        double totalprimario, subtotal, iva = 0.22, totalinsumo;
        string nmanzana, nnaranja, nlimones, npapas, nzapallo, ncebada, ntrigo, nfertilizante, nfungicida, nsemillas;
        List<string> stringCod = new List<string>();  List<string> stringCant = new List<string>();
        public List<string> StringCod{
            get
            {   return stringCod;  }
            set
            {   stringCod = value; }
          }
        public List<string> StringCant
        {
            get
            { return stringCant; }
            set
            { stringCant = value; }
        }
        //Nombre


        public string Nmanzana { get => nmanzana; set => nmanzana = value; }
          public string Nnaranja { get => nnaranja; set => nnaranja = value; }
          public string Nlimones { get => nlimones; set => nlimones = value; }
          public string Npapas { get => npapas; set => npapas = value; }
          public string Nzapallo { get => nzapallo; set => nzapallo = value; }
          public string Ncebada { get => ncebada; set => ncebada = value; }
          public string Ntrigo { get => ntrigo; set => ntrigo = value; }
          public string Nfertilizante { get => nfertilizante; set => nfertilizante = value; }
          public string Nfungicida { get => nfungicida; set => nfungicida = value; }
          public string Nsemillas { get => nsemillas; set => nsemillas = value; }  

    //Precio
    public int PKmanzana { get => pkmanzana; set => pkmanzana = value; }
        public int PKnaranja { get => pknaranja; set => pknaranja = value; }
        public int PKlimones { get => pklimones; set => pklimones = value; }
        public int PKpapas { get => pkpapas; set => pkpapas = value; }
        public int PKzapallo { get => pkzapallo; set => pkzapallo = value; }
        public int PKcebada { get => pkcebada; set => pkcebada = value; }
        public int PKtrigo { get => pktrigo; set => pktrigo = value; }
        public int PKfertilizante { get => pkfertilizante; set => pkfertilizante = value; }
        public int PKfungicida { get => pkfungicida; set => pkfungicida = value; }
        public int PKsemillas { get => pksemillas; set => pksemillas = value; }

        //cantidad
        public int CANTmanzana { get => cantmanzana; set => cantmanzana = value; }
        public int CANTnaranja { get => cantnaranja; set => cantnaranja = value; }
        public int CANTlimones { get => cantlimones; set => cantlimones = value; }
        public int CANTpapas { get => cantpapas; set => cantpapas = value; }
        public int CANTzapallo { get => cantzapallo; set => cantzapallo = value; }
        public int CANTcebada { get => cantcebada; set => cantcebada = value; }
        public int CANTtrigo { get => canttrigo; set => canttrigo = value; }
        public int CANTfertilizante { get => cantfertilizante; set => cantfertilizante = value; }
        public int CANTfungicida { get => cantfungicida; set => cantfungicida = value; }
        public int CANTsemillas { get => cantsemillas; set => cantsemillas = value; }
        public int CANTTotal { get => canttotal; set => canttotal = value; }

        //Stock
        public int STOCKmanzana { get => stockmanzana; set => stockmanzana = value; }
        public int STOCKnaranja { get => stocknaranja; set => stocknaranja = value; }
        public int STOCKlimones { get => stocklimones; set => stocklimones = value; }
        public int STOCKpapas { get => stockpapas; set => stockpapas = value; }
        public int STOCKzapallo { get => stockzapallo; set => stockzapallo = value; }
        public int STOCKcebada { get => stockcebada; set => stockcebada = value; }
        public int STOCKtrigo { get => stocktrigo; set => stocktrigo = value; }
        public int STOCKfertilizante { get => stockfertilizante; set => stockfertilizante = value; }
        public int STOCKfungicida { get => stockfungicida; set => stockfungicida = value; }
        public int STOCKsemillas { get => stocksemillas; set => stocksemillas = value; }
        public double PTotal { get => totalprimario; set => totalprimario = value; }
        public double IVA { get => iva; set => iva = value; }
        public double ITotal { get => totalinsumo; set => totalinsumo = value; }
        public double SubTotal { get => subtotal; set => subtotal = value; }
        
    }


}

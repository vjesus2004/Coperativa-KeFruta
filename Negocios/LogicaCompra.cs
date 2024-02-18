using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;

namespace Negocios
{
    public class LogicaCompra
    {
        Productos p = new Productos();
        SeteoDePCS set = new SeteoDePCS();
        Usuarios u = new Usuarios();
        ConexionSQL cn = new ConexionSQL();
        ConexionSQLN nc = new ConexionSQLN();

        public void SetCantidades(NumericUpDown cantmanzana, NumericUpDown cantnaranja, NumericUpDown cantlimones,
                                  NumericUpDown cantpapas, NumericUpDown cantzapallo, NumericUpDown cantcebada,
                                  NumericUpDown canttrigo, NumericUpDown cantfert, NumericUpDown cantfung, NumericUpDown cantplant)
        {
            p.CANTmanzana = Convert.ToInt32(cantmanzana.Value);
            p.CANTnaranja = Convert.ToInt32(cantnaranja.Value);
            p.CANTlimones = Convert.ToInt32(cantlimones.Value);
            p.CANTpapas = Convert.ToInt32(cantpapas.Value);
            p.CANTzapallo = Convert.ToInt32(cantzapallo.Value);
            p.CANTcebada = Convert.ToInt32(cantcebada.Value);
            p.CANTtrigo = Convert.ToInt32(canttrigo.Value);
            p.CANTfertilizante = Convert.ToInt32(cantfert.Text);
            p.CANTfungicida = Convert.ToInt32(cantfung.Text);
            p.CANTsemillas = Convert.ToInt32(cantplant.Text);
            
            set.SetPSManzana(p);
            set.SetPSnaranja(p);
            set.SetPSlimones(p);
            set.SetPSTrigo(p);
            set.SetPSpapa(p);
            set.SetPSCebada(p);
            set.SetPSzapallo(p);
            set.SetPSFert(p);
            set.SetPSSemillas(p);
            set.SetPSFungicida(p);
            set.stock(p);
        }
        public void SetCantidadesProd()
        {
            
            set.SetPSFert(p);
            set.SetPSFungicida(p);
            set.SetPSSemillas(p);
            set.stock(p);
        }
 
             public void SetFactura(ListBox lst,string user) {
            set.Factura(p,lst);
               set.AddCompra(set.ConsultaPorUser(user),p);
              }
         
    }
}

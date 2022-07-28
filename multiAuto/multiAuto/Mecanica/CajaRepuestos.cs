using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using multiAuto.ClassAbstract;

namespace multiAuto.Mecanica
{
    public class CajaRepuestos
    {
        public IMecanica mecanica;
        List<GUMObject> GUM;

        public CajaRepuestos(IMecanica mecanica)
        {
            this.mecanica = mecanica;
            GUM = new List<GUMObject>();
        }

        public void CrearPresupuesto()
        {
            Cantidad cantidad  = mecanica.CreateCantidad("Cantidad: \n"+
                                                            "3");
            Descripcion descripcion = mecanica.CreateDescripcion("Reparacion del motor: \n"+
                                                                 "Juego de pistones");
            PreUnitario preUnitario = mecanica.CreatepreUnitario("Precio Unitario \n"+
                                                                      "3.00");
            Importe importe = mecanica.CreateImporte("Importe: \n"+ 
                                                        "9.00");

            GUM.Add(cantidad);
            GUM.Add(descripcion);
            GUM.Add(preUnitario);
            GUM.Add(importe);

        }

        public void Paint()
        {
            String pantalla = "";
            foreach (var objeto in GUM)
            {
                pantalla += objeto.Paint() + "\n";
            }

            Console.WriteLine(pantalla);
        }
    }
}

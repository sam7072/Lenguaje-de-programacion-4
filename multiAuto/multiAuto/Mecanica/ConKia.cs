using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using multiAuto.ClassAbstract;
using multiAuto.KIA;

namespace multiAuto.Mecanica
{
    public class ConKia : IMecanica
    {
        public Cantidad CreateCantidad(string text)
        {
            return new KiaCantidad(text);
        }

        public Descripcion CreateDescripcion(string descrip)
        {
            return new KiaDescripcion(descrip);
        }

        public Importe CreateImporte(string importe)
        {
            return new KiaImporte(importe);
        }

        public PreUnitario CreatepreUnitario(string PUnitario)
        {
            return new KiaPreUnitario(PUnitario);
        }
    }
}

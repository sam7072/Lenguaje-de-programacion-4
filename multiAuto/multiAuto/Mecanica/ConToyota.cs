using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using multiAuto.ClassAbstract;
using multiAuto.Toyota;

namespace multiAuto.Mecanica
{
    public class ConToyota : IMecanica
    {
        public Cantidad CreateCantidad(string text)
        {
            return new ToyotaCantidad(text);
        }

        public Descripcion CreateDescripcion(string descrip)
        {
            return new ToyotaDescripcion(descrip);
        }

        public Importe CreateImporte(string importe)
        {
            return new ToyotaImporte(importe);
        }

        public PreUnitario CreatepreUnitario(string PUnitario)
        {
            return new ToyotaPreUnitario(PUnitario);
        }
    }
}

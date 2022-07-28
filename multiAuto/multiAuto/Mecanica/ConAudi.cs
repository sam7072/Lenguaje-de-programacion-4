using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using multiAuto.Audi;
using multiAuto.ClassAbstract;

namespace multiAuto.Mecanica
{
    public class ConAudi : IMecanica
    {
        public Cantidad CreateCantidad(string text)
        {
            return new AudiCantidad(text);
        }

        public Descripcion CreateDescripcion(string descrip)
        {
            return new AudiDescripcion(descrip);
        }

        public Importe CreateImporte(string importe)
        {
            return new AudiImporte(importe);
        }

        public PreUnitario CreatepreUnitario(string PUnitario)
        {
            return new AudiPreUnitario(PUnitario);
        }
    }
}

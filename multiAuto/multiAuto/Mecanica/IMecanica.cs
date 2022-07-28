using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using multiAuto.ClassAbstract;

namespace multiAuto.Mecanica
{
    public interface IMecanica
    {
        public Cantidad CreateCantidad( string text );
        public Descripcion CreateDescripcion( string descrip);
        public Importe CreateImporte( string importe);
        public PreUnitario CreatepreUnitario(string PUnitario);


    }
}

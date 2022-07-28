using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using multiAuto.ClassAbstract;

namespace multiAuto.Toyota
{
    public class ToyotaDescripcion : Descripcion
    {
        string descrip;

        public ToyotaDescripcion(string descrip)
        {
            this.descrip = descrip;
        }

        public override string Paint()
        {
            return "++ " + descrip + " ++";
        }
    }
}

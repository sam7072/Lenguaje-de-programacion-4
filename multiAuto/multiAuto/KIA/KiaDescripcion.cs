using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using multiAuto.ClassAbstract;

namespace multiAuto.KIA
{
    public class KiaDescripcion : Descripcion
    {
        string descrip;

        public KiaDescripcion(string descrip)
        {
            this.descrip = descrip;
        }

        public override string Paint()
        {
            return "-- " + descrip + " --";
        }
    }
}

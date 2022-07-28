using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using multiAuto.ClassAbstract;

namespace multiAuto.Audi
{
    public class AudiDescripcion : Descripcion
    {
        string descrip;

        public AudiDescripcion(string descrip)
        {
            this.descrip = descrip;
        }

        public override string Paint()
        {
            return "** " + descrip + " **";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using multiAuto.ClassAbstract;

namespace multiAuto.Audi
{
    public class AudiImporte : Importe
    {
        string importe;

        public AudiImporte(string importe)
        {
            this.importe = importe;
        }

        public override string Paint()
        {
            return "************* \n" +
                   " " + importe + "\n" +
                   "************* \n";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using multiAuto.ClassAbstract;

namespace multiAuto.KIA
{
    public class KiaImporte : Importe 
    {
        string importe;

        public KiaImporte(string importe)
        {
            this.importe = importe;
        }
        public override string Paint()
        {
            return "--------------- \n" +
                   " " + importe + "\n" +
                   "--------------- \n";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using multiAuto.ClassAbstract;

namespace multiAuto.KIA
{
    public class KiaPreUnitario : PreUnitario
    {
        string PUnitario;

        public KiaPreUnitario(string PUnitario)
        {
            this.PUnitario = PUnitario;
        }
        public override string Paint()
        {
            return "--------------- \n" +
                   " " + PUnitario + "\n" +
                   "--------------- \n";
        }
    }
}

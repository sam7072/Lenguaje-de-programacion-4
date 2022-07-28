using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using multiAuto.ClassAbstract;

namespace multiAuto.Toyota
{
    public class ToyotaPreUnitario : PreUnitario
    {
        string PUnitario;

        public ToyotaPreUnitario(string PUnitario)
        {
            this.PUnitario = PUnitario;
        }
        public override string Paint()
        {
            return "+++++++++++++ \n" +
                   " " + PUnitario + "\n" +
                   "+++++++++++++ \n";
        }
    }
}

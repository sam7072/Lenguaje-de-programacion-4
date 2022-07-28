using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using multiAuto.ClassAbstract;

namespace multiAuto.Audi
{
    public class AudiPreUnitario : PreUnitario
    {
        string PUnitario;

        public AudiPreUnitario(string PUnitario)
        {
            this.PUnitario = PUnitario;
        }

        public override string Paint()
        {
            return "************* \n" +
                   " " + PUnitario + "\n" +
                   "************* \n";
        }
    }
}

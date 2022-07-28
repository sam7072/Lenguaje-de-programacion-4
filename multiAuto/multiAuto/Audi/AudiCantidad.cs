using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using multiAuto.ClassAbstract;

namespace multiAuto.Audi
{
    public class AudiCantidad : Cantidad
    {
        string text;

        public AudiCantidad(string text)
        {
            this.text = text;
        }
        public override string Paint()
        {
            return "************* \n" +
                   " " + text + "\n" +
                   "************* \n";
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using multiAuto.ClassAbstract;

namespace multiAuto.KIA
{
    public class KiaCantidad : Cantidad
    {
        string text;

        public KiaCantidad(string text)
        {
            this.text = text;
        }

        public override string Paint()
        {
            return "--------------- \n" +
                   " " + text + "\n" +
                   "--------------- \n";
        }
    }
}

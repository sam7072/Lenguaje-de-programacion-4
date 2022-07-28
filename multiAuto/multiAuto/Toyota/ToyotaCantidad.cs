using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using multiAuto.ClassAbstract;

namespace multiAuto.Toyota
{
    public class ToyotaCantidad : Cantidad
    {
        string text;

        public ToyotaCantidad(string text)
        {
            this.text = text;
        }

        public override string Paint()
        {
            return "+++++++++++++ \n" +
                   " " + text + "\n" +
                   "+++++++++++++ \n";
        }
    }
}

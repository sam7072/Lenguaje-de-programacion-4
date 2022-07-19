using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria;

namespace RetoFiguras
{
    public class CreateCirculos : Calculo
    {
        public CreateCirculos (String Texto, String Props)
        {
            this.Texto = Texto;
            this.Props = Props;
        }

        public override IFiguras CreateFigura()
        {
            return new Circulos(Texto, Props);
        }
    }
}

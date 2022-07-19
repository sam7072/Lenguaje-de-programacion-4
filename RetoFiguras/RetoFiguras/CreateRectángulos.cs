using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria;

namespace RetoFiguras
{
    public class CreateRectángulos : Calculo
    {

        public CreateRectángulos(String Texto, String Props)
        {
            this.Texto = Texto;
            this.Props = Props;
        }
        public override IFiguras CreateFigura()
        {
            return new Rectángulos(Texto, Props);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria;

namespace RetoFiguras
{
    public class CreatePentagono : Calculo
    {
        public CreatePentagono(String Texto, String Props)
        {
            this.Texto = Texto;
            this.Props = Props;
        }
        public override IFiguras CreateFigura()
        {
            return new Pentagono(Texto,Props);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public abstract class Calculo
    {
        public String Texto { get; set; }
        public String Props { get; set; }

        public abstract IFiguras CreateFigura();

        public Boolean VerCapacidad()
        {
            IFiguras figuras = CreateFigura();
            if (figuras.Texto.Length > figuras.Capacidad())
              {
                return false;


               }
            return true;
        }

        //public Boolean VerCapacidadMaxima()
        //{
        //    IFiguras figuras =
        //}

        public String Imprimir()
        {
            IFiguras figuras = CreateFigura();

            return figuras.Estado();
        }
       
    }
}

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
       

        public String VerificarAreas(float AreaMax, List<Calculo> listaCalculo)
        {

            String respuesta ; 
            float AreaTotal = 0.0f;

            foreach(var item in listaCalculo)
            {
                IFiguras figuras = item.CreateFigura();
                AreaTotal += figuras.Area();
            }
            if (AreaTotal > AreaMax)
            {
                respuesta = " ERROR: El Area Maxima de: " +AreaMax+ "no es sufucuente para el total de areas de las figuras: "+ AreaTotal;
            }
            else
            {
                respuesta = " OK: El Area Maxima de: " + AreaMax + "si es sufucuente para el total de areas de las figuras: " + AreaTotal;
            }

            return respuesta;

        }
    }
}

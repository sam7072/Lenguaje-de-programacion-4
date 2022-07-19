using System;
using System.Collections.Generic;
using System.Linq;

namespace Libreria
{
    public class Circulos :IFiguras
    {
        public String Texto { get; set; }
        public float radio { get; set; }

        public float Area()
        {
            return (float) Math.PI * radio * radio;
        }

        public float Capacidad()
        {
            return 2.0f / 3.0f * 2 * radio; 
        }

        public String Estado()
        {
            return "El Radio es : " + radio+ " Texto: "+ Texto; 
        }


        public Circulos(String Texto, String Props)
        {
            this.Texto = Texto;


            List<String> listaProps = Props.Split(';').ToList();

            List<String> listaValA = listaProps[0].Split('=').ToList();


            this.radio = float.Parse(listaValA[1]);
        }
    }
}

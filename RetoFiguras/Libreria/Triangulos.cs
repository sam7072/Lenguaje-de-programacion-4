using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class Triangulos : IFiguras
    {
        public String Texto { get; set; }
        public float alturaA, alturaV, alturaC;


        public float Area()
        {
            float a = (alturaA + alturaV + alturaC) / 2.0f;
            return (float) Math.Sqrt(a*(a-alturaA)* (a - alturaV) * (a - alturaC));
        }

        public float Capacidad()
        {
            return 2.0f / 3.0f * alturaV;
        }

        public string Estado()
        {
            return "Alturas del triamgulo a= " + alturaA + ", v= " + alturaV + ", c=" + alturaC + " Texto: " + Texto;
        }


        public Triangulos(String Texto, String Props)
        {
            this.Texto = Texto;


            List<String> listaProps = Props.Split(';').ToList();

            List<String> listaValA = listaProps[0].Split('=').ToList();
            List<String> listaValV = listaProps[1].Split('=').ToList();
            List<String> listaValC = listaProps[2].Split('=').ToList();


            this.alturaA = float.Parse(listaValA[1]);
            this.alturaV = float.Parse(listaValA[1]);
            this.alturaC = float.Parse(listaValA[1]);
        }
    }
}

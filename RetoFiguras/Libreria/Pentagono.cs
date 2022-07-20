using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class Pentagono : IFiguras
    {
        public String Texto { get; set; }
        public float Lado { get; set; }

        public float Area()
        {
            return 1.72f*Lado*Lado;
        }

        public float Capacidad()
        {
            return Lado;
        }

        public string Estado()
        {
            return "Pentagono de Lado "+Lado+ " con TEXTO: "+Texto;
        }

        public Pentagono(String Texto, String Props)
        {
            this.Texto = Texto;


            List<String> listaProps = Props.Split(';').ToList();

            List<String> listaValA = listaProps[0].Split('=').ToList();


            this.Lado = float.Parse(listaValA[1]);
        }
    }
}

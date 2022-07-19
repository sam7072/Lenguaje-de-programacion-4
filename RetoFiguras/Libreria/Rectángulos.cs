using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class Rectángulos : IFiguras
    {
        public String Texto { get; set; }
        public float base1 { get; set; }
        public float altura { get; set; }


        public float Area()
        {
            return base1 * altura;
        }

        public float Capacidad()
        {
            return 2.0f / 3.0f * base1;
        }

        public String Estado()
        {
            return "estado del rectangulo" + base1 + " * " +altura + " Texto: " + Texto;
        }

        public Rectángulos(String Texto, String Props)
        {
            this.Texto = Texto;


            List<String> listaProps = Props.Split(';').ToList();

            List<String> listaValA = listaProps[0].Split('=').ToList();
            List<String> listaValV = listaProps[1].Split('=').ToList();


            this.base1 = float.Parse(listaValA[1]);
            this.altura = float.Parse(listaValA[1]);
        }
    }
}

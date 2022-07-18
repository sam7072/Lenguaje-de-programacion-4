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
        public CreateCirculos(string name) : base(name)
        {
            this.name = name;
        }

        public override IFiguras CreateFigura(string name)
        {
            Console.WriteLine("crear circulo");

            Circulos circulos = new Circulos("ciculo", 3, 3, 5);
            circulos.name = name;

            return circulos;

        }

        
    }
}

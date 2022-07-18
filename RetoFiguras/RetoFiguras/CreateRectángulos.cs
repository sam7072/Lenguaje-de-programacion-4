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
        public CreateRectángulos(string name) : base(name)
        {
            this.name = name;
        }
        public override IFiguras CreateFigura(string name)
        {
            Console.WriteLine("crear rectamgulo");

            Rectángulos rectángulos = new Rectángulos("Rectángulo", 3, 4, 10, 7);
            rectángulos.name = name;

            return rectángulos;
                
        }

        

        
    }
}

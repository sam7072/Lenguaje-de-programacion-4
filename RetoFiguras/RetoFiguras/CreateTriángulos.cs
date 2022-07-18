using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria;

namespace RetoFiguras
{
    public class CreateTriángulos : Calculo
    {
        public CreateTriángulos(string name) : base(name)
        {
            this.name = name;
        }

        public override IFiguras CreateFigura(string name)
        {
            Console.WriteLine("Crear Triangulo");

            Triangulos triangulos = new Triangulos("triangulo", 4, 5, 6);
            triangulos.name = name;

            return triangulos;
        }
    }
}

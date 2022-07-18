using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public abstract class Calculo
    {
        public String name { get; set; }


        public Calculo(String name)
        {
            this.name = name;
        }

        public void CalcularFigura()
        {
            Console.WriteLine("Calculo de la figura");
            IFiguras figuras = CreateFigura(name);
            figuras.doStuff();
        }

        public abstract IFiguras CreateFigura(String name);
    }
}

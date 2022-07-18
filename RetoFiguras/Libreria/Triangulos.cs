using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class Triangulos : IFiguras
    {
        public String name { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public int altura { get; set; }


        public Triangulos(String name, int x, int y, int altura)
        {
            this.name = name;
            this.x = x;
            this.y = y;
            this.altura = altura;
        }

        public void doStuff()
        {
            Console.WriteLine("- Triangulo -");
            Console.WriteLine("Figura: " + this.name);
            Console.WriteLine("-- eje x: " + this.x);
            Console.WriteLine("-- eje y: " + this.y);
            Console.WriteLine("-- altura: " + this.altura);
            Console.WriteLine("");
        }

    }
}

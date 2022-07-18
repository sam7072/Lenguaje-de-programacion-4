using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class Rectángulos : IFiguras
    {
        public String name { get; set; }
        public int base1 { get; set; }
        public int altura { get; set; }
        public int x { get; set; }
        public int y { get; set; }


        public Rectángulos(String name, int x, int y, int altura, int base1)
        {
            this.name = name;
            this.base1 = base1;
            this.altura = altura;
            this.x = x;
            this.y = y;
        }

        public void doStuff()
        {
            Console.WriteLine("- Rectangulo -");
            Console.WriteLine("Figura: " + this.name);
            Console.WriteLine("-- eje x: " + this.x);
            Console.WriteLine("-- eje y: " + this.y);
            Console.WriteLine("-- altura: " + this.altura);
            Console.WriteLine("-- base: " + this.base1);
            Console.WriteLine("");
        }
    }
}

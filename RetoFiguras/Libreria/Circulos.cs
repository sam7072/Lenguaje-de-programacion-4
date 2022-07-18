using System;

namespace Libreria
{
    public class Circulos :IFiguras
    {
        public String name { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public int radio { get; set; }

        public void Validar()
        {
            Console.WriteLine("- validar a ");
        }

        public Circulos (String name, int x,int y, int radio)
        {
            this.name = name;
            this.x = x;
            this.y = y;
            this.radio = radio;
        }

        public void doStuff()
        {
            Console.WriteLine("- Circulos -");
            Console.WriteLine("Figura: " + this.name);
            Console.WriteLine("-- eje x: " + this.x);
            Console.WriteLine("-- eje y: " + this.y);
            Console.WriteLine("-- radio: " + this.radio);
            Console.WriteLine("");
        }
    }
}

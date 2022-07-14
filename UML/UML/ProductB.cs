using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML
{
    public class ProductB : IProduct
    {
        public String Modelo { get; set; }
        public int Año { get; set; }
        public String name { get; set; }

        public ProductB(String Modelo, int Año)
        {
            this.Modelo = Modelo;
            this.Año = Año;
        }
        public void doStuff()
        {
            Console.WriteLine(" - Estoy em ProductB / doStuff()");
            Console.WriteLine(" - - nombre: " + this.name);
            Console.WriteLine(" - - - año: " + this.Año);
            Console.WriteLine(" - - - Transporte: " + this.Modelo);
            Console.WriteLine("");
        }
    }
}

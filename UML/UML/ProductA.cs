using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML
{
    public class ProductA : IProduct
    {
        public String Marca { get; set; }
        public String name { get; set; }

        public ProductA(String Marca)
        {
            this.Marca = Marca;
        }


        public void doStuff()
        {
            Console.WriteLine(" - Estoy em ProductA / doStuff()");
            Console.WriteLine(" - - - Producto: " + this.name);
            Console.WriteLine(" - - - Transporte: " + this.Marca);
            Console.WriteLine("");
        }
    }
}

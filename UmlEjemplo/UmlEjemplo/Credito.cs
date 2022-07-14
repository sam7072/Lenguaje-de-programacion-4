using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmlEjemplo
{
    public class Credito
    {
        public String name { get; set; }
        public int cedula { get; set; }

        public Credito(String name, int v)
        {
            this.name = name;
        }

        public void doStuff()
        {
            Console.WriteLine("- Estoy em Credito/ doStuff()");
            Console.WriteLine("-- cliente: " + this.name);
            Console.WriteLine("-- Cedula: " + this.cedula);
            Console.WriteLine("");
        }

    }
}

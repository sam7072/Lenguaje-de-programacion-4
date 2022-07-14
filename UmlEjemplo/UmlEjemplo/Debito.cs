using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmlEjemplo
{
    public class Debito : ITarjeta
    {
        public String name { get; set; }
        public int cedula { get; set; }
        public String Credencial { get; set; }
        public String Domocilio { get; set; }

        public Debito(String name, int cedula, String Credencial, String Domocilio)
        {
            this.name = name;
            this.cedula = cedula;
            this.Credencial = Credencial;
            this.Domocilio = Domocilio;
        }

        public void doStuff()
        {
            Console.WriteLine("- Estoy em Debito/ dostuff()");
            Console.WriteLine("-- Cliente: " + this.name);
            Console.WriteLine("-- Cedula: " + this.cedula);
            Console.WriteLine("-- Credencial o extranjero: " + this.Credencial);
            Console.WriteLine("-- Años de domicilio: " + this.Domocilio);
            Console.WriteLine("");
        }
    }
}

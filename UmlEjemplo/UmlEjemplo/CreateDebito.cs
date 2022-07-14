using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmlEjemplo
{
    public class CreateDebito : Cliente
    {
        public CreateDebito(String name) : base(name)
        {
            this.name=name;
        }
        public override ITarjeta CreateTarjeta(string name)
        {
            Console.WriteLine("- CreateDebito/ CreateTarjeta()");
            Debito debito = new Debito("juam", 1725332769, "Extranjero", "3 años");
            debito.name=name;

            return debito;
        }
    }
}

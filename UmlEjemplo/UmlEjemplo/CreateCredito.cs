using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmlEjemplo
{
    public class CreateCredito : Cliente
    {
        public CreateCredito(String name) : base(name)
        {
            this.name = name;
        }

        public override ITarjeta CreateTarjeta(string name)
        {
            Console.WriteLine("- CreateCredito / CreateTarjeta()");

            Credito credito = new Credito("Mario",17899564);
            credito.name = name;

            return credito;

        }
    }
}

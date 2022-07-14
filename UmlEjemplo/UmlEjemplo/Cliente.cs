using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmlEjemplo
{
    public abstract class Cliente
    {
        public String name { get; set; }


        public Cliente(String name)
        {
            this.name = name;
        }

        public void emiteTarjeta()
        {
            Console.WriteLine("Se ejecuta : emiteTarjeta() ");
            ITarjeta tarjeta = CreateTarjeta(name);
            tarjeta.doStuff();
        }

        public abstract ITarjeta CreateTarjeta(String name);
    }
}

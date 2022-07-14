using System;
using System.Collections.Generic;

namespace UmlEjemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Cliente> lista = new List<Cliente>();


            lista.Add(new CreateCredito("Luis"));
            lista.Add(new CreateCredito("merluso"));

            lista.Add(new CreateDebito("Alfomso"));
            lista.Add(new CreateDebito("Stam"));
            lista.Add(new CreateDebito("Damiam"));

            foreach(Cliente cliente in lista)
            {
                cliente.emiteTarjeta();
            }
        }
    }
}

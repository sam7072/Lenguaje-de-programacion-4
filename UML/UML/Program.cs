using System;
using System.Collections.Generic;

namespace UML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Creator> lista = new List<Creator>();


            lista.Add(new CreateProductA("Material industrial"));
            lista.Add(new CreateProductA("Pescados "));
            
            lista.Add(new CreateProductB("Fertilizante"));
            lista.Add(new CreateProductB("paquete de huevos"));
            lista.Add(new CreateProductB("paquete de leche"));

            foreach(Creator creator in lista)
            {
                creator.SomeOperation();
            }
        }
    }
}

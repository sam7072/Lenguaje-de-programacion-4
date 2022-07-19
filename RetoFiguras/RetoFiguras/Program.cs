using System;
using System.Collections.Generic;
using Libreria;
using RetoFiguras.Json;

namespace RetoFiguras
{
    internal class Program
    {
        static void Main(string[] args)
        {

            dataset json = GestorJson.Leer("ListaFiguras.json");

            List<Calculo> listaCalculo = new List<Calculo>();
            foreach(var regs in json.Lista)
            {
                switch(regs.Tipo)
                {
                    case "Circulo":
                        listaCalculo.Add(new CreateCirculos(regs.Texto, regs.Props));
                        break;
                    case "Triangulo":
                        listaCalculo.Add(new CreateTriángulos(regs.Texto, regs.Props));
                        break;
                    case "Rectangulo":
                        listaCalculo.Add(new CreateRectángulos(regs.Texto, regs.Props));
                        break;
                }
            }

            //ejecuciom
            foreach(var fig in listaCalculo)
            {
                Console.WriteLine(fig.Imprimir());
                Console.WriteLine("se puede divujar: "+fig.VerCapacidad()); 


            }
        }
    }
}

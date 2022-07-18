using System;
using System.Collections.Generic;
using Libreria;

namespace RetoFiguras
{
    internal class Program
    {
        static void Main(string[] args)
        {


            List<Calculo> lista = new List<Calculo>();

            lista.Add(new CreateCirculos("circulo"));
            lista.Add(new CreateRectángulos("Rectángulo"));
            lista.Add(new CreateTriángulos("Triángulo"));

            foreach(Calculo c in lista)
            {
                c.CalcularFigura();
            }
        }
    }
}

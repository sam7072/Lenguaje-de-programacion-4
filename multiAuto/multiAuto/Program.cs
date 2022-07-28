using System;
using multiAuto.Mecanica;

namespace multiAuto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CajaRepuestos rep = new CajaRepuestos(new ConKia());

            rep.CrearPresupuesto();
            rep.Paint();
        }
    }
}

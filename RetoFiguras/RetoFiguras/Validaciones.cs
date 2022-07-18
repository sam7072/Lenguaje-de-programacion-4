using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetoFiguras
{
    public class Validaciones
    {
        public static void Validar(List<CreateCirculos> listaCirculos)
        {
            int x, y, radio;
            Console.Write("Ingresar el radio del circulo: ");
            radio = int.Parse(Console.ReadLine());
            for (x = 0; x <= radio * 2; x++) //Altura
            {
                for (y = 0; y <= radio * 2; y++) //Rellenar
                {
                    //Ecuacion circunferencia
                    //((X-h)^2) + ((y-k)^2) = radio^2 
                    if (Math.Pow(y - radio, 2) + Math.Pow(x - radio, 2) <= (int)Math.Pow(radio, 2))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine(" ");

            }


        }


        public static void Validar(List<CreateRectángulos> listaRectángulos)
        {
            int base1, altura, x, y;
            Console.Write("Ingresar la base del rectangulo: ");
            base1 = int.Parse(Console.ReadLine());
            Console.Write("Ingresar la altura del rectangulo: ");
            altura = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            for (x = 1; x <= altura; x++)
            {
                for (y = 1; y <= base1; y++)
                {
                    Console.Write("* ", y);
                }
                Console.WriteLine(" ");
            }

        }

        public static void Validar(List<CreateTriángulos> listaTriangulos)
        {
            int x, y, altura;
            Console.Write("validar Triángulo: ");
            altura = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            for (x = 1; x <= altura; x++)
            {
                for (y = altura - x; y > 0; y--)
                {
                    Console.Write(" ");
                }
                for (y = 1; y < x; y++)
                {
                    Console.Write("**");
                }
                Console.WriteLine("*");
            }
        }
    }
}

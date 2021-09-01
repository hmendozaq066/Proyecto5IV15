using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase02.Clases;

namespace Clase02
{
    class Program
    {
        static void Main(string[] args)
        {
            var complejo = new Complejo(1, 2);//Aquí estamos estableciendo la instancia de la clase complejo

            Console.WriteLine("El valor de A es " + complejo.A);
            Console.WriteLine("El valor de B es " + complejo.B);
            Console.WriteLine("La forma binomica es " + complejo.FormaBinomica());

            var complejo2 = new Complejo(10, 5);

            Console.WriteLine("El valor de A es " + complejo2.A);
            Console.WriteLine("El valor de B es " + complejo2.B);
            Console.WriteLine("La forma binomica es " + complejo2.FormaBinomica());

            var resultado = complejo.Suma(complejo2);
            Console.WriteLine("La forma binomica es " + resultado.FormaBinomica());

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase02.Clases
{
    class Complejo
    {
        //Propiedades o Atributos
        public int A { get; set; }
        public int B { get; set; }


        /*
         * Constructores
         * A constructor in C# is a member of a class. It is a method in the class which 
         * gets executed when a class object is created. Usually we put the initialization 
         * code in the constructor. The name of the constructor is always is the same 
         * name as the class. A C# constructor can be public or private.
         * 
         * Sintaxis
         * public|private NombreDeLaClase (parámetros) { código }
         */

        public Complejo(int A, int b)
        {
            System.Console.WriteLine("Ejecutando el contructor con 2 parámetros");
            /*
             * this
             * The C# “this” keyword represents the “this” pointer of a class or a struct. 
             * The this pointer represents the current instance of a class or struct.
             */
            this.A = A; //Cuando la propiedad se llama igual que la variable local se debe usar this
            this.B = b;//En caso contrario es opcional
        }

        //¿Como sabemos que esta sobrecargado? R= porque el método o constructor se llaman igual pero tiene diferentes parámetros

        public Complejo()
        {
            /*
             * Como hemos visto el constructor es un método y como tal podemos sobrecargarlo, 
             * es decir definir varios constructores con distintas cantidades o tipos de parámetros.
             */
            Console.WriteLine("Ejecutando con el constructor sin parámetros");
            A = 0;
            B = 0;//Aquí no se utiliza this porque no hay otras variables locales con el mismo nombre
        }

        /*
         * Suma de numeros complejos
         * z = 5 + 4i  
         * y = 6 + 10i
         * 
         * z + y = (5 + 6) + (4 + 10)i = 11 + 14i
         * 
         */

        public Complejo Suma(Complejo complejo)
        {
            var resultado = new Complejo();
            resultado.A = A + complejo.A;
            resultado.B = B + complejo.B;
            return resultado;
        }

        public string FormaBinomica()
        {
            return string.Format("{0} + {1}i", A, B);
        }

    }
}

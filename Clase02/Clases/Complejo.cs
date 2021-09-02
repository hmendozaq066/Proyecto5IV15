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

        /// <summary>
        /// Suma un número complejo que se envía
        /// </summary>
        /// <param name="complejo">Número complejo a sumar</param>
        /// <returns>Una instancia de la clase Complejo con el resultado de la suma</returns>
        public Complejo Suma(Complejo complejo)
        {
            //En la siguiente linea estamos haciendo instancia de la clase Complejo
            //que se llamará resultado
            var resultado = new Complejo();
            //Para acceder a cada atributo de la objeto Complejo se debe usar un punto
            resultado.A = A + complejo.A;
            resultado.B = B + complejo.B;
            //Aquí retornamos un objeto Complejo que se llama resultado 
            return resultado;
        }

        public Complejo Suma(int ParteReal, int ParteImaginaria)
        {
            var resultado = new Complejo();
            resultado.A = A - ParteReal;
            resultado.B = B - ParteImaginaria;
            return resultado;
        }

        public bool SonIguales(Complejo comparar)
        {
            if (A == comparar.A && B == comparar.B) return true;
            return false;
        }

        public bool SonIguales(int A, int B)
        {
            //Operador ternario
            return (this.A == A && this.B == B) ? true : false;
            //Se puede simplificar aun más dejandolo de la siguiente forma
            //return (this.A == A && this.B == B);
            //Sintaxis
            // (condición) ? valor en caso verdadero : valor en caso de falso;
        }

        //Implementar el metódo que diga si dos números complejos son iguales
        //public bool SonIguales(Complejo comparar)
        // A = A 
        // B = B

        //z = 4 + 5i
        //y = 4 + 5i

        //w = 4 + 5i
        //x = 5 + 4i

        /// <summary>
        /// Resta un número complejo que se envía
        /// </summary>
        /// <param name="complejo">Número complejo a restar</param>
        /// <returns>Una instancia de la clase Complejo con el resultado de la resta</returns>
        public Complejo Resta(Complejo complejo)
        {
            var resultado = new Complejo();
            resultado.A = A - complejo.A;
            resultado.B = B - complejo.B;
            return resultado;
        }

        /// <summary>
        /// Devuelve una cadena con la representación del número complejo
        /// </summary>
        /// <returns>String con la forma binómica de un número complejo</returns>
        public string FormaBinomica()
        {
            return string.Format("{0} + {1}i", A, B);
        }

    }
}

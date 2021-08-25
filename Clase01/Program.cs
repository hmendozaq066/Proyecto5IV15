using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Buenas practicas
             1.- Las clases deben estar en nomenclatura camello alta y en singular
            2.- Poner en carpetas los diferentes elementos para organizarlos dependiendo de su funcionamiento
            3.- Las clases de forma predeterminada son privadas
            4.- Para rearlizar una instancia es de la siguiente forma: var nombre = new Clase();
             */

            var persona = new Clases.Persona(); //Una instancia de un objeto F1
            //Clases.Persona persona = new Clases.Persona(); // F2 de hacer una instancia
            //Para asignar un valor a una propiedad este debe estar a la izquierda del =
            Console.Write("Escribe tu nombre: ");
            persona.Nombre = Console.ReadLine();

            Console.Write("Escribe tu estatura: ");
            //persona.Estatura = int.Parse(Console.ReadLine());
            persona.Estatura = Convert.ToInt32(Console.ReadLine());

            Console.Write("Escribe tu peso: ");
            persona.Peso = float.Parse(Console.ReadLine());

            Console.Write("Escribe tu fecha de nacimiento: ");
            persona.FechaNacimiento = DateTime.Parse(Console.ReadLine());

            Console.Write("Tienes enfermedades (Si/NO): ");
            var respuesta = Console.ReadLine();

            if (respuesta.ToUpper() == "SI")
                persona.TieneEfermedades = true;
            else
                persona.TieneEfermedades = false;

            //persona.TieneEfermedades = (respuesta == "SI") ? true : false; // Operador ternario                

            Console.WriteLine("Tu nombre es: " + persona.Nombre);
            Console.WriteLine("Tu nombre es: " + persona.Nombre.ToLower());
            Console.WriteLine("Tu nombre es: " + persona.Nombre.ToUpper());
            Console.WriteLine("Tu nombre es: " + persona.Nombre.Trim());
            Console.WriteLine("Tu nombre sin los ultimos 4 caracteres es: " + persona.Nombre.Substring(0, persona.Nombre.Length - 4));
            Console.WriteLine("Tu nombre es: " + persona.Nombre.Substring(0, 4).ToUpper());
            Console.WriteLine("Tu nombre tiene " + persona.Nombre.Length + " letras");

            Console.WriteLine("Tu estatura es: " + persona.Estatura);
            Console.WriteLine("Tu peso es: " + persona.Peso);
            Console.WriteLine("Tu fecha de nacimiento es: " + persona.FechaNacimiento);
            Console.WriteLine("Tienes enfermedades: " + persona.TieneEfermedades);

            //detener la ejecución

            Console.ReadKey();
        }
    }
}

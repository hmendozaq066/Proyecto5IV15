using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase03
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * 
Agenda
	Contactos
	
	BuscarNombre
	BuscarNumero
	BuscarApellidoMaterno
	BuscarApellidoPaterno
	BuscarPorCorreoElectronico
	Borrar 
	Agregar
	Editar
	Marcar

Contacto
    ID
	Nombre
	Apellido paterno
	Apellido materno
	Número de celular |13 ó 10| solo enteros | 5556465066 -- 55 5646 5066 --  +(52) 55-5646-5066
	Número fijo
	Extensión
	Correo electronico | unico | gmail | outlook
	Bloqueado
	Estado
	Tipo
	
	Bloquear
	NombreCompleto
	Desbloquear
	Editar
    MostrarNumeroConFormato
	Archivar             
             */
            /*
             * C# List class represents a collection of strongly typed objects that can be accessed by index.
             * Sintaxis:
             * List<TipoDato> nombre = new List<TipoDato>(); 
             */

            List<int> numeros = new List<int>();
            //Las listas tienen el método Add para agregar elementos a esta
            numeros.Add(10);
            numeros.Add(15);
            numeros.Add(15);
            numeros.Add(29);
            numeros.Add(59);

            string cadena = "Hola ";
            Console.WriteLine("|" + cadena + "|"); // | Hola |
            Console.WriteLine("|" + cadena.Trim() + "|"); // |Hola|

            bool agregar = true;
            do
            {
                Console.WriteLine("Ingresa un número: ");
                //Estamos leyendo la consola, y lo convertimos en int
                numeros.Add(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("¿Deseas ingresar otro número [S/N]?: ");
                           //Leyendo linea - Eliminamos espacios - Convertimos en mayusculas
                           //Obtenemos la primera letra. Si es "S" se almacena true en la variable
                           //agregar, de lo contrario se almacena false.
                agregar = (Console.ReadLine().Trim().ToUpper().Substring(0, 1) == "S") ? true : false;

            } while (agregar == true); //Mientras agregar sea igual a verdadero ejecuta de nuevo

            List<string> nombres = new List<string>();
            nombres.Add("Héctor");
            nombres.Add("Mendoza");
            nombres.Add("Juan");

            List<bool> resultados = new List<bool>();
            resultados.Add(true);
            resultados.Add(false);
            resultados.Add(false);

            /*
             * The foreach statement in C# iterates through a collection of items such as an array or list
             * Sintaxis
             * foreach(tipo nombre in coleccion){ sentencias }
             */
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            foreach (string nom in nombres)
            {
                Console.WriteLine(nom);
            }

            foreach (bool resultado in resultados)
            {
                Console.WriteLine(resultado);
            }
            //Para acceder a un elemento especifico de una lista se utiliza el indice
            //sintaxis
            //Lista[indice];
            Console.WriteLine("El elemento con indice 3 de números es: " + numeros[3]);
            //Count en una lista nos devuelve el número de elementos de esa lista
            Console.WriteLine("Tamaño de la lista numeros: " + numeros.Count);
            Console.WriteLine("El último elemento es: " + numeros[numeros.Count - 1]);

            foreach(int item in numeros)
            {
                /*
                 * 3/2 = 1
                 * 4/2 = 0
                 */
                if(item % 2 == 0)
                {
                    Console.WriteLine("El número " + item + " es par");
                }
            }

            

            Console.ReadKey();
        }
    }
}

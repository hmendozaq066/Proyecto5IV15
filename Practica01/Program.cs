using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//El using nos ayuda a no escribir o importar las librerias que necesitamos
//we use the using keyword to import external resources (namespaces, classes, etc) inside a program
using Practica01.Agenda;

namespace Practica01
{
    class Program
    {
        static void Main(string[] args)
        {
            Manejador manejador = new Manejador();
            manejador.CargarArchivo();
            int opcion;
            do
            {
                opcion = manejador.MostrarMenu();
                switch (opcion)
                {
                    case 1:
                        manejador.MostrarContactos();
                        break;
                    case 2:
                        manejador.AgregarContacto();
                        break;
                    case 3:
                        manejador.EliminarContacto();
                        break;
                    case 6:
                        manejador.GuardarArchivo();
                        break;
                    default:
                        break;
                }
                Console.Write("Presiona cualquier tecla para continuar...");
                Console.ReadKey();
            } while (opcion != 6);
            manejador.GuardarArchivo();
        }

    }

    class Manejador
    {
        private CAgenda agenda = new CAgenda();
        /// <summary>
        /// La propiedad archivo guardará la ubicación de nuestro archivo de datos
        /// </summary>
        private string archivo = @"D:\ejemplos\contactos.txt";

        /// <summary>
        /// Lee un archivo de texto separado por |, carga las lineas leídas en la lista Contactos
        /// </summary>
        /// <returns></returns>
        public bool CargarArchivo()
        {
            //Creamos una instancia del tipo streamreader para leer las lineas del archivo
            StreamReader lector = new StreamReader(archivo);
            string linea;
            //Leemos todas lineas hasta encontrar una linea null
            while((linea = lector.ReadLine()) != null)
            {
                //separamos en un array de string la linea usando como separador al |
                string[] elementos = linea.Split('|'); //Pipe
                //Agregamos el contacto a la agenda
                agenda.AgregarContacto(elementos[1], elementos[2], elementos[3], elementos[7], elementos[4], elementos[5], elementos[6], elementos[8]);
            }
            //Cerrarmos el archivo
            lector.Close();
            return true;
        }

        public bool GuardarArchivo()
        {
            //System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "\\Contactos.db";
            //Creamos una instancia del tipo streamwriter con el escribimos el archivo
            StreamWriter file = new StreamWriter(archivo);
            //recorremos la lista de contactos
            foreach (Contacto cto in agenda.GetContactos())
            {
                //escribimos una linea con el formato separado por |
                file.WriteLine(cto.GenerarLinea());
            }
            //Cerramos el archivo
            file.Close();
            Console.WriteLine("Se guardo el archivo correctamente");
            return true;
        }

        public int MostrarMenu()
        {
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("Agenda v1.0");
                Console.WriteLine("1.- Mostrar contactos");
                Console.WriteLine("2.- Agregar contacto");
                Console.WriteLine("3.- Eliminar contacto");
                Console.WriteLine("4.- Buscar contacto");
                Console.WriteLine("5.- Buscar contactos");
                Console.WriteLine("6.- Salir");
                Console.Write("Selecciona una opción: ");
                opcion = Convert.ToInt32(Console.ReadLine());
            } while (opcion <= 0 || opcion > 6);
            return opcion;
        }

        public void EliminarContacto()
        {
            Console.Clear();
            Console.WriteLine("Eliminar contacto.");
            Console.Write("Indica el ID del contacto a eliminar: ");
            int ID = Convert.ToInt32(Console.ReadLine());
            if (agenda.EliminarContacto(ID))
            {
                Console.WriteLine("El contacto se elimino correctamente");
            }
            else
            {
                Console.WriteLine("No se localizo el contacto");
            }
        }

        public void AgregarContacto()
        {
            Console.Clear();
            Console.WriteLine("Agregar contacto.");
            Console.WriteLine("Captura los datos indicados");
            
            Console.Write("Nombre: ");
            string Nombre = Console.ReadLine();

            Console.Write("Apellido paterno: ");
            string ApellidoPaterno = Console.ReadLine();

            Console.Write("Apellido materno: ");
            string ApellidoMaterno = Console.ReadLine();

            Console.Write("Número de celular: ");
            string NumeroCelular = Console.ReadLine();

            Console.Write("Correo electrónico: ");
            string CorreoElectronico = Console.ReadLine();

            if(agenda.AgregarContacto(Nombre, ApellidoPaterno, ApellidoMaterno, CorreoElectronico, NumeroCelular, "", ""))
            {
                Console.WriteLine("Contacto agregado correctamente");
            }
            else
            {
                Console.WriteLine("El contacto no se pudo agregar por los siguientes errores:");
                foreach(string error in agenda.GetErrores())
                {
                    Console.WriteLine("\t\t" + error);
                }
            }
        }

        public void MostrarContactos()
        {
            Console.Clear();

            if(agenda.GetContactos().Count == 0)
            {
                Console.WriteLine("Mostrar todos los contactos");
                Console.WriteLine("---------------------------------------------------------------------------------");
                Console.WriteLine("No hay contactos para mostrar");
            }
            else
            {
                Console.WriteLine("Mostrar todos los contactos");
                Console.WriteLine("---------------------------------------------------------------------------------");
                foreach (Contacto contacto in agenda.GetContactos())
                {
                    Console.WriteLine("ID\t\t\t" + contacto.ID);
                    Console.WriteLine("Nombre\t\t\t" + contacto.Nombre);
                    Console.WriteLine("Apellido paterno\t" + contacto.ApellidoPaterno);
                    Console.WriteLine("Apellido materno\t" + contacto.ApellidoMaterno);
                    Console.WriteLine("Número celular\t\t" + contacto.NumeroCelular);
                    Console.WriteLine("Correo electrónico\t" + contacto.CorreoElectronico);
                    Console.WriteLine("---------------------------------------------------------------------------------");
                }
                Console.WriteLine("Se mostraron " + agenda.GetContactos().Count + " contacto(s)");
            }
        }


    }

}

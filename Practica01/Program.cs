using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                    default:
                        break;
                }
                Console.Write("Presiona cualquier tecla para continuar...");
                Console.ReadKey();
            } while (opcion != 6);
        }

    }

    class Manejador
    {
        private CAgenda agenda = new CAgenda();

        public int MostrarMenu()
        {
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("Agenda v1.0");
                Console.WriteLine("1.- Mostrar contactos");
                Console.WriteLine("2.- Agregar contacto");
                Console.WriteLine("3.- Elimnar contacto");
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

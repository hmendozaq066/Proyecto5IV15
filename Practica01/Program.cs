﻿using System;
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
            var agenda = new CAgenda();
            bool agregar = true;
            do
            {
                Console.WriteLine("Escribe el nombre del contacto: ");
                string Nombre = Console.ReadLine().Trim();

                Console.WriteLine("Escribe el apellido paterno del contacto: ");
                string ApellidoPaterno = Console.ReadLine().Trim();

                Console.WriteLine("Escribe el apellido materno del contacto: ");
                string ApellidoMaterno = Console.ReadLine().Trim();

                Console.WriteLine("Escribe el número celular del contacto: ");
                string NumeroCelular = Console.ReadLine().Trim();

                Console.WriteLine("Escribe el número fijo del contacto: ");
                string NumeroFijo = Console.ReadLine().Trim();

                Console.WriteLine("Escribe el extensión celular del contacto: ");
                string Extension = Console.ReadLine().Trim();

                Console.WriteLine("Escribe el correo electrónico del contacto: ");
                string CorreoElectronico = Console.ReadLine().Trim();

                /* Estamos usando el método Agregar contacto */
                if (agenda.AgregarContacto(Nombre, ApellidoPaterno, ApellidoMaterno, CorreoElectronico, NumeroCelular, NumeroFijo, Extension, "Familia"))
                {
                    Console.WriteLine("Contacto agregado correctamente");
                }
                else
                {
                    var errores = agenda.GetErrores();
                    foreach (string error in errores) Console.WriteLine(error);
                }

                Console.WriteLine("¿Deseas agregar otro usuario [S/N]?: ");
                string confirmar = Console.ReadLine().Trim();

                agregar = (confirmar.ToUpper().Trim().Substring(0, 1) == "S") ? true : false;

            } while (agregar == true);

            


            /*var contacto = new Contacto();

            Console.WriteLine("Escribe el número de contacto: ");
            contacto.ID = Convert.ToInt32(Console.ReadLine().Trim());

            Console.WriteLine("Escribe el nombre del contacto: ");
            contacto.Nombre = Console.ReadLine().Trim();

            Console.WriteLine("Escribe el apellido paterno del contacto: ");
            contacto.ApellidoPaterno= Console.ReadLine().Trim();

            Console.WriteLine("Escribe el número celular del contacto: ");
            contacto.NumeroCelular = Console.ReadLine().Trim();

            Console.WriteLine("Escribe el correo electrónico del contacto: ");
            contacto.CorreoElectronico = Console.ReadLine().Trim();

            if (contacto.Validar())
            {
                Console.WriteLine("La validación fue correcta");
            }
            else
            {
                var errores = contacto.GetErrores();
                Console.WriteLine("Hay errores en la captura");
                foreach (string error in errores) Console.WriteLine(error);
            }*/

            /*
                //contacto.Errores.Add("Puedo agregar errores sin necesidad de validar");//¿Que pasa?
                contacto.ID = 1;
                contacto.Nombre = "Héctor";
                contacto.ApellidoPaterno = "Mendoza";
                contacto.NumeroCelular = "5556465066";
                contacto.CorreoElectronico = "hmendoza@gmail.com";
                Console.WriteLine("La validación del contacto es: " + contacto.Validar().ToString());
             */

            Console.ReadKey();
        }
    }
}

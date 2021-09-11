using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Practica01.Agenda
{
    class Contacto
    {
        //Propiedades públicas
        public int ID { get; set; } //Obligatorio
        public string Nombre { get; set; } //Obligatorio
        public string ApellidoPaterno { get; set; } //Obligatorio
        public string ApellidoMaterno { get; set; } //Opcional
        public string NumeroCelular { get; set; } //Obligatorio, validar que sean 10 dígitos
        public string NumeroFijo { get; set; } //Opcional, validar que sean 10 dígitos en caso de ser capturado
        public string Extension { get; set; } //Opcional
        public string CorreoElectronico { get; set; } //Obligatorio, validar que sea un email correcto
        public string Tipo { get; set; } //Opcional, si no se pone se manda a General
        public int Bloqueado { get; set; } //1.- No 2.- Si
        public int Estado { get; set; } //1.- Activo, 2.- Eliminado

        /// <summary>
        /// Aquí tenemos una lista donde se almacenarán los errores
        /// </summary>
        private List<string> Errores;
        /* ENCAPSULAMIENTO
         * 
         * Es un principio por el cual, toda persona que use una clase (mediante la instanciación) 
         * no va a tener la oportunidad de cambiar los atributos de la clase. Esto significa, 
         * por tanto, que las propiedades de la misma estarán ocultas. Cuando un programador 
         * no puede cambiar directamente un atributo de una clase se dice que se cumple la 
         * encapsulación que se requiere en la Programación Orientada a Objeto.
         */

        /// <summary>
        /// Devuelte los errores que se producen en la validación
        /// </summary>
        /// <returns>Lista de string con los errores</returns>
        public List<string> GetErrores()
        {
            return Errores;
        }
        /// <summary>
        /// Este es el constructor sin parámetros, recuerda que se llama igual que la clase y no devuelve valores de retorno
        /// </summary>
        public Contacto()
        {
            Errores = new List<string>();
            NumeroCelular = "";
            CorreoElectronico = "";
        }

        /// <summary>
        /// Valida las condiciones especificas de la clase contacto
        /// </summary>
        /// <returns>Verdaro si la validación fue correcta de lo contrario será falso</returns>
        public bool Validar()
        {
            if(ID <= 0)
            {
                Errores.Add("El ID no puede tener un valor de 0");
            }
            if (string.IsNullOrEmpty(Nombre))
            {
                Errores.Add("El Nombre es un dato obligatorio");
            }
            if (string.IsNullOrEmpty(ApellidoPaterno))
            {
                Errores.Add("El Apellido paterno es un dato obligatorio");
            }
            if (NumeroCelular.Length != 10)
            {
                Errores.Add("El Número de celular es un dato obligatorio ó no tiene el formato adecuado");
            }
            if(IsEmail(CorreoElectronico) == false)
            {
                Errores.Add("El Correo electrónico es un dato obligatorio ó no tiene el formato adecuado");
            }

            return (Errores.Count == 0) ? true : false;
        }

        /// <summary>
        /// Método privado que valida un correo electrónico
        /// </summary>
        /// <param name="emailaddress"></param>
        /// <returns></returns>
        private bool IsEmail(string emailaddress)
        {
            try
            {
                if (string.IsNullOrEmpty(emailaddress)) return false;

                MailAddress m = new MailAddress(emailaddress);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        public string NombreCompleto()
        {
            return Nombre + " " + ApellidoPaterno + " " + ApellidoMaterno;
        }

    }
}

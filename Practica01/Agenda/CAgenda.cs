using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica01.Agenda
{
    class CAgenda
    {
        /// <summary>
        /// Una lista que almacena los contactos que se vayan agregando a nuestra agenda
        /// Es privado porque no debemos permitir su acceso directo
        /// </summary>
        private List<Contacto> Contactos;
        private List<string> Errores;

        public List<string> GetErrores()
        {
            return Errores;
        }

        /// <summary>
        /// Constructor predeterminado que inicializa la lista de contactos
        /// </summary>
        public CAgenda()
        {
            Contactos = new List<Contacto>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Nombre"></param>
        /// <param name="ApellidoPaterno"></param>
        /// <param name="ApellidoMaterno"></param>
        /// <param name="CorreoElectronico"></param>
        /// <param name="NumeroCelular"></param>
        /// <param name="NumeroFijo"></param>
        /// <param name="Extension"></param>
        /// <param name="Tipo"></param>
        /// <returns></returns>
        public bool AgregarContacto(string Nombre, string ApellidoPaterno, string ApellidoMaterno, string CorreoElectronico,
            string NumeroCelular, string NumeroFijo, string Extension, string Tipo = "General") //Parámetros opcionales o con valores predeterminados
        {
            /*
             * REGLAS DE LOS PARAMETROS OPCIONALES O PREDETERMINADOS
             * Siempre deben ser los últimos y no deben de tener intercalados parámetros necesarios
             */
            var contacto = new Contacto();
            contacto.ID = Contactos.Count + 1;
            contacto.Nombre = Nombre;
            contacto.ApellidoPaterno = ApellidoPaterno;
            contacto.ApellidoMaterno = ApellidoMaterno;
            contacto.CorreoElectronico = CorreoElectronico;
            contacto.NumeroCelular = NumeroCelular;
            contacto.NumeroFijo = NumeroFijo;
            contacto.Extension = Extension;
            contacto.Tipo = Tipo;
            contacto.Bloqueado = 1;
            contacto.Estado = 1;

            if (contacto.Validar())
            {
                Contactos.Add(contacto);
                return true;
            }
            Errores = contacto.GetErrores();
            return false;
        }

        public List<Contacto> BuscarTodosLosContactosPorNombre(string criterio, bool parcial = true)
        {
            var listaContactos = new List<Contacto>();
            foreach (Contacto contacto in Contactos)
            {
                if (parcial == true)
                {
                    if (contacto.Nombre.ToUpper().Trim().Contains(criterio.ToUpper().Trim()) == true)
                    {
                        listaContactos.Add(contacto);
                    }
                }
                else
                {
                    if (contacto.Nombre.ToUpper().Trim() == criterio.ToUpper().Trim())
                    {
                        listaContactos.Add(contacto);
                    }
                }
            }
            return listaContactos;
        }

        public Contacto BuscarPorNombre(string criterio, bool parcial = true)
        {
            //HECTOR MANUEL --> HECTOR  --> TRUE
            //HECTOR MANUEL --> MANUEL --> TRUE
            //HECTOR MANUEL --> HECTOR MANUEL --> FALSE
            //Hector Mendoza --> HECTOR
            //Recorremos la Lista Contactos y lo almacenamos en contacto
            //Julio --> juli 
            foreach(Contacto contacto in Contactos)
            {
                //Si parcial es verdadero
                if(parcial == true)
                {
                    //Busca en el nombre que contenga el criterio
                    //Se convierte en mayusculas y se eliminan espacios para una mejor busqueda
                    if(contacto.Nombre.ToUpper().Trim().Contains(criterio.ToUpper().Trim()) == true)
                    {
                        return contacto;
                    }
                }
                else
                {
                    //Se compara si nombre es igual a criterio
                    if(contacto.Nombre.ToUpper().Trim() == criterio.ToUpper().Trim())
                    {
                        return contacto;
                    }
                }
            }
            //Si no localiza devuelve null
            return null;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase05.Clase
{
    class Usuario
    {
        public int IDUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
        public string CorreoElectronico { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Genero { get; set; }
        public int Semestre { get; set; }
        public string NumeroTelefono { get; set; }
        public string CURP { get; set; }

        private List<string> Errores = new List<string>();

        public List<string> GetErrores() => Errores;
        /*public List<string> GetErrores()
        {
            return Errores;
        }*/
        

        public bool Validar()
        {
            if (string.IsNullOrEmpty(NombreUsuario))
            {
                Errores.Add("El nombre de usuario es obligatorio");
            }
            if (string.IsNullOrEmpty(Contrasena))
            {
                Errores.Add("La contraseña es obligatoria");
            }
            if (string.IsNullOrEmpty(CorreoElectronico))
            {
                Errores.Add("El correo electrónico es obligatorio");
            }
            if(FechaNacimiento == null)
            {
                Errores.Add("La fecha de nacimiento es obligatoria");
            }
            if (string.IsNullOrEmpty(Genero))
            {
                Errores.Add("El género es obligatorio");
            }
            if(Semestre <= 0 || Semestre > 6)
            {
                Errores.Add("El semestre no es válido");
            }
            if (string.IsNullOrEmpty(CURP))
            {
                Errores.Add("La CURP es obligatoria");
            }else if(CURP.Length != 18)
            {
                Errores.Add("La longitud de la CURP no es correcta");
            }
            return (Errores.Count == 0) ? true : false;
        }

    }
}

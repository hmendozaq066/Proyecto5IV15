using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
        
        public string GenerarLinea()
        {
            return string.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}", IDUsuario.ToString(), NombreUsuario, Contrasena,
                CorreoElectronico, FechaNacimiento.ToString(), Genero, Semestre.ToString(), NumeroTelefono, CURP);
        }

        public bool Guardar()
        {
            //Ruta absoluta, es indicar desde la unidad donde se va a guardar ie D:\poo\5IV15\Proyecto5IV15\Clase05\bin\Debug\datos\usuarios.txt
            //Ruta relativa, de donde estoy (ejecutable) buscar carpeta o archivo ie .\usuarios.txt ==> TOTALMENTE RECOMENDADO
            StreamWriter file = new StreamWriter(@".\usuarios.txt", append: true); 
            file.WriteLine(GenerarLinea());
            file.Close();
            return true;
        }

        public bool ValidarUsuario()
        {
            var usuarios = CargarUsuarios();
            foreach(Usuario persona in usuarios)
            {
                if(persona.NombreUsuario == NombreUsuario && persona.Contrasena == Contrasena)
                {
                    return true;
                }
            }
            return false;
        }

        public List<Usuario> CargarUsuarios()
        {
            StreamReader lector = new StreamReader(@".\usuarios.txt");
            var usuarios = new List<Usuario>();
            string linea;
            //Leemos todas lineas hasta encontrar una linea null
            while ((linea = lector.ReadLine()) != null)
            {
                //separamos en un array de string la linea usando como separador al |
                string[] elementos = linea.Split('|'); //Pipe
                
                var persona = new Usuario();
                persona.IDUsuario = Convert.ToInt32(elementos[0]);
                persona.NombreUsuario = elementos[1];
                persona.Contrasena = elementos[2];
                persona.CorreoElectronico = elementos[3];
                persona.FechaNacimiento = Convert.ToDateTime(elementos[4]);
                persona.Genero = elementos[5];
                persona.Semestre = Convert.ToInt32(elementos[6]);
                persona.NumeroTelefono = elementos[7];
                persona.CURP = elementos[8];
                usuarios.Add(persona);
            }
            //Cerrarmos el archivo
            lector.Close();
            return usuarios;
        }

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

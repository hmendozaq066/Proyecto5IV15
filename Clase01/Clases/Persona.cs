using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase01.Clases
{
    class Persona
    {
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Genero { get; set; }
        public int Estatura { get; set; }
        public float Peso { get; set; }
        public bool TieneEfermedades { get; set; }
        public string LugarNacimiento { get; set; }

        //Definición de Métodos
        //Sintaxis ámbito valorRetorno Nombre(Argumentos){ código } 
        //ámbito public|private|protected
        //valorRetorno int|float|bool|string|list|Object...
        //Tiene que empezar con una letra y es alfanumérico
        //BP NO usar Ñ Ü o acentos
        //BP Usar nomenclatura camello alta

        public int CalcularEdad()
        {
            //Para declarar una variable 
            //Sintaxis tipo Nombre;
            var fechaActual = DateTime.Now;
            //2021 - 1985 = 36
            //return fechaActual.Year - FechaNacimiento.Year;
            var edad = DateTime.Today.Subtract(FechaNacimiento.Date);
            return Convert.ToInt32(edad.Days / 365);
        }

        public string GenerarCURP()
        {
            return ObtenerInicialesAP();
            //return PrimeraVocalInterna(ApellidoPaterno);
        }

        //MENDOZA       ME
        //CRUZ          CU
        //ALTAMIRANO    AA
        //ICH           IX

        private string ObtenerInicialesAP()
        {
            string[] palabras = ApellidoPaterno.Split(' ');
            if(palabras.Length == 1)
            {
                return ConvertirEnhe(ApellidoPaterno.Substring(0, 1)) + PrimeraVocalInterna(ApellidoPaterno);
            }

            if (EsPreposicion(palabras[0]))
            {
                return ConvertirEnhe(palabras[1].Substring(0, 1)) + PrimeraVocalInterna(palabras[1]);
            }

            return ConvertirEnhe(palabras[0].Substring(0, 1)) + PrimeraVocalInterna(palabras[0]);
        }

        private bool EsPreposicion(string cadena)
        {
            string[] palabras = { "DA", "DAS", "DE", "DEL", "DI", "DIE", "DD", "EL", "LA", "LOS","MC"};
            for(int i = 0; i < palabras.Length; i++)
            {
                if(palabras[i] == cadena.ToUpper())
                {
                    return true;
                }
            }
            return false;
        }

        //MC GREGOR
        //DEL PILAR
        //DEL VALLE

        //JOSE MARIA
        //JOSEMARIA
        //MARIA LUISA

        private string ConvertirEnhe(string letra)
        {
            if (letra.ToUpper() == "Ñ") return "X";
            return letra;
        }

        private string PrimeraVocalInterna(string cadena)
        {
            //Aquí estamos recorriendo la cadena de caracteres
            for(int i = 1; i < cadena.Length; i++)
            {
                //Aquí estamos preguntando si la letra es vocal;
                if(EsVocal(cadena.Substring(i, 1)) == true)
                {
                    //Si es vocal entondes devolvemos esa letra
                    return cadena.Substring(i, 1);
                }
            }
            return "X";
        }

        private bool EsVocal(string letra)
        {
            letra = letra.ToUpper();
            if(letra.Contains("A") || letra.Contains("E") || letra.Contains("I") || letra.Contains("O") || letra.Contains("U"))
            {
                return true;
            }
            return false;
        }


    }
}

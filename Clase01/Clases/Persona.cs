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
            return GenerarPrimerasLetras() + FechaNacimiento.Year.ToString().Substring(2, 2) + PonerCero(FechaNacimiento.Month) 
                + PonerCero(FechaNacimiento.Day) + Genero.Substring(0,1) + InicialEstado(LugarNacimiento) 
                + PrimeraConsonanteInterna(ApellidoPaterno) +  PrimeraConsonanteInterna(ApellidoMaterno) + PrimeraConsonanteInterna(Nombre);
            
        }

        private string GenerarPrimerasLetras()
        {
            string[] palabrasAntisonantes = { "BACA", "BAKA", "PEDO" };
            var letras = ObtenerInicialesAP() + ApellidoMaterno.Substring(0, 1) + Nombre.Substring(0, 1);

            for(int i = 0; i < palabrasAntisonantes.Length; i++)
            {
                if(letras.ToUpper() == palabrasAntisonantes[i])
                {
                    //BACA --> BXCA
                    //NACO --> NXCO
                    return letras.Substring(0, 1) + "X" + letras.Substring(2, 2);
                }
            }
            return letras;
        }

        //return PrimeraVocalInterna(ApellidoPaterno);
        //2021
        // 6/9/1985   --> 06/09/1985 --> 850906

        //MENDOZA N
        //QUIROZ  R
        //HECTOR  C

        //MEQH850906HOCNRC03

        private string InicialEstado(string estado)
        {
            switch (estado.ToUpper())
            {
                case "AGUASCALIENTES":
                    return "AS";
                case "BAJA CALIFORNIA":
                    return "BC";
                case "DISTRITO FEDERAL":
                    return "DF";
                case "CDMX":
                    return "DF";
                case "OAXACA":
                    return "OC";
                default:
                    return "NE";
            }
        }

        private string PonerCero(int numero)
        {
            if (numero < 10) return "0" + numero.ToString();
            return numero.ToString();
        }

        //MENDOZA       ME
        //CRUZ          CU
        //ALTAMIRANO    AA
        //ICH           IX

        private string ObtenerInicialesAP()
        {
            //Arreglo con las palabras que conforman una cadena
            //Averiguamos si el apellido es compuesto
            string[] palabras = ApellidoPaterno.Split(' ');
            //Si no es compuesto
            if(palabras.Length == 1)
            {
                //devolvemos las iniciales del apellido
                return ConvertirEnhe(ApellidoPaterno.Substring(0, 1)) + PrimeraVocalInterna(ApellidoPaterno);
            }

            if (EsPreposicion(palabras[0]))
            {
                //Si es preposición devolvemos las iniciales del segundo apellido
                return ConvertirEnhe(palabras[1].Substring(0, 1)) + PrimeraVocalInterna(palabras[1]);
            }
            //De lo contrario devolvemos las iniciales del primer apellido
            return ConvertirEnhe(palabras[0].Substring(0, 1)) + PrimeraVocalInterna(palabras[0]);
        }

        private bool EsPreposicion(string cadena)
        {
            //Generamos un arreglo con todas preposiciones
            string[] palabras = { "DA", "DAS", "DE", "DEL", "DI", "DIE", "DD", "EL", "LA", "LOS","MC"};
            //Con el for recorremos las preposiciones
            for(int i = 0; i < palabras.Length; i++)
            {
                //Comparamos las preposiciones con la cadena que nos mandan
                if(palabras[i] == cadena.ToUpper()) //Si es igual
                {
                    //devolvemos verdadero
                    return true;
                }
            }
            //de lo contrario devolvemos falso
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

        private string PrimeraConsonanteInterna(string cadena)
        {
            for(int i = 1; i < cadena.Length; i++)
            {
                //Cuando la evaluación devuelve un bool no es necesario indicar el ==
                //if (EsVocal(cadena.Substring(i, 1)) == false)
                if (!EsVocal(cadena.Substring(i, 1)))
                {
                    //Si es vocal entondes devolvemos esa letra
                    return cadena.Substring(i, 1);
                }
            }
            return "X";
        }

        private string PrimeraVocalInterna(string cadena)
        {
            //Aquí estamos recorriendo la cadena de caracteres
            for(int i = 1; i < cadena.Length; i++)
            {
                //Aquí estamos preguntando si la letra es vocal;
                //if(EsVocal(cadena.Substring(i, 1)) == true)
                if(EsVocal(cadena.Substring(i, 1)))
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

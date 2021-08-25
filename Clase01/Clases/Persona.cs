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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Examen.Modelo
{
    public class Directorio
    {
        public string directorio { get; set; }
        public List<string> listaFicheros { get; set; }

        public Directorio()
        {
            this.directorio = "";
            this.listaFicheros = new List<string>();
        }
    }
}

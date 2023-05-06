using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_08_Karenia
{
    class Pelicula
    {
        string nom;
        int annio;

        public Pelicula(string nom, int annio)
        {
            this.Nom = nom;
            this.Annio = annio;
        }

        public string Nom { get => nom; set => nom = value; }
        public int Annio { get => annio; set => annio = value; }
    }
}

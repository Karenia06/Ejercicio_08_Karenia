using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_08_Karenia
{
    class Estudio
    {
        string nom;
        string des;

        public Estudio(string nom, string des)
        {
            this.Nom = nom;
            this.Des = des;
        }

        public string Nom { get => nom; set => nom = value; }
        public string Des { get => des; set => des = value; }
    }
}

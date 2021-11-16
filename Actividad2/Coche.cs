using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad2
{
    public class Coche
    {       
        string marca;

        public Coche(string marca) { this.marca = marca; }

        public string getMarcaCoche() { return marca; }
    }
}

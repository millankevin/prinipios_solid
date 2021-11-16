using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbiertoCerrado
{
    abstract class Coche
    {        
        public abstract int precioMedioCoche();        
    }
    class Renault : Coche
    {
        private int precio = 18000;

        public override int precioMedioCoche()
        {
            return precio;
        }
    }

    class Audi : Coche
    {
        private int precio = 25000;
        public override int precioMedioCoche()
        {
            return precio;
        }
    }

    class Mercedes : Coche
    {
        private int precio = 27000;
        public override int precioMedioCoche()
        {
            return precio;
        }
    }
}

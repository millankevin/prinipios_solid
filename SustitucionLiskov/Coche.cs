using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SustitucionLiskov
{
    abstract class Coche
    {
        public abstract int numAsientos();
    }
    class Renault : Coche
    {
        private int num = 5;

        public override int numAsientos()
        {
            return num;
        }
    }

    class Audi : Coche
    {
        private int num = 2;
        public override int numAsientos()
        {
            return num;
        }
    }

    class Mercedes : Coche
    {
        private int num = 4;
        public override int numAsientos()
        {
            return num;
        }
    }
    class Ford : Coche
    {
        private int num = 6;
        public override int numAsientos()
        {
            return num;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegregacionInterfaz
{
    public interface IAve
    {
        void Comer();
    }
    public interface IAveVoladora
    {
        void Volar();
    }
    public interface IAveNadadora
    {
        void Nadar();
    }
    class Loro : IAve, IAveVoladora
    {
        public void Comer()
        {
        }

        public void Volar()
        {
        }
    }
    class Tucan : IAve, IAveVoladora
    {
        public void Comer()
        {
        }

        public void Volar()
        {
        }
    }
    class Pinguino : IAve, IAveNadadora
    {
        public void Comer()
        {
        }

        public void Nadar()
        {
        }
    }
}

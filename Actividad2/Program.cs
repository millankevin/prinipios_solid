using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad2
{
    class Program
    {
        static void Main(string[] args)
        {
            Coche[] arrayCoches = {
                new Coche("Renault"),
                new Coche("Audi")
            };
            imprimirPrecioMedioCoche(arrayCoches);
            Console.ReadKey();
        }
        public static void imprimirPrecioMedioCoche(Coche[] arrayCoches)
        {
            foreach (Coche coche in arrayCoches)
            {                
                if (coche.getMarcaCoche().Equals("Renault")) Console.WriteLine("El precio del auto Renault: "+18000);
                if (coche.getMarcaCoche().Equals("Audi")) Console.WriteLine("El precio del auto Audi: "+25000);
            }
        }
    }
}

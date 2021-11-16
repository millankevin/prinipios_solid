using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SustitucionLiskov
{
    class Program
    {
        static void Main(string[] args)
        {
            Coche[] arrayCoches = {
                new Renault(),
                new Audi(),
                new Mercedes(),
                new Ford()
            };

            imprimirNumAsientos(arrayCoches);
        }
        public static void imprimirNumAsientos(Coche[] arrayCoches)
        {
            //foreach (Coche coche in arrayCoches)
            //{
            //    if (coche is Renault)Console.WriteLine(coche.numAsientos());
            //    if (coche is Audi)Console.WriteLine(coche.numAsientos());
            //    if (coche is Mercedes) Console.WriteLine(coche.numAsientos());
            //    if (coche is Ford) Console.WriteLine(coche.numAsientos());
            //}
            foreach (Coche coche in arrayCoches)
            {
                Console.WriteLine(coche.numAsientos());
            }
        }
    }
}

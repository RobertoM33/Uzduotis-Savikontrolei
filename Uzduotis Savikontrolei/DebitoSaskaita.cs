using Kontrole1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotis_Savikontrolei
{
    public class DebitoSaskaita : Saskaita, IMokejimoMetodas
    {
        public DebitoSaskaita(string savininkoVardas, double pradinisBalansas)
            : base(savininkoVardas, pradinisBalansas) { }
        public void Apmoketi(double suma)
        {
            if (PatikrinkLikuti(suma))
            {
               Balansas -= suma;
                Console.WriteLine($"Mokejimas ivykdytas.Pakites balansas: {Balansas} ");
            }
            else
            {
                Console.WriteLine("Nepakanka lesu.");
            }
        }
        public bool PatikrinkLikuti(double suma)
        {
            return Balansas >= suma;
        }
    }
}

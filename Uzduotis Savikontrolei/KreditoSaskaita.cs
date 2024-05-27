using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Kontrole1
{
    public class KreditoSaskaita : Saskaita, IMokejimoMetodas
    {public KreditoSaskaita(string savininkoVardas, double pradinisBalansas)
            : base(savininkoVardas, pradinisBalansas) { }

        public void Apmoketi(double suma)
        {
            if (PatikrinkLikuti(suma))
            {
                Balansas -= suma;
                Console.WriteLine($"apmokejimas ivykdytas: {Balansas}");
            }

            else
            {
                Console.WriteLine("Saskaitoje nepakanka lesu");
            }
        }
                public bool PatikrinkLikuti(double suma)
                {
                    return Balansas >= suma;
                }
            }
        }
    


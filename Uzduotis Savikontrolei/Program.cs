using System;
using Uzduotis_Savikontrolei;

namespace Kontrole1
{
    public class Pagrindine
    {
        static void Main(string[] args)
        {
            List<IMokejimoMetodas> saskaituSarasas = new List<IMokejimoMetodas>
            {
                new KreditoSaskaita("Robertas", 2000),
                new DebitoSaskaita ("Zivile", 3000)

             };
            double[] sumos = { 200, 1500, 300 };

            foreach (var saskaita in saskaituSarasas)
            {
                foreach (var suma in sumos)
                {
                    Console.WriteLine($"Bandoma apmoketi {suma} su {saskaita.GetType().Name} saskaita.");
                    saskaita.Apmoketi(suma);
                }
                Console.WriteLine();
                }
            }

               
        }
    }

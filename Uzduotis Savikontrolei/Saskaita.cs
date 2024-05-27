using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontrole1
{
    public class Saskaita
    {
        public string SavininkoVardas {  get; set; }
        public double Balansas;
        public Saskaita(string savininkoVardas, double pradinisBalansas)
        {
            SavininkoVardas = savininkoVardas;
            Balansas = pradinisBalansas;
        }

        public double GautiBalansa()
        { return Balansas; }
    }
}



        

    


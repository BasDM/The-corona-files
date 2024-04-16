using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TheCoronaFiles
{
    internal class DomVirrus:Virrus
    {
        static Random rng = new Random();
        public override bool TryVaccin(Vaccin vaccinPoging)
        {
            bool result = base.TryVaccin(vaccinPoging);
            if (rng.Next(0,2)==0)
            {
                DoomCountDown += 2;
            }
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Missie_3_Compositie.Classes
{
    internal class Enclave
    {
        protected static Random rng = new Random();
        private Hospitaal hospitaal;
        private Generator generator;
        protected List<Woonst> woningen = new List<Woonst>();

        public Enclave()
        {
            hospitaal = new Hospitaal("Starthospitaal", rng.Next(1, Console.WindowWidth), rng.Next(1, Console.WindowHeight));
            generator = new Generator("Startgenerator", rng.Next(1, Console.WindowWidth), rng.Next(1, Console.WindowHeight));
            for (int i = 0; i < 3; i++)
            {
                woningen.Add(new Woonst($"Woonst {i}",rng.Next(1, Console.WindowWidth), rng.Next(1, Console.WindowHeight)));
            }
        }
        public virtual void BouwWoonst()
        {
            int xPoging = 0;
            int yPoging = 0;
            do
            {
                xPoging = rng.Next(1, Console.WindowWidth);
                yPoging = rng.Next(1, Console.WindowHeight);
            } while (IsLeeg(xPoging,yPoging));
        }

        public virtual void ToonEclave()
        {
            generator?.PrintGebouw();
            hospitaal?.PrintGebouw();
            foreach (var woonst in woningen)
            {
                woonst.PrintGebouw();
            }
        }

        public bool IsLeeg(int xIn, int yIn)
        {
            if (hospitaal.XLocatie == xIn && hospitaal.YLocatie == yIn)
                return false;
            if (generator.XLocatie == xIn && generator.YLocatie == yIn)
                return false;
            foreach (var huisje in woningen)
            {
                if (huisje.XLocatie == xIn && huisje.YLocatie == yIn)
                    return false;
            }

            return true;
        }
    }
}

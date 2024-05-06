using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Missie_3_Compositie.Classes
{
    internal class StadsEnclave:Enclave
    {
        private Waterkrachtcentrale waterkrachtcentrale;
        private Hospitaal extraHospitaal;
        private List<Flat> flats = new List<Flat>();

        public override void BouwWoonst()
        {
            base.BouwWoonst();
            if (woningen.Count%3==0)
            {
                for (int i = 0; i < 3; i++)
                {
                    woningen.RemoveAt(0);
                }
                woningen.Add(new Flat("Flat", rng.Next(1, Console.WindowWidth), rng.Next(Console.WindowHeight)));
            }
        }

        public override void ToonEclave()
        {
            base.ToonEclave();

            extraHospitaal?.PrintGebouw();
            waterkrachtcentrale?.PrintGebouw();
            foreach (var flat in flats)
            {
                flat.PrintGebouw();
            }
        }
    }
}

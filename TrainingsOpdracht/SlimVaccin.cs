using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingsOpdracht
{
    internal class SlimVaccin:Vaccin
    {
        public SlimVaccin(string naamIn) : base(naamIn)
        {

        }
        int next = 0;
        public override int TryKillCode()
        {
            int tosend = next;
            next = next + 10;
            if (next>100)
            {
                int r = next % 10;
                next = r + 1;
            }
            return tosend;
        }
    }
}

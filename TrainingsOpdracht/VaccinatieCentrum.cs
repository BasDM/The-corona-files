using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingsOpdracht
{
    internal class VaccinatieCentrum
    {
        public static int Oplossing { get; set; } = -1;
        public static void BewaarVaccin(int value)
        {
            Oplossing = value;
        }
        public Vaccin GeefVaccin()
        {
            if (Oplossing == -1)
                return null;
            return new Vaccin("THECURE", Oplossing);
        }
    }
}

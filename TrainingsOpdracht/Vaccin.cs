using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingsOpdracht
{
    internal class Vaccin
    {
        static Random rng = new Random();
        public string Naam { get; private set; }
        public int Oplossing { get; set; } = -1;
        public Vaccin(string naamIn)
        {
            Naam = naamIn;
        }
        public Vaccin(string naamIn, int value)
        {
            Naam = naamIn;
            Oplossing = value;
        }

        public int TryKillCode()
        {
            if (Oplossing != -1)
            {
                return Oplossing;
            }
            return rng.Next(1, 100);
        }
        public void ToonInfo()
        {
            Console.WriteLine($"Naam:{Naam}\nOplossing:{Oplossing}\n");
        }
    }
}

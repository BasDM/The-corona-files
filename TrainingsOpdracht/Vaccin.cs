using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingsOpdracht
{
    internal class Vaccin
    {
        Random rng = new Random();
        public string Naam { get; private set; }
        public int Oplossing { get; set; } = -1;
        public Vaccin(string naamIn)
        {
            Naam = naamIn;
        }
        
        public int TryKillCode()
        {
            if (Oplossing!=-1)
            {
                return Oplossing;
            }
            return rng.Next(0, 100);
        }
        public void ToonInfo()
        {
            Console.WriteLine($"Naam:{Naam}\nOplossing:{Oplossing}\n");
        }
    }
}

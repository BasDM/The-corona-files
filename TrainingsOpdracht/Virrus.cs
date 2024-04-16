using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TrainingsOpdracht
{
    internal class Virrus
    {
        static Random rng = new Random();
        public string Naam { get; private set; }
        private int doomCountdown;
        public int DoomCountDown
        {
            get { return doomCountdown; }
            private set
            {
                if (value <= 0)
                {
                    Console.WriteLine($"Game over");
                }
                doomCountdown = value;
            }
        }
        private int killCode;
        public Virrus()
        {
            DoomCountDown = rng.Next(100, 200);
            killCode = rng.Next(0, 99);
            Naam = MaakNaam();
        }
        public string MaakNaam()
        {
            string randomNaam = "";
            for (int i = 0; i < 3; i++)
            {
                randomNaam += (char)rng.Next('a', 'z' + 1);
            }
            randomNaam += rng.Next(1, 100);
            return randomNaam;
        }
        public bool TryVaccin(Vaccin vaccinPoging)
        {
            bool resultaat = false;
            int poging = vaccinPoging.TryKillCode();

            if (poging == killCode)
            {
                resultaat = true;
                vaccinPoging.Oplossing = poging;
            }
            DoomCountDown--;
            return resultaat;
        }

        public void ToonInfo()
        {
            Console.WriteLine($"Naam:{Naam}");
        }
    }
}

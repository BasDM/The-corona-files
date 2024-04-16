namespace TrainingsOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Virrus v = new Virrus();

            List<Vaccin> vaccins = new List<Vaccin>();
            for (int i = 0; i < 5; i++)
            {
                vaccins.Add(new Vaccin(i.ToString()));
            }

            Vaccin Werkend = null;
            bool vaccinGevonden = false;
            while (v.DoomCountDown > 0 && vaccinGevonden == false)
            {
                foreach (Vaccin vaccin in vaccins)
                {
                    if (v.TryVaccin(vaccin) == true)
                    {
                        Werkend = vaccin;
                        vaccinGevonden = true;
                        break;
                    }
                }
            }
            //fase 2
            if (vaccinGevonden)
            {
                Werkend.ToonInfo();
                VaccinatieCentrum.BewaarVaccin(Werkend.Oplossing);

                List<VaccinatieCentrum> centra = new List<VaccinatieCentrum>();
                for (int i = 0; i < 5; i++)
                {
                    centra.Add(new VaccinatieCentrum());
                }

                List<Vaccin> containerVaccins = new List<Vaccin>();
                foreach (var centrum in centra)
                {
                    for (int i = 0; i < 7; i++)
                    {
                        containerVaccins.Add(centrum.GeefVaccin());
                    }
                }

                for (int i = 0; i < containerVaccins.Count; i++)
                {
                    Console.Write(i);
                    containerVaccins[i].ToonInfo();
                }
            }
            else
            {
                Console.WriteLine("Gedaan");
            }
        }
    }
}

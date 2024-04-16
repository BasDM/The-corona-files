namespace TrainingsOpdracht
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Virrus deDood = new Virrus();
            List<Vaccin> vaccins = new List<Vaccin>()
            {
                new Vaccin("vaccin1"),
                new Vaccin("vaccin2"),
                new Vaccin("vaccin3"),
                new Vaccin("vaccin4"),
                new Vaccin("vaccin5")
            };
            Vaccin werkend = null;
            do
            {
                foreach (var item in vaccins)
                {
                   if (deDood.TryVaccin(item)) werkend = item;
                }
            } while (werkend == null && deDood.DoomCountDown != 0);
        }
    }
}

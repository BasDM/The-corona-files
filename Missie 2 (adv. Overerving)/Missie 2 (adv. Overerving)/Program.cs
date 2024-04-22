namespace Missie_2__adv._Overerving_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Gebouw> enclave = new List<Gebouw>();
            enclave.Add(new Hospitaal("Sint Vincentius", 4, 5));
            enclave.Add(new Woonst("Tims shack", 1, 1));
            enclave.Add(new Generator("batteryshed 1", 1, 2));

            foreach (var gebouw in enclave)
            {
                gebouw.PrintGebouw();
            }
            Console.SetCursorPosition(1, 5);
        }
    }
}

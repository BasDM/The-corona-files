using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Missie_2__adv._Overerving_
{
    internal class Generator:Gebouw
    {
        public Generator(string naamIn, int xIn, int yIn) : base(naamIn, xIn, yIn) { }
        public override void PrintGebouw()
        {
            Console.SetCursorPosition(XLocatie, YLocatie);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"g");
            Console.ResetColor();
        }
        public override string ToString()
        {
            return base.ToString() + $"Een coole generator";
        }
    }
}

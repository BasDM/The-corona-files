using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace Missie_3_Compositie.Classes
{
    internal class Flat : Woonst
    {
        public Flat(string naamIn, int xIn, int yIn) : base(naamIn, xIn, yIn) { }
        public override void PrintGebouw()
        {
            Console.SetCursorPosition(XLocatie, YLocatie);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"W");
            Console.ResetColor();
        }
        public override string ToString()
        {
            return base.ToString() + $"Soww, deze flat is hoog!";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Missie_3_Compositie.Classes
{
    internal class Hospitaal : Gebouw
    {
        public Hospitaal(string naamIn, int xIn, int yIn) : base(naamIn, xIn, yIn) { }
        public override void PrintGebouw()
        {
            Console.SetCursorPosition(XLocatie, YLocatie);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"H");
            Console.ResetColor();
        }
        public override string ToString()
        {
            return base.ToString() + $"Wat een proper hospitaal is dit";
        }
    }
}

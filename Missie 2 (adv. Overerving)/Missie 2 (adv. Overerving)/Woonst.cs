using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Missie_2__adv._Overerving_
{
    internal class Woonst:Gebouw
    {
        public Woonst(string naamIn,int xIn,int yIn) : base(naamIn, xIn, yIn) {}
        public override void PrintGebouw()
        {
            Console.SetCursorPosition(XLocatie, YLocatie);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"w");
            Console.ResetColor();
        }
        public override string ToString()
        {
            return base.ToString()+ $"Wat een prachtige woning is dit";
        }
    }
}

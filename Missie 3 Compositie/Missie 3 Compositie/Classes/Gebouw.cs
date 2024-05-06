using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Missie_3_Compositie.Classes
{
    internal abstract class Gebouw
    {
        public Gebouw(string naamIn, int xIn, int yIn)
        {
            Naam = naamIn;
            XLocatie = xIn;
            YLocatie = yIn;
        }

        public int XLocatie { get; set; }
        public int YLocatie { get; set; }
        public string Naam { get; set; }

        public abstract void PrintGebouw();

        public override string ToString()
        {
            return $"{Naam} (Locatie: {XLocatie},{YLocatie}";
        }
    }
}

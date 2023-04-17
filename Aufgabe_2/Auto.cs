using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_2
{
    // Jede Klasse erbt von Object Basisklasse (beinhaltet grundlegende Funktionen)
    abstract internal class Auto
    {
        protected int numDoors;
        public string? Colour { get; set; }
        public string? Type { get; set; }

        // Hier würde sich evtl. prozected Konstruktor anbieten
        // -> über Konstruktorerbung aufrufbar

        public int GetNumberOfDoors()
        {
            return numDoors;
        }
    }
}

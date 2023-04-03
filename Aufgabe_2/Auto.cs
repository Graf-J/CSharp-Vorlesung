using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_2
{
    abstract internal class Auto
    {
        protected int numDoors;
        public string? Colour { get; set; }
        public string? Type { get; set; }

        public int GetNumberOfDoors()
        {
            return numDoors;
        }
    }
}

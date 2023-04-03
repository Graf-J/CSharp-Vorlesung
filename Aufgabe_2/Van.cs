using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_2
{
    internal class Van : Kombi
    {
        private bool hasLoadArea;
        public bool HasLoadArea
        {
            set 
            {
                numDoors = value ? 2 : 5;
                hasLoadArea = value;
            }
        }
    }
}

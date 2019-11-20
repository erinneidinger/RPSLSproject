using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperSissorsLizardSpock
{
    public class Computer : Player
    { 

        public Computer()
        {

        }
        public void RandomizeResults(List<string> gestures)
        {
            Random rnd = new Random();
            string gestures = rnd.Next(0, 4);
        }

    }
}

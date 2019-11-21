using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperSissorsLizardSpock
{
    abstract class Player
    {
        public string name;
        public string gesture;
        public int score;
        public List<string> gestures = new List<string>() { "Rock", "Paper", "Scissors", "Lizard", "Spock" };

        public Player()
        {
            score = 0;
        }

        public abstract void ChooseName();

        public abstract void ChooseGesture();
    }
}

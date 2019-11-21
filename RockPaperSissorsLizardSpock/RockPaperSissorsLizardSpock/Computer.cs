using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperSissorsLizardSpock
{
    class Computer : Player
    {
        public Computer()
        { 
        }
        public override void ChooseName()
        {
            Random rnd = new Random();
            List<string> names = new List<string>() { "Sheldon", "Raj", "Howard", "Leonard"};
            name = names[rnd.Next(names.Count)];
            Console.WriteLine(name + " is your opponent for this game.");
        }
        public override void ChooseGesture()
        {
            Random rnd = new Random();
            gesture = gestures[rnd.Next(gestures.Count)];
            Console.WriteLine(name + " chose " + gesture + ".");
        }
    }
}

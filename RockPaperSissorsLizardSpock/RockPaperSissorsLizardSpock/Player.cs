using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperSissorsLizardSpock
{
    public abstract class Player
    {
        public string name;
        public string gesture;

        public Player(string name, string gesture)
        {
            this.name = name;
            this.gesture = gesture;
        }
   

        public void listGestures()
        {
            List<string> gestures = new List<string>() { "Rock", "Paper", "Sissors", "Lizard", "Spock" };
            foreach (string gesture in gestures)
            {
                Console.WriteLine(gesture);
            }
        }
        public void pickGesture()
        {

        }
        public void compareGestures()
        {

        }
        public void pickWinnter()
        {

        }
      
        //new abstract
        //override method for computer randomize
        public void returnForNextGame()
        {

        }
    }
}

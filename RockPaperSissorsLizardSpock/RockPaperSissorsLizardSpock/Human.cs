using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperSissorsLizardSpock
{
    class Human : Player
    {
        public Human() 
        {
        }
        public override void ChooseName()
        {
            Console.WriteLine("Choose a name");
            name = Console.ReadLine();
            Console.WriteLine("Your name is " + name + ".");
        }
        public override void ChooseGesture()
        {
            Console.WriteLine("These are your gesture choices: \nType the number next to the gesture to pick your choice. \n1) Rock \n2) Paper \n3) Sissors \n4) Lizard \n5) Spock \nChoose a gesture.");
            gesture = Console.ReadLine();
            switch(gesture)
            {
                case "1":
                    Console.WriteLine("You picked Rock.");

                    break;
                case "2":
                    Console.WriteLine("You picked Paper.");

                    break;
                case "3":
                    Console.WriteLine("You picked Sissors.");

                    break;
                case "4":
                    Console.WriteLine("You picked Lizard.");

                    break;
                case "5":
                    Console.WriteLine("You picked Spock.");
                    break;
                case "quit":
                    Console.WriteLine("You are now exiting the game. Hope to see you next time.");
                    break;
                default:
                    Console.WriteLine("Please choose a option or type quit to exit game.");
                    ChooseGesture();
                    break;
            }
            Console.WriteLine("You picked " + gesture);
        }
    }
}

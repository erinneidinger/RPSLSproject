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
            Console.WriteLine("Choose a name:");
            name = Console.ReadLine();
            Console.WriteLine("Press Enter.");
            Console.Clear();
            Console.WriteLine("Your name is " + name + ".");
            Console.ReadLine();
            Console.Clear();
        }
        public override void ChooseGesture()
        {
            Console.WriteLine("These are your gesture choices: \nType the number next to the gesture to pick your choice and then press Enter. \n1) Rock \n2) Paper \n3) Scissors \n4) Lizard \n5) Spock \nChoose a gesture.");
            string input = Console.ReadLine();
            switch(input)
            {
                case "1":
                    gesture = "Rock";
                    Console.WriteLine("You picked Rock.");
                    break;
                case "2":
                    gesture = "Paper";
                    Console.WriteLine("You picked Paper.");
                    break;
                case "3":
                    gesture = "Scissors";
                    Console.WriteLine("You picked Scissors.");
                    break;
                case "4":
                    gesture = "Lizard";
                    Console.WriteLine("You picked Lizard.");
                    break;
                case "5":
                    gesture = "Spock";
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
        }
    }
}

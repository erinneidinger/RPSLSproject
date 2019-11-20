using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperSissorsLizardSpock
{
    public class Game
    {
        public Player player;

        public Game()
        {
            
        }

        public void MasterFunction()
        {
            Menu();
            PickOpponent();
            //pickGesture
            //draw


        }
        public void Menu()
        {
            Console.WriteLine("Please write your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Welcome " + name);
            
        }

        public void PickOpponent()
        {
            Console.WriteLine("Please pick your opponent: press 1 for human, press 2 for computer:");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine("Your opponent is a human");
                    //human class
                    break;
                case "2":
                    Console.WriteLine("Your opponent is the computer");
                    //computer class
                    break;
                case "quit":
                    Console.WriteLine("Sorry to see you go!");
                    Menu();
                    break;
                default:
                    Console.WriteLine("Please pick an opponent to play.");
                    PickOpponent();
                    break;
            }
        }
    }
}

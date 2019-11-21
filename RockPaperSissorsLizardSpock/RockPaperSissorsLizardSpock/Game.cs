﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperSissorsLizardSpock
{
    public class Game
    {
        Player player1;
        Player player2;

        public Game()
        { 
        }

        public string GetNumberPlayers()
        {
            Console.WriteLine("How many players? Type 1 or 2.");
            string numberPlayers = Console.ReadLine();
            return numberPlayers;
        }
        public void CreatePlayers(string numberPlayers)
        {
            if(numberPlayers == "1")
            {
                player1 = new Human();
                player2 = new Computer();
            }
            else if(numberPlayers == "2")
            {
                player1 = new Human();
                player2 = new Human();
            }
        }
        public void RunGame()
        {
            ListingInstructions();
            string input = GetNumberPlayers();
            CreatePlayers(input);
            player1.ChooseName();
            player2.ChooseName();
            player1.ChooseGesture();
            player2.ChooseGesture();
            Console.ReadLine();
            Console.Clear();
            CompareGestures();
            Console.ReadLine();
            IncrementWinnerScore();
            Console.ReadLine();
            DetermineGameWinner();
            Console.ReadLine();
        }
        public void ListingInstructions()
        {
            Console.WriteLine("Hello! Welcome to the game ROCK PAPER SISSORS LIZARD SPOCK. \nThis game is played like the traditional Rock, Paper, Sissors- but with a modern twist.");
            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Here are the rules of the game: \nFirst you pick who you would like to play- the computer or another person. \nNext, you will pick your action, and the second player will do the same. Then we battle and see who won. \nBelow we will list the options:");
            Console.WriteLine("Rock crushes Scissors \nScissors cut Paper \nPaper covers Rock \nRock crushes Lizard \nLizard poisons Spock \nSpock smashes Scissors \nScissors decapitates Lizard \nLizard eats Paper \nPaper disproves Spock \nSpock vaporizes Rock");
            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();
            Console.Clear();
        }
        public void CompareGestures()
        {
            Console.WriteLine(player1.name + " picked " + player1.gesture + ", while " + player2.name + " picked " + player2.gesture + ".") ;
            Console.WriteLine("Time to battle it out and see who wins!");
            Console.ReadLine();
            if(player1.gesture == player2.gesture)
            {
                Console.WriteLine("It's a tie, let's replay that round");
            }
            else if(player1.gesture == "Rock" && (player2.gesture == "Lizard" || player2.gesture == "Sissors"))
            {
                Console.WriteLine(player1.gesture + " crushes " + player2.gesture + ", duh!");
                Console.WriteLine(player1.name + " wins!");
          
            }
            else if(player1.gesture == "Sissors" && (player2.gesture == "Lizard" || player2.gesture == "Paper"))
            {
                Console.WriteLine(player1.gesture + " is superior over " + player2.gesture + ", of course.");
                Console.WriteLine(player1.name + " wins!"); 
            }
            else if (player1.gesture == "Paper" && (player2.gesture == "Rock" || player2.gesture == "Spock"))
            {
                Console.WriteLine(player1.gesture + " will rule over " + player2.gesture + " in the end.");
                Console.WriteLine(player1.name + " wins!");
            }
            else if (player1.gesture == "Lizard" && (player2.gesture == "Spock" || player2.gesture == "Paper"))
            {
                Console.WriteLine(player1.gesture + " beats " + player2.gesture + " everytime.");
                Console.WriteLine(player1.name + " wins!");
            }
            else if (player1.gesture == "Spock" && (player2.gesture == "Rock" || player2.gesture == "Sissors"))
            {
                Console.WriteLine(player1.gesture + " always destroys " + player2.gesture + ".");
                Console.WriteLine(player1.name + " wins!");
            }
            else
            {
                Console.WriteLine(player2.gesture + " will always get the best of " + player1.gesture + ", obviously!");
                Console.WriteLine(player2.name + " wins!");
            }
        }
        public void IncrementWinnerScore()
        {

        }
        public void DetermineGameWinner()
        {

        }
        public void ReturnForNextGame()
        {
     
        }
    }
}

using System;
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
            Console.WriteLine("How many players? Type 1 to face to computer, type 2 to battle another person.");
            string numberPlayers = Console.ReadLine();
            if (numberPlayers == "1" || numberPlayers == "2")
            {
                CreatePlayers(numberPlayers);
            }
            else
            {
                switch (numberPlayers)
                {
                    case "quit":
                        Console.WriteLine("Quiting game now");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opps, try again.");
                        Console.WriteLine("Please enter either 1 or 2, or exit the game by typing quit.");
                        Console.WriteLine();
                        GetNumberPlayers();
                        break;
                }
            }
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

            RunGameAgain();
        }
        public void RunGameAgain()
        {
            player1.ChooseGesture();
            Console.ReadLine();
            Console.Clear();
            player2.ChooseGesture();
            Console.ReadLine();
            Console.Clear();
            CompareGestures();
            Console.ReadLine();
            IncrementWinnerScore();
            Console.ReadLine();
            LoopingGame();
            DetermineGameWinner();
            ReturnForNextGame();
        }

        public void ListingInstructions()
        {
            Console.WriteLine("Hello!");
            Console.WriteLine();
            Console.WriteLine("Welcome to the game ROCK PAPER SCISSORS LIZARD SPOCK. \nThis game is played like the traditional Rock, Paper, Scissors- but with a modern twist.");
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Here are the rules of the game:");
            Console.WriteLine();
            Console.WriteLine("First you pick who you would like to play- the computer or another person. \nNext, you will pick your action, and the second player will do the same. \nThen we battle and see who won.");
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Options are listed below of what can occur:");
            Console.WriteLine();
            Console.WriteLine("Rock crushes Scissors \nScissors cut Paper \nPaper covers Rock \nRock crushes Lizard \nLizard poisons Spock \nSpock smashes Scissors \nScissors decapitates Lizard \nLizard eats Paper \nPaper disproves Spock \nSpock vaporizes Rock");
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue.");
            Console.ReadLine();
            Console.Clear();
        }
        public void CompareGestures()
        {
            Console.WriteLine(player1.name + " picked " + player1.gesture + ", while " + player2.name + " picked " + player2.gesture + ".") ;
            Console.WriteLine();
            Console.WriteLine("Time to battle it out and see who wins! Press enter to see who won.");
            Console.ReadLine();
            if(player1.gesture == player2.gesture)
            {
                Console.WriteLine("It's a tie, let's replay that round");

            }
            else if(player1.gesture == "Rock" && (player2.gesture == "Lizard" || player2.gesture == "Scissors"))
            {
                Console.WriteLine(player1.gesture + " crushes " + player2.gesture + ", duh!");
                Console.WriteLine();
                Console.WriteLine(player1.name + " wins the round.");
                player1.score++;
            }
            else if(player1.gesture == "Scissors" && (player2.gesture == "Lizard" || player2.gesture == "Paper"))
            {
                Console.WriteLine(player1.gesture + " is superior over " + player2.gesture + ", of course.");
                Console.WriteLine();
                Console.WriteLine(player1.name + " wins the round.");
                player1.score++;
            }
            else if (player1.gesture == "Paper" && (player2.gesture == "Rock" || player2.gesture == "Spock"))
            {
                Console.WriteLine(player1.gesture + " will rule over " + player2.gesture + " in the end.");
                Console.WriteLine();
                Console.WriteLine(player1.name + " wins the round.");
                player1.score++;
            }
            else if (player1.gesture == "Lizard" && (player2.gesture == "Spock" || player2.gesture == "Paper"))
            {
                Console.WriteLine(player1.gesture + " beats " + player2.gesture + " everytime.");
                Console.WriteLine();
                Console.WriteLine(player1.name + " wins the round.");
                player1.score++;
            }
            else if (player1.gesture == "Spock" && (player2.gesture == "Rock" || player2.gesture == "Scissors"))
            {
                Console.WriteLine(player1.gesture + " always destroys " + player2.gesture + ".");
                Console.WriteLine();
                Console.WriteLine(player1.name + " wins the round.");
                player1.score++;
            }
            else
            {
                Console.WriteLine(player2.gesture + " will always get the best of " + player1.gesture + ", obviously!");
                Console.WriteLine();
                Console.WriteLine(player2.name + " wins the round.");
                player2.score++;
            }
        }
        public void IncrementWinnerScore()
        {
            Console.WriteLine("This game is best out of three, so whomever wins two rounds out of three! \nHere are the current scores: \n" + player1.name + ": " + player1.score + "\n" + player2.name + ": " + player2.score);
        }
        public void LoopingGame()
        {
            while(true)
            {
                if (player1.score == 2 || player2.score == 2) 
                {
                    break;
                }
                else
                {
                    RunGameAgain();
                }
            }
        }
        public void DetermineGameWinner()
        {
            if (player1.score == 2)
            {
                Console.WriteLine("Congratulations " + player1.name + ", you won the game!");
                Console.WriteLine();
                Console.WriteLine("Better luck next time, " + player2.name + ".");

            }
            else if (player2.score == 2)
            {
                Console.WriteLine("Congratulations " + player2.name + ", you won the game!");
                Console.WriteLine();
                Console.WriteLine("Better luck next time, " + player1.name + ".");
            }
        }
        public void ReturnForNextGame()
        {
            Console.WriteLine("Thanks for playing! Press 1 to exit out, press any key to play again.");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Console.WriteLine("You are now exiting the game, goodbye!");
                    Console.ReadLine();
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Let's Play");
                    RunGame();
                    break;
            }
    }    }
}

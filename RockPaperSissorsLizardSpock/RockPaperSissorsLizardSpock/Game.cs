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
            string input = GetNumberPlayers();
            CreatePlayers(input);
            player1.ChooseName();
            player2.ChooseName();
            player1.ChooseGesture();
            player2.ChooseGesture();
            CompareGestures();
            IncrementWinnerScore();
            DetermineGameWinner();
        }
        public void GestureHierachy()
        {

        }
        public void CompareGestures()
        {
            Console.WriteLine(player1.gesture);
            Console.WriteLine(player2.gesture);
            if(player1.gesture == player2.gesture)
            {
                Console.WriteLine("It's a tie, let's replay that round");
            }
            else if(player1.gesture == "Rock" && (player2.gesture == "Lizard" || player2.gesture == "Sissors"))
            {
                Console.WriteLine(player1.name + " wins!");
            }
            else if(player1.gesture == "Sissors" && (player2.gesture == "Lizard" || player2.gesture == "Paper"))
            { 
                Console.WriteLine(player1.name + " wins!"); 
            }
            else if (player1.gesture == "Paper" && (player2.gesture == "Rock" || player2.gesture == "Spock"))
            {
                Console.WriteLine(player1.name + " wins!");
            }
            else if (player1.gesture == "Lizard" && (player2.gesture == "Spock" || player2.gesture == "Paper"))
            {
                Console.WriteLine(player1.name + " wins!");
            }
            else if (player1.gesture == "Spock" && (player2.gesture == "Rock" || player2.gesture == "Sissors"))
            {
                Console.WriteLine(player1.name + " wins!");
            }
            else
            {
                Console.WriteLine(player2.name + "wins!");
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

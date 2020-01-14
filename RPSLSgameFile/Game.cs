using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSgameFile
{
    class Game
    {
        Player player1;
        Player player2;

        public string ChooseNumberOfPlayers()
        {
            Console.WriteLine("How many Players?");
            string numberOfPlayers = Console.ReadLine();
            return numberOfPlayers;
        }

        public void SetPlayers(string NumberOfPlayers)
        {
            if (NumberOfPlayers == "0")
            {
                player1  = new Computer();
                player2 = new Computer();
            }

         else if(NumberOfPlayers == "1")
            {
                player1 = new Human();
                player2 = new Computer();
            }
        else if(NumberOfPlayers == "2")
            {
                player1 = new Human();
                player2 = new Human();
            }
        }
        public void CheckingForRule()
        {
            Console.WriteLine("Do you know the rules? Hit [1] for yes or [2] for no");
            string userinput = Console.ReadLine();
            {
                if (userinput == "1")
                {
                    RunGame();
                }
                else if (userinput == "2")
                {
                    Console.WriteLine("Rules: Rock crushes Scissors, Scissors cuts Paper, Paper covers Rock, Rock crushes Lizard, Lizard poisons Spock, Spock smashes Scissors, Scissors decapitates lizard, Lizard eats Paper, Paper disproves Spock, Spock vaporizes Rock");
                    RunGame();
                }
                else

                {
                    Console.WriteLine("You did not select a valid option. Please choose again");
                    CheckingForRule();
                }
            }
        }
        public void RunGame()
        {
            string UserInput = ChooseNumberOfPlayers();
            SetPlayers(UserInput);
            player1.ChooseGesture();
            player2.ChooseGesture(); 
        }
    }
}

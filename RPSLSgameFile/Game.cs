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
                player1 = new Computer();
                player2 = new Computer();
            }

            else if (NumberOfPlayers == "1")
            {
                player1 = new Human();
                player2 = new Computer();
            }
            else if (NumberOfPlayers == "2")
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
            {
            Console.WriteLine("Play a gesture! Choose between Rock(1), Paper(2), Scissors(3), Lizard(4), Spock(5)");
                player1.gesture = Int32.Parse(Console.ReadLine());
            while (player1.Score < 2 && player2.Score < 2)
            {
                while (player1.gesture == 1)
                {
                    Console.WriteLine("Player 1 chose Rock");
                    if (player1.gesture == player2.gesture)
                    {
                        Console.WriteLine("Draw! Choose Again!");
                    }
                    if (player2.gesture == 3 && player2.gesture == 4)
                    {
                        Console.WriteLine("Player 1 earns a point!");
                        player1.Score++;
                    }
                    if (player2.gesture == 2 && player2.gesture == 5)
                    {
                        Console.WriteLine("Player 2 earns a point!");
                        player2.Score++;
                    }
                }
                while (player1.gesture == 2)
                {
                    Console.WriteLine("Player 1 chose Paper");
                    if (player1.gesture == player2.gesture)
                    {
                        Console.WriteLine("Draw! Choose Again!");
                    }
                    if (player2.gesture == 1 && player2.gesture == 5)
                    {
                        Console.WriteLine("Player 1 earns a point!");
                        player1.Score++;
                    }
                    if (player2.gesture == 3 && player2.gesture == 4)
                    {
                        Console.WriteLine("Player 2 earns a point!");
                        player2.Score++;
                    }
                }
                while (player1.gesture == 3)
                {
                    Console.WriteLine("Player 1 chose Scissors");
                    if (player1.gesture == player2.gesture)
                    {
                        Console.WriteLine("Draw! Choose Again!");
                    }
                    if (player2.gesture == 2 && player2.gesture == 4)
                    {
                        Console.WriteLine("Player 1 earns a point!");
                        player1.Score++;
                    }
                    if (player2.gesture == 1 && player2.gesture == 5)
                    {
                        Console.WriteLine("Player 2 earns a point!");
                        player2.Score++;
                    }
                }
                while (player1.gesture == 4)
                {
                    Console.WriteLine("Player 1 chose Lizard");
                    if (player1.gesture == player2.gesture)
                    {
                        Console.WriteLine("Draw! Choose Again!");
                    }
                    if (player2.gesture == 2 && player2.gesture == 5)
                    {
                        Console.WriteLine("Player 1 earns a point!");
                        player1.Score++;
                    }
                    if (player2.gesture == 1 && player2.gesture == 3)
                    {
                        Console.WriteLine("Player 2 earns a point!");
                        player2.Score++;
                    }
                }
                while (player1.gesture == 5)
                {
                    Console.WriteLine("Player 1 chose Spock");
                    if (player1.gesture == player2.gesture)
                    {
                        Console.WriteLine("Draw! Choose Again!");
                    }
                    if (player2.gesture == 1 && player2.gesture == 3)
                    {
                        Console.WriteLine("Player 1 earns a point!");
                        player1.Score++;
                    }
                    if (player2.gesture == 2 && player2.gesture == 4)
                    {
                        Console.WriteLine("Player 2 earns a point!");
                        player2.Score++;
                      
                        } 
                    }
                } 
            }
            Console.ReadLine();
        } 
    } 
}
        
    


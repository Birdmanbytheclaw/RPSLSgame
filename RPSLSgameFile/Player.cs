using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSgameFile
{
    public abstract class Player
    {
        string Name;
        int Score;
        List<int> gestures;
        int gesture;

        public Player()
        {
            gestures = new List<int>() {0, 1, 2, 3, 4};
        }

        public void ChooseGesture();
         {
            Console.WriteLine("Play a gesture! Choose between Rock(1), Paper(2), Scissors(3), Lizard(4), Spock(5)");
            gesture = Int32.Parse(Console.ReadLine());
            while (player1.score< 2 && player2.score< 2)
            {
                while (gesture == 1)
                {
                    Console.WriteLine("Player 1 chose Rock");
                    if (gesture == opponentInput)
                    {
                        Console.WriteLine("Draw! Choose Again!");
                    }
                    if (opponentInput == 3 && opponentInput == 4)
                    {
                        Console.WriteLine("Player 1 earns a point!");
                        player1.Score++;
                    }
                    if (opponentInput == 2 && opponentInput == 5)
                    {
                        Console.WriteLine("Player 2 earns a point!");
                        player2.Score++;
                    }
                }
                while (userInput == 2)
                {
                    Console.WriteLine("Player 1 chose Paper");
                    if (userInput == opponentInput)
                    {
                        Console.WriteLine("Draw! Choose Again!");
                    }
                    if (opponentInput == 1 && opponentInput == 5)
                    {
                        Console.WriteLine("Player 1 earns a point!");
                        userScore++;
                    }
                    if (opponentInput == 3 && opponentInput == 4)
                    {
                        Console.WriteLine("Player 2 earns a point!");
                        opponentScore++;
                    }
                }
                while (userInput == 3)
                {
                    Console.WriteLine("Player 1 chose Scissors");
                    if (userInput == opponentInput)
                    {
                        Console.WriteLine("Draw! Choose Again!");
                    }
                    if (opponentInput == 2 && opponentInput == 4)
                    {
                        Console.WriteLine("Player 1 earns a point!");
                        userScore++;
                    }
                    if (opponentInput == 1 && opponentInput == 5)
                    {
                        Console.WriteLine("Player 2 earns a point!");
                        opponentScore++;
                    }
                }
                while (userInput == 4)
                {
                    Console.WriteLine("Player 1 chose Lizard");
                    if (userInput == opponentInput)
                    {
                        Console.WriteLine("Draw! Choose Again!");
                    }
                    if (opponentInput == 2 && opponentInput == 5)
                    {
                        Console.WriteLine("Player 1 earns a point!");
                        userScore++;
                    }
                    if (opponentInput == 1 && opponentInput == 3)
                    {
                        Console.WriteLine("Player 2 earns a point!");
                        opponentScore++;
                    }
                }
                while (userInput == 5)
                {
                    Console.WriteLine("Player 1 chose Spock");
                    if (userInput == opponentInput)
                    {
                        Console.WriteLine("Draw! Choose Again!");
                    }
                    if (opponentInput == 1 && opponentInput == 3)
                    {
                        Console.WriteLine("Player 1 earns a point!");
                        userScore++;
                    }
                    if (opponentInput == 2 && opponentInput == 4)
                    {
                        Console.WriteLine("Player 2 earns a point!");
                        opponentScore++;
        public abstract void SetName();
	}

}


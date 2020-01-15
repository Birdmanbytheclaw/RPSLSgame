using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSgameFile
{
    class Computer : Player
    {
        public override void ChooseGesture()
        {
            Random rand = new Random();
            gesture = rand.Next(1, 5);
            switch (gesture)
            {
                case 1:
                    Console.WriteLine("Computer Chose Rock!");
                    break;
                case 2:
                    Console.WriteLine("Computer Chose Paper!!");
                    break;
                case 3:
                    Console.WriteLine("Computer Chose Scissors!!!");
                    break;
                case 4:
                    Console.WriteLine("Computer Chose Lizard!!!!");
                    break;
                case 5:
                    Console.WriteLine("Computer Chose Spock!!!!!");
                    break;
            }
        }

        public override void SetName()
        {
            throw new NotImplementedException();
        }
    }
}

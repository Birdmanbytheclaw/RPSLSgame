using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSgameFile
{
    public class Human : Player
    {
        public override void ChooseGesture()
        {
            Console.WriteLine("Play a gesture! Choose between Rock(1), Paper(2), Scissors(3), Lizard(4), Spock(5)");
            gesture = Int32.Parse(Console.ReadLine());
            //to do (use list to validate input)
           bool ListCheck = gestures.Contains(gesture);
            if (ListCheck == false)
            {
               ChooseGesture();
             }
           
        }
        public override void SetName()
        {
            throw new NotImplementedException();
        }
    }
}

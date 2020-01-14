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
            Console.WriteLine("Choose Gesture");
            gesture = (Console.ReadLine);
        }

        public override void SetName()
        {
            throw new NotImplementedException();
        }
    }
}

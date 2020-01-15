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
            
        }
        public override void SetName()
        {
            throw new NotImplementedException();
        }
    }
}

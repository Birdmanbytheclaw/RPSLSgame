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
            //Random
            Random random = new Random();
        }

        public override void SetName()
        {
            throw new NotImplementedException();
        }
    }
}

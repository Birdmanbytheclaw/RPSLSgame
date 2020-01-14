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
        int Store;
        List<string> Gestures;
        string gestures;

        public abstract void ChooseGesture();
        public abstract void SetName();
	}

}


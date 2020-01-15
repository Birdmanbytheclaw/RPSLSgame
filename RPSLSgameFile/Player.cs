using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLSgameFile
{
    public abstract class Player
    {
       public string Name;
        public List<int> gestures;
        public int gesture;
        public int Score;

        public Player()
        {
            gestures = new List<int>() {1, 2, 3, 4, 5};
        }
        public abstract void ChooseGesture();

        
        public abstract void SetName();
	}

}


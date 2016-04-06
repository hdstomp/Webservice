using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogRace.Classes
{
    public class Greyhound
    {
        public int StartingPos;
        public int RaceTrackLenght;
        public PictureBox MyPictureBox = null;
        public int Location = 0;
        public Random Randomizer;

        public bool Run()
        {
            
            return true;
        }
        
        public void TakeStartingPos()
        {
            Location = 0;
            StartingPos = 0;
        }
    }
}

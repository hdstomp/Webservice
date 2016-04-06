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
        public int Location;
        public Random Randomizer;
        int randomNum;

        public bool Run()
        {
            randomNum = 20;
            Location = Location + randomNum;
            MyPictureBox.Left = StartingPos + Location;

            return true;
        }
        
        public void TakeStartingPos()
        {
         
            Location = 0;    
        }
    }
}

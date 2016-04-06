using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogRace
{
    public partial class DogTrack : Form
    {
        public DogTrack()
        {
            InitializeComponent();
            PictureBox MyPictureBox = new PictureBox();

          

            
            Label kenBetLbl = new Label();
            Label toqeerBetLbl = new Label();
            Label robinBetLbl = new Label();

        }

        private void btnRace_Click(object sender, EventArgs e)
        {
            
            DogRace.Classes.Greyhound grey = new Classes.Greyhound();
            
            grey.MyPictureBox = picGreyhound1;
            grey.StartingPos = picRaceTrack.Left;
            grey.RaceTrackLenght = picRaceTrack.Width - picGreyhound1.Width;
            //grey.Location = grey.Randomizer.Next(1, 4);
            grey.Run();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DogRace.Classes.Greyhound grey = new Classes.Greyhound();
            grey.MyPictureBox = picGreyhound1;
            grey.StartingPos = picRaceTrack.Left;
            grey.TakeStartingPos();
        }

        

    }
}

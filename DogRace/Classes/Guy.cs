using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogRace.Classes
{
    public class Guy
    {
        public string Name;
        public Bet MyBet;
        public int Cash;

        public RadioButton MyRadioButton;
        public Label MyLabel;

        public void UpdateLabels()
        {

        }

        public void ClearBet()
        {

        }

        public bool PlaceBet(int BetAmount, int DogToWin)
        {
            return false;
        }

        public void Collect(int Winner)
        {

        }
    }
}

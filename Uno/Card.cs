using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uno
{
    class Card
    {
        public string[] colorOfCard = new string[] { "Red", "Green", "Yellow", "Blue" };
        public string[] typeOfCard = new string[] { "Numerical", "Action" };
        public int[] numericalCard = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        public string[] actionCard = new string[] { "Reverse", "Skip", "Draw Two", "Wild", "Wild Draw Four" };
        public int[] player = new int[] { };
        public int i;
        int reversePlay = 0;

        // This method will change the direction
        public void Reverse()
        {
            if (actionCard[0] == "Reverse")
            {
                reversePlay = 1;
            }

            if ((i >= 0 || i <= player.Length-1) && reversePlay == 1)
            {
                player[i] = player[i - 1];
            }
            else
            {
                player[i] = player.Length - 1;
            }
                        
        }

        public void Skip()
        {

        }

        public void DrawTwo()
        {

        }

        public void Wild()
        {

        }

        public void WildDrawFour()
        {

        }
    }
}

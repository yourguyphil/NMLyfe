using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpikeHelper
{
    public class Card
    {

        string theCardName;
        int cardCount = 0;

        public Card(string cardName, int count)
        {
            theCardName = cardName;
            cardCount = count;
            
        }

        public string getTheCardName()
        {
            return theCardName;
        }

        public int getTheCardCount()
        {
            return cardCount;
        }


        public void addCount()
        {
            cardCount++;
        }

        public void subtractCount()
        {
            cardCount--;
        }

    }
}

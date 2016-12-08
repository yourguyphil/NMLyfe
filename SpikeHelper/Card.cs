using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SpikeHelper
{
    public class Card
    {

        string theCardName;
        int cardCount = 0;
        string special="";
        ArrayList subSpecial =new ArrayList();

        public Card(string cardName, int count)
        {
            theCardName = cardName;
            cardCount = count;
            
        }
    

        public void setSpecial(string super)
        {
            special = super;
        }

        public void addSubSpecial(string super)
        {
            subSpecial.Add(super);
        }

        public string getSpecial()
        {
            return special;
        }

        public ArrayList getSubSpecial()
        {
            return subSpecial;
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

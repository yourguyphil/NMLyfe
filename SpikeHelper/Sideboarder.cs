using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace SpikeHelper
{
    public partial class Sideboarder : Form
    {

        ArrayList Deck;
        ArrayList SideBoard;
        int deckCount;
        int sbCount;
        LetsPlay that;

        public Sideboarder(ArrayList theDeck, ArrayList theSide, LetsPlay l)
        {
            InitializeComponent();

            that = l;
            Deck = theDeck;
            SideBoard = theSide;

            populate();

            foreach (Card x in Deck)
            {
                deckCount = deckCount + x.getTheCardCount();
                
            }

            foreach (Card y in SideBoard)
            {
                sbCount = sbCount + y.getTheCardCount();
               
            }

            label3.Text = "Cards in Main Deck : " + deckCount;
            label4.Text = "Cards in Side: " + sbCount;
           
        }

        private void populate()
        {
            ArrayList outDeck = new ArrayList();
            ArrayList outSB = new ArrayList();


            foreach (Card x in Deck)
            {
             
                outDeck.Add(x.getTheCardName() + " (x)" + x.getTheCardCount());
            }

            foreach (Card y in SideBoard)
            {
               
                outSB.Add(y.getTheCardName() + " (x)" + y.getTheCardCount());
            }

            lstDeck.DataSource = outDeck;
            lstSB.DataSource = outSB;


            label3.Text = "Cards in Main Deck : " + deckCount;
            label4.Text = "Cards in Side: " + sbCount;

        }

       

        private void lstDeck_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                int index = this.lstDeck.IndexFromPoint(e.Location);
                if (index != System.Windows.Forms.ListBox.NoMatches)
                {
                    string actualCard = lstDeck.Text.Substring(0, lstDeck.Text.IndexOf("(") - 1);

                    foreach (Card x in Deck)
                    {
                        if (x.getTheCardName() == actualCard)
                        {

                            moveToSB(actualCard);
                            label2.Text = "Put " + actualCard + " into SB";
                            break;
                        }
                    }
                }

                populate();

            }
            catch (IndexOutOfRangeException)
            {

            }
        }

        private void moveToSB(string itCard)
        {
              foreach (Card x in Deck)
            {
                if (x.getTheCardName() == itCard)
                {
                    x.subtractCount();
                    if (x.getTheCardCount() == 0)
                    {
                        Deck.Remove(x);
                        break;
                    }

                    break;
                }
            }

            bool containsCard = false;
            foreach (Card y in SideBoard)
            {
                if (y.getTheCardName() == itCard)
                {
                    y.addCount();
                    containsCard = true;
                }
            }


            if (containsCard == false)
            {
                SideBoard.Add(new Card(itCard, 1));
            }

            deckCount--;
            sbCount++;


        }

        private void lstSB_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                int index = this.lstSB.IndexFromPoint(e.Location);
                if (index != System.Windows.Forms.ListBox.NoMatches)
                {
                    string actualCard = lstSB.Text.Substring(0, lstSB.Text.IndexOf("(") - 1);

                    foreach (Card x in SideBoard)
                    {
                        if (x.getTheCardName() == actualCard)
                        {

                            moveToDeck(actualCard);
                            label2.Text = "Put " + actualCard + " into Deck";
                            break;
                        }
                    }
                }
                populate();

            }
            catch (IndexOutOfRangeException)
            {

            }
        }

        private void moveToDeck(string itCard)
        {
            foreach (Card x in SideBoard)
            {
                if (x.getTheCardName() == itCard)
                {
                    x.subtractCount();
                    if (x.getTheCardCount() == 0)
                    {
                        SideBoard.Remove(x);
                        break;
                    }

                    break;
                }
            }

            bool containsCard = false;
            foreach (Card y in Deck)
            {
                if (y.getTheCardName() == itCard)
                {
                    y.addCount();
                    containsCard = true;
                }
            }


            if (containsCard == false)
            {
                Deck.Add(new Card(itCard, 1));
            }

            sbCount--;
            deckCount++;

        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            that.Reset(Deck,deckCount);
            this.Close();
        }
    }
}

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
    public partial class SideBoard : Form
    {

        ArrayList side;
        int sbCount = 0;
        DeckBuilder ultimate;

        public SideBoard(DeckBuilder it, ArrayList sb)
        {
            InitializeComponent();
          
            
            ultimate = it;
            side = sb;
            
            if (sb.Count != 0)
            {
                fillup();
            }

            lblSBSize.Text = "Current SideBoard Count: " + sbCount;
        }

        private void fillup()
        {

            //fill the SB list UI
            ArrayList theCards = new ArrayList();

            foreach (Card it in side)
            {
                theCards.Add(it.getTheCardName() + " (x)" + it.getTheCardCount());
                sbCount= sbCount+ it.getTheCardCount();
            }

            lstSB.DataSource = theCards;
        }

        private void addCard(string theCardName)
        {
            //add the specified card to the sideboard
            bool containsCard = false;

            foreach (Card it in side)
            {
                if (it.getTheCardName() == theCardName)
                {
                    it.addCount();
                    containsCard = true;
                    break;
                }
            }


            if (containsCard == false)
            {
                side.Add(new Card(theCardName, 1));
            }

            sbCount++;
            lblSBSize.Text = "Current Deck Count: " + sbCount;

        }


        private void populate()
        {
            ArrayList deckOutput = new ArrayList();


            string line = "";
            foreach (Card x in side)
            {
                line = x.getTheCardName() + " (x)" + x.getTheCardCount();
                deckOutput.Add(line);
            }

            lstSB.DataSource = deckOutput;

        }

        //add card in textbox to sideboard
        private void txtCard_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addCard(txtCard.Text);
                txtCard.SelectionStart = 0;
                txtCard.SelectionLength = txtCard.Text.Length;

                populate();
            }
        }



        //sideboard done. 
        private void btnDone_Click(object sender, EventArgs e)
        {
            ultimate.addSB(side);
            this.Close();
        }

        private void lstSB_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.lstSB.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                string actualCard = lstSB.Text.Substring(0, lstSB.Text.IndexOf("(") - 1);
                removeCard(actualCard);
            }
        }

        //removed specific card from deck.
        private void removeCard(string unwanted)
        {
            foreach (Card it in side)
            {
                if (it.getTheCardName() == unwanted)
                {
                    it.subtractCount();
                    if (it.getTheCardCount() == 0)
                    {
                        side.Remove(it);
                        break;
                    }
                    break;

                }
            }

            sbCount--;
            
            lblSBSize.Text = "Current Deck Count: " + sbCount;

            populate();
        }


        //action to fill text box with selected card
        private void lstSB_MouseClick(object sender, MouseEventArgs e)
        {
            int index = this.lstSB.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                string actualCard = lstSB.Text.Substring(0, lstSB.Text.IndexOf("(") - 1);
                txtCard.Text = actualCard;
                txtCard.SelectionStart = 0;
                txtCard.SelectionLength = txtCard.Text.Length;
            }
        }

        private void btnSBNotes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Just SB Correctly");
        }
        
    }
}

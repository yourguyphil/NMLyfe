using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SpikeHelper
{
    public partial class Form5 : Form
    {

        int currDeckCount = 0;
        int currUsedDeckCount = 0;
        ArrayList Deck = new ArrayList();
        ArrayList usedDeck = new ArrayList();
        Dictionary<string, double> statsDictionary = new Dictionary<string, double>();

        public Form5(string theFileName)
        {
            InitializeComponent();
            lblDeckCount.Text = "Cards Left in Deck: ";
            lblUsedCount.Text = "Cards Used from Deck: ";
            if (theFileName != "")
            {
                fillup(theFileName);
            }
        }



        private void fillup(string input)
        {
            try
            {
                string[] lines = System.IO.File.ReadAllLines(input);

                foreach (string line in lines)
                {
                    string actualCard = line.Substring(0, line.IndexOf("(") - 1);
                    string actualCount = line.Substring(line.IndexOf(")") + 1);
                    Card theCard = new Card(actualCard, int.Parse(actualCount));
                    Deck.Add(theCard);

                }

                populateDeck();
                populateUsed();
                middleStats();
            }
            catch (FileNotFoundException)
            {

            }

        }

        private void middleStats()
        {
           
         double high=0.0;
         double low=999.999;

         ArrayList hotHigh = new ArrayList();
         ArrayList hotLow = new ArrayList();
         foreach(KeyValuePair<string, double> entry in statsDictionary)
         {
             if (entry.Value > high)
             {
                 high = entry.Value;
                 hotHigh.Add(entry.Key);
                 hotHigh.Remove(hotHigh[0]);
             }
             else if (entry.Value == high)
             {
                 hotHigh.Add(entry.Key);
             }

             if (entry.Value < low)
             {
                 low = entry.Value;
                 hotLow.Add(entry.Key);
                 hotLow.Remove(hotLow[0]);
             }
             else if(entry.Value == low)
             {
                 hotLow.Add(entry.Key);
             }
         }

         lblNext.Text ="Probable Next Card: "+ high + "%";
         lblLeast.Text ="Least Probable: " + low + "%";

         string line ="";
         for (int i = 0; i < 3;i++)
         {

             if (line != "")
             {
                 line += ",";
             }

             line += hotHigh[i];
         }
         
         lbloutMostProbs.Text = line;

         line = "";
         for (int i = 0; i < 3; i++)
         {

             if (line != "")
             {
                 line += ",";
             }

             line += hotLow[i];
         }

         lbloutLeastProbs.Text = line;



        }

        private void populateDeck()
        {
           
            int deckSize = 0;
            foreach (Card x in Deck)
            {
                deckSize += x.getTheCardCount();
            }

            ArrayList lines = new ArrayList();

            string line = "";

           
            foreach (Card x in Deck)
            {
                double stat = ((double)x.getTheCardCount() / (double)deckSize);

                line = x.getTheCardName() + " (x)" + x.getTheCardCount() + " - " + Math.Round(stat, 4) * 100 + "%";
                statsDictionary.Add(x.getTheCardName(), Math.Round(stat, 4) * 100);
                lines.Add(line);
            }

            currDeckCount = deckSize;

            lblDeckCount.Text = "Cards Left in Deck: " + currDeckCount;
            lstDeck.DataSource = lines;
        }

        private void populateUsed()
        {

           
            int usedDeckSize = 0;
            foreach (Card x in usedDeck)
            {
                usedDeckSize += x.getTheCardCount();
            }

            ArrayList lines = new ArrayList();

            string line = "";

           
            foreach (Card x in usedDeck)
            {
                double stat = ((double)x.getTheCardCount() / (double)usedDeckSize);

                line = x.getTheCardName() + " (x)" + x.getTheCardCount() + " - " + Math.Round(stat, 4) * 100 + "%";
                lines.Add(line);
            }

            currUsedDeckCount = usedDeckSize;

            lblUsedCount.Text = "Cards Used: " + currUsedDeckCount;
            lstUsed.DataSource = lines;
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
                            useCard(actualCard);
                            lblOutLasttAction.Text = "Put " + actualCard + " into used";
                            break;
                        }
                    }
                }

            }
            catch (IndexOutOfRangeException)
            {

            }

            statsDictionary.Clear();
            populateDeck();
            populateUsed();
            middleStats();
        }

        private void useCard(string itCard)
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
            foreach (Card y in usedDeck)
            {
                if (y.getTheCardName() == itCard)
                {
                    y.addCount();
                    containsCard = true;
                }
            }


            if (containsCard == false)
            {
                usedDeck.Add(new Card(itCard, 1));
            }
        }

        private void lstUsed_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                int index = this.lstUsed.IndexFromPoint(e.Location);
                if (index != System.Windows.Forms.ListBox.NoMatches)
                {
                    string actualCard = lstUsed.Text.Substring(0, lstUsed.Text.IndexOf("(") - 1);
                    
                    foreach (Card x in usedDeck)
                    {
                        if (x.getTheCardName() == actualCard)
                        {
                            
                            rebornCard(actualCard);
                            lblOutLasttAction.Text = "Put " + actualCard + " back into Deck";
                            break;
                        }
                    }
                }

                

            }
            catch (IndexOutOfRangeException)
            {

            }

            statsDictionary.Clear();
            populateDeck();
            populateUsed();
            middleStats();
        }

        private void rebornCard(string itCard)
        {

            foreach (Card x in usedDeck)
            {
                if (x.getTheCardName() == itCard)
                {
                    x.subtractCount();
                    if (x.getTheCardCount() == 0)
                    {
                        usedDeck.Remove(x);
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

        }

    }

   
}

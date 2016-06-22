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
        string file;
        ArrayList Deck ;
        ArrayList usedDeck ;
        Dictionary<string, double> statsDictionary;

        public Form5(string theFileName)
        {
            InitializeComponent();
            lblDeckCount.Text = "Cards Left in Deck: ";
            lblUsedCount.Text = "Cards Used from Deck: ";
            if (theFileName != "")
            {
                fillup(theFileName);
            }

            lstDeck.BackColor = Color.LightBlue;
            lstUsed.BackColor = Color.LightGray;
        }



        private void fillup(string input)
        {
            Deck = new ArrayList();
            usedDeck = new ArrayList();
            statsDictionary = new Dictionary<string, double>();
            try
            {
                file = input;
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
                 hotHigh.Clear();
                 hotHigh.Add(entry.Key);
             }
             else if (entry.Value == high)
             {
                 hotHigh.Add(entry.Key);
             }

             if (entry.Value < low)
             {
                 low = entry.Value;
                 hotLow.Clear();
                 hotLow.Add(entry.Key);
             }
             else if(entry.Value == low)
             {
                 hotLow.Add(entry.Key);
             }
         }

         lblNext.Text ="Probable Next Card: "+ high + "%";
         lblLeast.Text ="Least Probable: " + low + "%";

         cmbNext.DataSource = hotHigh;

         cmbLeast.DataSource = hotLow;

         
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

        private void tsbtnRestart_Click(object sender, EventArgs e)
        {
            restart();
           
        }

        private void restart()
        {
            statsDictionary.Clear();
            fillup(file);
            tsbar.Minimum = 0;
            tsbar.Maximum = 200;

            for (int i = 0; i <= 200; i++)
            {
                tsbar.Value = i;
            }

            for (int i = 200; i >= 0; i--)
            {
                tsbar.Value = i;
            }

        }

        private void tsbtnSample_Click(object sender, EventArgs e)
        {
            restart();

            ArrayList allCards = new ArrayList();

            foreach (Card x in Deck)
            {
                for (int i = 0; i < x.getTheCardCount(); i++) 
                { 
                allCards.Add(x.getTheCardName());
                }

            }

            


            draw(allCards,7);

            lblOutLasttAction.Text = "Drew a Hand of 7";

            statsDictionary.Clear();
            populateDeck();
            populateUsed();
            middleStats();
           }


        private void draw(ArrayList singles, int handSize){
            Random rnd = new Random();
            ArrayList pastNums = new ArrayList();
            int randNum;

            for(int i=0; i <handSize; i ++){

                //makes sure the same card is drawn and error is created. 
                do
                {
                    //random number must be smaller according to the previous cardss drawn becasue cards are removed
                    randNum = rnd.Next(0, singles.Count - 1 - i);
                } while (pastNums.Contains(randNum));

                pastNums.Add(randNum);
                
                useCard(singles[randNum].ToString());
            }

        }

        private void tsbDraw1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            ArrayList allCards = new ArrayList();

            foreach (Card x in Deck)
            {
                for (int i = 0; i < x.getTheCardCount(); i++)
                {
                    allCards.Add(x.getTheCardName());
                }

            }

            useCard(allCards[rnd.Next(0, currDeckCount-1)].ToString());

            statsDictionary.Clear();
            populateDeck();
            populateUsed();
            middleStats();
        }
       

    }

    
    }

   

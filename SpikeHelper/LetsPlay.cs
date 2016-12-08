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
    public partial class LetsPlay : Form
    {
        
        int currDeckCount = 0;
        int currUsedDeckCount = 0;
        string file ;
        ArrayList Deck = new ArrayList();
        ArrayList usedDeck = new ArrayList();
        ArrayList SideBoard = new ArrayList();
        Dictionary<string, double> statsDictionary= new Dictionary<string, double>();

        ArrayList orig;
        int origCount;

        public LetsPlay(string theFileName)
        {
            InitializeComponent();
            lblDeckCount.Text = "Cards Left in Deck: ";
            lblUsedCount.Text = "Cards Used from Deck: ";
            file = theFileName;


            if (theFileName != "")
            {
                fillup(theFileName);
                lbldeckName.Text = theFileName.Substring(theFileName.LastIndexOf("\\") + 1).Remove(theFileName.Substring(theFileName.LastIndexOf("\\")).Length - 5); ;
                lbldeckName.ForeColor = Color.Blue;
            }

            lstDeck.BackColor = Color.LightBlue;
            lstUsed.BackColor = Color.LightGray;
        }

        public void Reset(ArrayList modDeck, int count)
        {
            //Restart a game. Use modDeck as the guide for the 60 main decked

            Deck = modDeck;
            currDeckCount = count;

            
            usedDeck = new ArrayList();

            statsDictionary.Clear();
            populateDeck();
            populateUsed();
            middleStats();
        }


        private void fillup(string input)
        {

            //read and pullup data structures. 
            try
            {
                string[] lines = System.IO.File.ReadAllLines(input);
                ArrayList deckLines = new ArrayList();
                ArrayList sbLines = new ArrayList();

                int counter = 0;


                if (Array.IndexOf(lines, "##########SIDEBOARD##########") != -1)
                {
                    while (counter != Array.IndexOf(lines, "##########SIDEBOARD##########"))
                    {
                        deckLines.Add(lines[counter]);
                        counter++;
                    }

                    counter++;

                    while (counter < lines.Length)
                    {
                        sbLines.Add(lines[counter]);
                        counter++;
                    }

                }
                else
                {
                    while (counter != lines.Length)
                    {
                        deckLines.Add(lines[counter]);
                        counter++;
                    }
                }


                string actualCard;
                string actualCount;
                Card theCard;

                foreach (string line in deckLines)
                {
                    actualCard = line.Substring(0, line.IndexOf("(") - 1);
                    actualCount = line.Substring(line.IndexOf(")") + 1);
                    theCard = new Card(actualCard, int.Parse(actualCount));
                    Deck.Add(theCard);
                    currDeckCount += int.Parse(actualCount);
                }


                foreach (string line in sbLines)
                {
                    actualCard = line.Substring(0, line.IndexOf("("));
                    actualCount = line.Substring(line.IndexOf(")") + 1);
                    theCard = new Card(actualCard, int.Parse(actualCount));
                    SideBoard.Add(theCard);

                }

                populateDeck();
                orig = Deck;
                origCount = currDeckCount;
            }
            catch (FileNotFoundException)
            {

            }

        }

        private void middleStats()
        {
           
         //Statistics of Sigle Specific to a boarder whole deck 
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


        //listBox fill with the use if a string builder for USED

        private void populateDeck()
        {
           //fill cards in deck currently vs in play list 
            int deckSize = 0;


            foreach (Card y in Deck)
            {
                deckSize += y.getTheCardCount();
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


        //listBox fill with the use if a string builder for USED 

        private void populateUsed()
        {

           //fill cards being used list
            int usedDeckSize = 0;
            foreach (Card x in usedDeck)
            {
                usedDeckSize += x.getTheCardCount();
            }

            ArrayList lines = new ArrayList();

            string line = "";

           //calculate the individual stats 
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


        //Event for moving cards from deck to used '

        private void lstDeck_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            //use location to find card and use it
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


            //reset the UI and refresh the DS
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


            //reset the UI and refresh the DS
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
            Deck = new ArrayList();
            usedDeck = new ArrayList();
            SideBoard = new ArrayList();
            fillup(file);
            populateUsed();
           

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
           // restart();

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


            //reset the UI and refresh the DS
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

            string it = allCards[rnd.Next(0, currDeckCount-1)].ToString();

            useCard(it);


            //reset the UI and refresh the DS
            statsDictionary.Clear();
            populateDeck();
            populateUsed();
            middleStats();
            lblOutLasttAction.Text = "Drew a " +  it + " from Deck";
        }

        private void tsbSideBoard_Click(object sender, EventArgs e)
        {
            Sideboarder sb = new Sideboarder(Deck, SideBoard,this);
            sb.Show();
        }

      
       

    }

    
    }

   

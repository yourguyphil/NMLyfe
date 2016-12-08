/*Bulding / editing a deck depends on reading the file name 
 * 
 */
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
    public partial class DeckBuilder : Form
    {

        ArrayList Deck = new ArrayList();
        ArrayList sideBoard = new ArrayList();
        int deckCount=0;
        
        public DeckBuilder(string fileName)
        {
            InitializeComponent();
            

            if (fileName != "")
            {
                fillup(fileName);

                //get only the DeckName part
                try
                {
                    
                    lblDeckName.Text = "Deck: \n\n         " + fileName.Substring(fileName.LastIndexOf("\\") + 1).Remove(fileName.Substring(fileName.LastIndexOf("\\")).Length - 5);
                }
                catch(ArgumentOutOfRangeException){

                }
                
                }


            lbltheDC.Text = "Current Deck Count: " + deckCount;

        }

        private void fillup(string input)
        {

            //Fill in what we have of the deck already

            try
            {
                string[] lines = System.IO.File.ReadAllLines(input);

                //holds maindeck
                ArrayList deckLines = new ArrayList();

                //holds sidedeck
                ArrayList sbLines = new ArrayList();


                //keeps track of actual line we are on
                int counter=0;

                //Main deck stops at Sideboard line
                if (Array.IndexOf(lines, "##########SIDEBOARD##########") != -1)
                {

                    //each line is data. card including extra string stuff ot make it look pretty and the card count
                    while (counter != Array.IndexOf(lines, "##########SIDEBOARD##########"))
                    {
                        deckLines.Add(lines[counter]);
                        counter++;
                    }

                    counter++;


                    //we hit the sideboard
                    while (counter < lines.Length)
                    {
                        sbLines.Add(lines[counter]);
                        counter++;
                    }

                }
                else
                {

                    //add the line!
                    while (counter != lines.Length)
                    {
                        deckLines.Add(lines[counter]);
                        counter++;
                    }
                }
               

                string actualCard;
                string actualCount;
               Card theCard;


                //get the actual card name and count
                foreach (string line in deckLines)
                {
                    actualCard = line.Substring(0, line.IndexOf("(") - 1);
                    actualCount = line.Substring(line.IndexOf(")") + 1);
                    theCard = new Card(actualCard, int.Parse(actualCount));
                    Deck.Add(theCard);
                    deckCount+=int.Parse(actualCount);
                }


                foreach (string line in sbLines)
                {
                    actualCard = line.Substring(0, line.IndexOf("(") );
                    actualCount = line.Substring(line.IndexOf(")") + 1);
                    theCard = new Card(actualCard, int.Parse(actualCount));
                    sideBoard.Add(theCard);
                    
                }


                //fillitup! 
                populate();
            }
            catch(FileNotFoundException){

            }

        }


        //save the deck
        private void btnSave_Click(object sender, EventArgs e)
        {
           
            saveIt.Filter = "Text File|*.txt";
            saveIt.Title = "Save Deck!";
            saveIt.ShowDialog();

        }
        

        //deck builder adding a card to the deck
        private void addCard(string theCardName)
        {

            bool containsCard=false;

            //find of the card wanting to be added exists already or not
            foreach (Card it in Deck)
            {
                if (it.getTheCardName() == theCardName)
                {
                    //just make the count go up then
                    it.addCount();
                    containsCard = true;
                    break;
                }
            }



            //it it doesnt contain it ass a totally new card! 
            if (containsCard==false)
            {
                Deck.Add(new Card(theCardName,1));
            }


            //add card so deck count goes up
            deckCount++;
            lbltheDC.Text = "Current Deck Count: " + deckCount;

        }

        private void populate()
        {
            ArrayList deckOutput = new ArrayList();


            string line = "";

            //get the deck in output UI
            foreach (Card x in Deck)
            {
                line = x.getTheCardName() + " (x)" + x.getTheCardCount();
                deckOutput.Add(line);
            }

            lstMyDeck.DataSource = deckOutput;
            
        }

       
        //add that thing in the input textbox
        private void txtCardName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addCard(txtCardName.Text);
                txtCardName.SelectionStart = 0;
                txtCardName.SelectionLength = txtCardName.Text.Length;

                populate();
            }
        }

       
       

        private void lstMyDeck_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //remove a card when card name is selected in list

            int index = this.lstMyDeck.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                string actualCard = lstMyDeck.Text.Substring(0, lstMyDeck.Text.IndexOf("(")-1);
                removeCard(actualCard);
            }
        }

        private void removeCard(string unwanted)
        {

            //search for selcred card
            foreach (Card it in Deck)
            {
                if (it.getTheCardName() == unwanted)
                {

                    //lower count if =0 it is out of the Deck
                    it.subtractCount();
                    if (it.getTheCardCount() == 0)
                    {
                        Deck.Remove(it);
                        break;
                    }
                    break;
                    
                }
            }


            //sub from total deck count
            deckCount--;
            lbltheDC.Text = "Current Deck Count: " + deckCount;

            populate();
        }

        private void saveIt_FileOk(object sender, CancelEventArgs e)
        {

            string name = saveIt.FileName;


            //save into a text file
            if (saveIt.FileName != "")
            {

                StreamWriter outputWriter = new StreamWriter(name);


                //iterate through deck constructing lines of String

                for (int i = 0; i < lstMyDeck.Items.Count; i++)
                {

                    Card it = (Card)Deck[i];
                    ArrayList subs= it.getSubSpecial();
                    string line="";

                    for (int j = 0; j < subs.Count; j++)
                    {
                        line += "*" + subs[j];
                    }
                    if (it.getSpecial() != "")
                    {
                        outputWriter.WriteLine(lstMyDeck.Items[i].ToString() + "$" + it.getSpecial().Trim(':').Trim('}') + line.Trim(':').Trim('}'));
                    }
                    else
                    {
                        outputWriter.WriteLine(lstMyDeck.Items[i].ToString());
                    }
                }

                outputWriter.WriteLine("##########SIDEBOARD##########");
                for (int j = 0; j < sideBoard.Count; j++)
                {
                    outputWriter.WriteLine(((Card)sideBoard[j]).getTheCardName() + " (x)" + ((Card)sideBoard[j]).getTheCardCount());
                }

                    outputWriter.Flush();
                outputWriter.Close();
            }
            
            
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            Form4 four = new Form4(Deck);
            four.Show();
        }

        private void lstMyDeck_MouseClick(object sender, MouseEventArgs e)
        {

            int index = this.lstMyDeck.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                string actualCard = lstMyDeck.Text.Substring(0, lstMyDeck.Text.IndexOf("(")-1);
                txtCardName.Text = actualCard;
                txtCardName.SelectionStart = 0;
                txtCardName.SelectionLength = txtCardName.Text.Length;
            }
           
        }

        private void lstMyDeck_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                
                try
                {

                    
                    int index = this.lstMyDeck.IndexFromPoint(e.Location);
                    if (index != System.Windows.Forms.ListBox.NoMatches )
                    {
                        string actualCard = lstMyDeck.Text.Substring(0, lstMyDeck.Text.IndexOf("(") - 1);
                        Card hotCard;

                        foreach (Card x in Deck)
                        {
                            if (x.getTheCardName() == actualCard)
                            {
                                hotCard = x;
                                Spec seven = new Spec(hotCard);
                                seven.Show();
                                
                            }
                        }

                    }

                }
                catch (IndexOutOfRangeException)
                {

                }


            }
                
        }

        private void btnSB_Click(object sender, EventArgs e)
        {
            SideBoard sb = new SideBoard(this, sideBoard);
            sb.Show();
        }


        public void addSB(ArrayList theSB)
        {
            sideBoard = theSB;
        }
    }
}

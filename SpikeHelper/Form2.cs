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
    public partial class Form2 : Form
    {

        ArrayList Deck = new ArrayList();
        
        public Form2(string fileName)
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

                populate();
            }
            catch(FileNotFoundException){

            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
            saveIt.Filter = "Text File|*.txt";
            saveIt.Title = "Save Deck!";
            saveIt.ShowDialog();

        }
        
        private void addCard(string theCardName)
        {

            bool containsCard=false;

            foreach (Card it in Deck)
            {
                if (it.getTheCardName() == theCardName)
                {
                    it.addCount();
                    containsCard = true;
                    break;
                }
            }


            if (containsCard==false)
            {
                Deck.Add(new Card(theCardName,1));
            }

        }

        private void populate()
        {
            ArrayList deckOutput = new ArrayList();


            string line = "";
            foreach (Card x in Deck)
            {
                line = x.getTheCardName() + " (x)" + x.getTheCardCount();
                deckOutput.Add(line);
            }

            lstMyDeck.DataSource = deckOutput;
            
        }

       

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
            int index = this.lstMyDeck.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                string actualCard = lstMyDeck.Text.Substring(0, lstMyDeck.Text.IndexOf("(")-1);
                removeCard(actualCard);
            }
        }

        private void removeCard(string unwanted)
        {
            foreach (Card it in Deck)
            {
                if (it.getTheCardName() == unwanted)
                {
                    it.subtractCount();
                    if (it.getTheCardCount() == 0)
                    {
                        Deck.Remove(it);
                        break;
                    }
                    break;
                    
                }
            }

            populate();
        }

        private void saveIt_FileOk(object sender, CancelEventArgs e)
        {

            string name = saveIt.FileName;

            if (saveIt.FileName != "")
            {

                StreamWriter outputWriter = new StreamWriter(name);

                for (int i = 0; i < lstMyDeck.Items.Count; i++)
                {
                    
                    outputWriter.WriteLine(lstMyDeck.Items[i].ToString());
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
       
    }
}

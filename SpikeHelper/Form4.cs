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
    public partial class Form4 : Form
    {

        int fullDeckCount = 0;
        ArrayList Deck;

        public Form4(ArrayList theInput)
        {
            InitializeComponent();

            populate(theInput);

           
            
        }

        private void populate(ArrayList input)
        {
            txtnum.Text = "1";
            int deckSize=0;

            foreach (Card x in input)
            {
                deckSize += x.getTheCardCount();
            }

            ArrayList lines = new ArrayList();

            string line = "";
            foreach (Card x in input)
            {
                double stat =  ((double)x.getTheCardCount() / (double)deckSize);
                line = x.getTheCardName() + " (x)" + x.getTheCardCount() + " - " + Math.Round(stat, 4) * 100 + "%";
                lines.Add(line);
            }

            fullDeckCount = deckSize;
            Deck = input;
            lines.Add("The total deck count is: "+ deckSize);

            lstStats.DataSource = lines;

        }

        private void lstStats_MouseDoubleClick(object sender, MouseEventArgs e)
        {
             lblCardName.Text = "??????";
             lbl5.Text = "Five: ";
             lbl6.Text = "Six: ";
             lbl7.Text = "Seven: ";
            try
            {
                int index = this.lstStats.IndexFromPoint(e.Location);
                if (index != lstStats.Items.Count-1 && index != System.Windows.Forms.ListBox.NoMatches)
                {
                    string actualCard = lstStats.Text.Substring(0, lstStats.Text.IndexOf("(") - 1);
                    lblCardName.Text = actualCard;
                    foreach (Card x in Deck)
                    {
                        if (x.getTheCardName() == actualCard)
                        {
                            int other = fullDeckCount - x.getTheCardCount();

                            lbl5.Text += Math.Round(calculate(other, 5,0),4) *100 + "%";
                            lbl6.Text += Math.Round(calculate(other, 6,0),4) * 100 + "%";
                            lbl7.Text += Math.Round(calculate(other, 7,0),4) * 100 + "%";
                            break;
                        }
                    }
                }

            }
            catch (IndexOutOfRangeException)
            {

            }

                
        }

        private double calculate(int non, int hand, int offset)
        {

             int holdSize= fullDeckCount;

            double part=(double)non / (double)holdSize;

            for (int i = 0; i < hand-offset; i++)
            {
                
                part = part * ((double)(non - 1) / (double)(holdSize - 1));
            }
                return 1-part;
        }

        private void lstStats_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                
                 try
                    {
                int index = this.lstStats.IndexFromPoint(e.Location);
                if (index != System.Windows.Forms.ListBox.NoMatches && index!= lstStats.Items.Count-1)
                {
                    string actualCard = lstStats.Text.Substring(0, lstStats.Text.IndexOf("(") - 1);
                    if (!lstCustom.Items.Contains(actualCard))
                    {
                        lstCustom.Items.Add(actualCard);
                    }
                   
                }
              
                        }
            catch (IndexOutOfRangeException)
            {

            }

                
            }
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            lblCardName.Text = "Custom Set";

            int count = 0;
    
            for (int i = 0; i < lstCustom.Items.Count; i++)
            {
               
                string actualname = lstCustom.Items[i].ToString();

                foreach (Card x in Deck)
                {
                    if (x.getTheCardName() == actualname)
                    {
                        count = count + x.getTheCardCount();
                       
                    }
                }
            }

            Console.WriteLine(count);
           int other = fullDeckCount - count;

                        lbl5.Text += Math.Round(calculate(other, 5,int.Parse(txtnum.Text)), 4) * 100 + "%";
                        lbl6.Text += Math.Round(calculate(other, 6, int.Parse(txtnum.Text)), 4) * 100 + "%";
                        lbl7.Text += Math.Round(calculate(other, 7, int.Parse(txtnum.Text)), 4) * 100 + "%";

                        lstStats.Enabled = false;
                        btnCalc.Enabled = false;
                        MessageBox.Show("Please Reopen to do more stats!");
                        
                        
               
        }
    }
}

/*This class is the middle man that initalies either creating a new deck or editing an old existing deck 
 * 
 * 
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
    public partial class DBChoices : Form
    {
        public DBChoices()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            //Initialize Building a new Deck Form

            DeckBuilder two = new DeckBuilder("");
            two.Show();
            Hide();
            
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

            //Initialize Editing an already existed Deck

            ofdSaves.Filter = "Text File|*.txt";
            ofdSaves.Title = "Load Deck!";
            ofdSaves.ShowDialog();
            DeckBuilder two = new DeckBuilder(ofdSaves.FileName);
            two.Show();
            Hide();
        }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpikeHelper
{
    public partial class Initial : Form
    {
        public Initial()
        {
            InitializeComponent();

            //Cute Linked Text to Github on UI
            LinkLabel.Link link = new LinkLabel.Link();
            link.LinkData = "https://github.com/yourguyphil";
            linkLabel1.Links.Add(link);
        }

        private void btnBuild_Click(object sender, EventArgs e)
        {
            //Open DeckBuilder Form
            DBChoices three = new DBChoices();
            three.Show();
        }

        private void btnLetsPlay_Click(object sender, EventArgs e)
        {
            //Help initialize file input
            ofdLetsPlay.Filter = "Deck(Text File)|*.txt";
            ofdLetsPlay.Title = "Gear up & Load Deck!";
            ofdLetsPlay.ShowDialog();

            //if it is a valid deck name....
            if (!(ofdLetsPlay.FileName == ""))
            {
                //Open Playing Form, 
                LetsPlay five = new LetsPlay(ofdLetsPlay.FileName);
                five.Show();
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            //cute
            MessageBox.Show("Philips is Awesome");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           //go to actual link
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        
    }


}


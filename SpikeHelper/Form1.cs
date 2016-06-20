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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            LinkLabel.Link link = new LinkLabel.Link();
            link.LinkData = "https://github.com/yourguyphil";
            linkLabel1.Links.Add(link);
        }

        private void btnBuild_Click(object sender, EventArgs e)
        {
            Form3 three = new Form3();
            three.Show();
        }

        private void btnLetsPlay_Click(object sender, EventArgs e)
        {
            ofdLetsPlay.Filter = "Deck(Text File)|*.txt";
            ofdLetsPlay.Title = "Gear up & Load Deck!";
            ofdLetsPlay.ShowDialog();
            Form5 five = new Form5(ofdLetsPlay.FileName);
            five.Show();
        }

        private void ofdLetsPlay_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Philips is Awesome");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           

            
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        
    }


}


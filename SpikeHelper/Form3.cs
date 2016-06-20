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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Form2 two = new Form2("");
            two.Show();
            Hide();
            
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

            ofdSaves.Filter = "Text File|*.txt";
            ofdSaves.Title = "Load Deck!";
            ofdSaves.ShowDialog();
            Form2 two = new Form2(ofdSaves.FileName);
            two.Show();
            Hide();
        }


    }
}

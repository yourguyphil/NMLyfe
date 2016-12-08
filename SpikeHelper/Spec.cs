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
    public partial class Spec : Form
    {
        Card theCard;
        
        int theIndex = 0;
        public Spec(Card hotCard)
        {
            InitializeComponent();

            theCard = hotCard;
           
            lstViewSpec.View = View.List;
            lblCardName.Text = theCard.getTheCardName();


            if (theCard.getSpecial() != "")
            {
                lstViewSpec.Items.Add("Special Field: " + theCard.getSpecial().Trim('}'));
                lstViewSpec.Items[0].BackColor = Color.LightSalmon;
            }



            if (theCard.getSubSpecial().Count != 0)
            {
                ArrayList stuff = theCard.getSubSpecial();

                for (int i = 0; i < stuff.Count; i++)
                {
                    lstViewSpec.Items.Add("Sub Field: " + ((string)stuff[i]).Trim('}'));
                    lstViewSpec.Items[theIndex].BackColor = Color.LightSkyBlue;
                }




                txtSubSpec.Enabled = false;

            }
        }

        private void txtInputSpec_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {

                string mySpec = txtInputSpec.Text;

                lstViewSpec.Items.Add("Special Field: "+ mySpec);
                lstViewSpec.Items[0].BackColor = Color.LightSalmon;

                txtInputSpec.Enabled = false;
                txtSubSpec.Enabled = true;
            }
        }

        private void txtSubSpec_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                string mySubSpec = txtSubSpec.Text;

                theIndex++;
                lstViewSpec.Items.Add("Sub Field: " + mySubSpec);
                lstViewSpec.Items[theIndex].BackColor = Color.LightSkyBlue;

                txtSubSpec.SelectionStart = 0;
                txtSubSpec.SelectionLength = txtSubSpec.Text.Length;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            txtInputSpec.Enabled = true;
            txtSubSpec.Enabled = true;

            lstViewSpec.Clear();
        }

        private void btnAddSpec_Click(object sender, EventArgs e)
        {

            string line = lstViewSpec.Items[0].ToString();
            theCard.setSpecial(line.Substring(line.LastIndexOf(":",line.Length-1)));

            for (int i = 1; i < lstViewSpec.Items.Count; i++)
            {
                line = lstViewSpec.Items[i].ToString();
                theCard.addSubSpecial(line.Substring(line.LastIndexOf(":", line.Length - 1)));
            }

            line = "";
            foreach (string y in theCard.getSubSpecial())
            {
                line += y.Trim('}') + " ***";
            }

           
            MessageBox.Show("Special Fields for " + theCard.getTheCardName() + " updated! \nThe Special Field is " + theCard.getSpecial().Trim('}') + "\nwith SubSpecials " + line);
        }

       


       

       






    }
}

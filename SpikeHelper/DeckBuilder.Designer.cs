namespace SpikeHelper
{
    partial class DeckBuilder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeckBuilder));
            this.lstMyDeck = new System.Windows.Forms.ListBox();
            this.lblDeck = new System.Windows.Forms.Label();
            this.txtCardName = new System.Windows.Forms.TextBox();
            this.lblAdd = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnStats = new System.Windows.Forms.Button();
            this.saveIt = new System.Windows.Forms.SaveFileDialog();
            this.lblDeckName = new System.Windows.Forms.Label();
            this.lbltheDC = new System.Windows.Forms.Label();
            this.btnSB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstMyDeck
            // 
            this.lstMyDeck.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lstMyDeck.FormattingEnabled = true;
            this.lstMyDeck.Location = new System.Drawing.Point(297, 54);
            this.lstMyDeck.Name = "lstMyDeck";
            this.lstMyDeck.Size = new System.Drawing.Size(176, 420);
            this.lstMyDeck.TabIndex = 0;
            this.lstMyDeck.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstMyDeck_MouseClick);
            this.lstMyDeck.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstMyDeck_MouseDoubleClick);
            this.lstMyDeck.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstMyDeck_MouseDown);
            // 
            // lblDeck
            // 
            this.lblDeck.AutoSize = true;
            this.lblDeck.BackColor = System.Drawing.Color.Teal;
            this.lblDeck.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeck.Location = new System.Drawing.Point(331, 32);
            this.lblDeck.Name = "lblDeck";
            this.lblDeck.Size = new System.Drawing.Size(72, 18);
            this.lblDeck.TabIndex = 1;
            this.lblDeck.Text = "The Deck";
            // 
            // txtCardName
            // 
            this.txtCardName.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtCardName.Location = new System.Drawing.Point(98, 240);
            this.txtCardName.Name = "txtCardName";
            this.txtCardName.Size = new System.Drawing.Size(100, 20);
            this.txtCardName.TabIndex = 2;
            this.txtCardName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCardName_KeyDown);
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd.Location = new System.Drawing.Point(12, 238);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(80, 20);
            this.lblAdd.TabIndex = 3;
            this.lblAdd.Text = "Add Card:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(60, 436);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(154, 46);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnStats
            // 
            this.btnStats.Location = new System.Drawing.Point(60, 294);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(154, 52);
            this.btnStats.TabIndex = 5;
            this.btnStats.Text = "See Stats";
            this.btnStats.UseVisualStyleBackColor = true;
            this.btnStats.Click += new System.EventHandler(this.btnStats_Click);
            // 
            // saveIt
            // 
            this.saveIt.FileOk += new System.ComponentModel.CancelEventHandler(this.saveIt_FileOk);
            // 
            // lblDeckName
            // 
            this.lblDeckName.AutoSize = true;
            this.lblDeckName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeckName.Location = new System.Drawing.Point(55, 78);
            this.lblDeckName.Name = "lblDeckName";
            this.lblDeckName.Size = new System.Drawing.Size(0, 25);
            this.lblDeckName.TabIndex = 6;
            // 
            // lbltheDC
            // 
            this.lbltheDC.AutoSize = true;
            this.lbltheDC.Location = new System.Drawing.Point(299, 476);
            this.lbltheDC.Name = "lbltheDC";
            this.lbltheDC.Size = new System.Drawing.Size(104, 13);
            this.lbltheDC.TabIndex = 8;
            this.lbltheDC.Text = "Current Deck Count:";
            // 
            // btnSB
            // 
            this.btnSB.Location = new System.Drawing.Point(60, 363);
            this.btnSB.Name = "btnSB";
            this.btnSB.Size = new System.Drawing.Size(154, 52);
            this.btnSB.TabIndex = 9;
            this.btnSB.Text = "Side Board";
            this.btnSB.UseVisualStyleBackColor = true;
            this.btnSB.Click += new System.EventHandler(this.btnSB_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(481, 520);
            this.Controls.Add(this.btnSB);
            this.Controls.Add(this.lbltheDC);
            this.Controls.Add(this.lblDeckName);
            this.Controls.Add(this.btnStats);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.txtCardName);
            this.Controls.Add(this.lblDeck);
            this.Controls.Add(this.lstMyDeck);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Deck Builder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstMyDeck;
        private System.Windows.Forms.Label lblDeck;
        private System.Windows.Forms.TextBox txtCardName;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnStats;
        private System.Windows.Forms.SaveFileDialog saveIt;
        private System.Windows.Forms.Label lblDeckName;
        private System.Windows.Forms.Label lbltheDC;
        private System.Windows.Forms.Button btnSB;
    }
}
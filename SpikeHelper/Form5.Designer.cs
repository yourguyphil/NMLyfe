namespace SpikeHelper
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.lstDeck = new System.Windows.Forms.ListBox();
            this.lstUsed = new System.Windows.Forms.ListBox();
            this.picSpike = new System.Windows.Forms.PictureBox();
            this.lblDeck = new System.Windows.Forms.Label();
            this.lblUsed = new System.Windows.Forms.Label();
            this.lblDeckCount = new System.Windows.Forms.Label();
            this.lblUsedCount = new System.Windows.Forms.Label();
            this.lblNext = new System.Windows.Forms.Label();
            this.lblLeast = new System.Windows.Forms.Label();
            this.lblLastAction = new System.Windows.Forms.Label();
            this.lbloutMostProbs = new System.Windows.Forms.Label();
            this.lbloutLeastProbs = new System.Windows.Forms.Label();
            this.lblOutLasttAction = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picSpike)).BeginInit();
            this.SuspendLayout();
            // 
            // lstDeck
            // 
            this.lstDeck.FormattingEnabled = true;
            this.lstDeck.Location = new System.Drawing.Point(21, 39);
            this.lstDeck.Name = "lstDeck";
            this.lstDeck.Size = new System.Drawing.Size(255, 329);
            this.lstDeck.TabIndex = 0;
            this.lstDeck.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstDeck_MouseDoubleClick);
            // 
            // lstUsed
            // 
            this.lstUsed.FormattingEnabled = true;
            this.lstUsed.Location = new System.Drawing.Point(555, 39);
            this.lstUsed.Name = "lstUsed";
            this.lstUsed.Size = new System.Drawing.Size(255, 329);
            this.lstUsed.TabIndex = 1;
            this.lstUsed.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstUsed_MouseDoubleClick);
            // 
            // picSpike
            // 
            this.picSpike.Image = ((System.Drawing.Image)(resources.GetObject("picSpike.Image")));
            this.picSpike.Location = new System.Drawing.Point(305, 16);
            this.picSpike.Name = "picSpike";
            this.picSpike.Size = new System.Drawing.Size(230, 246);
            this.picSpike.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSpike.TabIndex = 2;
            this.picSpike.TabStop = false;
            // 
            // lblDeck
            // 
            this.lblDeck.AutoSize = true;
            this.lblDeck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeck.Location = new System.Drawing.Point(108, 16);
            this.lblDeck.Name = "lblDeck";
            this.lblDeck.Size = new System.Drawing.Size(50, 20);
            this.lblDeck.TabIndex = 3;
            this.lblDeck.Text = "Deck:";
            // 
            // lblUsed
            // 
            this.lblUsed.AutoSize = true;
            this.lblUsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsed.Location = new System.Drawing.Point(651, 16);
            this.lblUsed.Name = "lblUsed";
            this.lblUsed.Size = new System.Drawing.Size(51, 20);
            this.lblUsed.TabIndex = 4;
            this.lblUsed.Text = "Used:";
            // 
            // lblDeckCount
            // 
            this.lblDeckCount.AutoSize = true;
            this.lblDeckCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeckCount.Location = new System.Drawing.Point(30, 371);
            this.lblDeckCount.Name = "lblDeckCount";
            this.lblDeckCount.Size = new System.Drawing.Size(51, 20);
            this.lblDeckCount.TabIndex = 5;
            this.lblDeckCount.Text = "label3";
            // 
            // lblUsedCount
            // 
            this.lblUsedCount.AutoSize = true;
            this.lblUsedCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsedCount.Location = new System.Drawing.Point(581, 371);
            this.lblUsedCount.Name = "lblUsedCount";
            this.lblUsedCount.Size = new System.Drawing.Size(51, 20);
            this.lblUsedCount.TabIndex = 6;
            this.lblUsedCount.Text = "label4";
            // 
            // lblNext
            // 
            this.lblNext.AutoSize = true;
            this.lblNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNext.Location = new System.Drawing.Point(288, 236);
            this.lblNext.Name = "lblNext";
            this.lblNext.Size = new System.Drawing.Size(102, 13);
            this.lblNext.TabIndex = 7;
            this.lblNext.Text = "Probable Next Card:";
            // 
            // lblLeast
            // 
            this.lblLeast.AutoSize = true;
            this.lblLeast.Location = new System.Drawing.Point(288, 287);
            this.lblLeast.Name = "lblLeast";
            this.lblLeast.Size = new System.Drawing.Size(81, 13);
            this.lblLeast.TabIndex = 8;
            this.lblLeast.Text = "Least Probable:";
            // 
            // lblLastAction
            // 
            this.lblLastAction.AutoSize = true;
            this.lblLastAction.Location = new System.Drawing.Point(288, 333);
            this.lblLastAction.Name = "lblLastAction";
            this.lblLastAction.Size = new System.Drawing.Size(63, 13);
            this.lblLastAction.TabIndex = 9;
            this.lblLastAction.Text = "Last Action:";
            // 
            // lbloutMostProbs
            // 
            this.lbloutMostProbs.AutoSize = true;
            this.lbloutMostProbs.Location = new System.Drawing.Point(297, 249);
            this.lbloutMostProbs.Name = "lbloutMostProbs";
            this.lbloutMostProbs.Size = new System.Drawing.Size(37, 13);
            this.lbloutMostProbs.TabIndex = 10;
            this.lbloutMostProbs.Text = "xxxxxx";
            // 
            // lbloutLeastProbs
            // 
            this.lbloutLeastProbs.AutoSize = true;
            this.lbloutLeastProbs.Location = new System.Drawing.Point(302, 300);
            this.lbloutLeastProbs.Name = "lbloutLeastProbs";
            this.lbloutLeastProbs.Size = new System.Drawing.Size(32, 13);
            this.lbloutLeastProbs.TabIndex = 11;
            this.lbloutLeastProbs.Text = "xxxxx";
            // 
            // lblOutLasttAction
            // 
            this.lblOutLasttAction.AutoSize = true;
            this.lblOutLasttAction.Location = new System.Drawing.Point(302, 346);
            this.lblOutLasttAction.Name = "lblOutLasttAction";
            this.lblOutLasttAction.Size = new System.Drawing.Size(32, 13);
            this.lblOutLasttAction.TabIndex = 12;
            this.lblOutLasttAction.Text = "xxxxx";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(837, 431);
            this.Controls.Add(this.lblOutLasttAction);
            this.Controls.Add(this.lbloutLeastProbs);
            this.Controls.Add(this.lbloutMostProbs);
            this.Controls.Add(this.lblLastAction);
            this.Controls.Add(this.lblLeast);
            this.Controls.Add(this.lblNext);
            this.Controls.Add(this.lblUsedCount);
            this.Controls.Add(this.lblDeckCount);
            this.Controls.Add(this.lblUsed);
            this.Controls.Add(this.lblDeck);
            this.Controls.Add(this.picSpike);
            this.Controls.Add(this.lstUsed);
            this.Controls.Add(this.lstDeck);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form5";
            this.Text = "Lets Pwn";
            ((System.ComponentModel.ISupportInitialize)(this.picSpike)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstDeck;
        private System.Windows.Forms.ListBox lstUsed;
        private System.Windows.Forms.PictureBox picSpike;
        private System.Windows.Forms.Label lblDeck;
        private System.Windows.Forms.Label lblUsed;
        private System.Windows.Forms.Label lblDeckCount;
        private System.Windows.Forms.Label lblUsedCount;
        private System.Windows.Forms.Label lblNext;
        private System.Windows.Forms.Label lblLeast;
        private System.Windows.Forms.Label lblLastAction;
        private System.Windows.Forms.Label lbloutMostProbs;
        private System.Windows.Forms.Label lbloutLeastProbs;
        private System.Windows.Forms.Label lblOutLasttAction;
    }
}
namespace SpikeHelper
{
    partial class LetsPlay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LetsPlay));
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
            this.lblOutLasttAction = new System.Windows.Forms.Label();
            this.cmbNext = new System.Windows.Forms.ComboBox();
            this.cmbLeast = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnRestart = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSample = new System.Windows.Forms.ToolStripButton();
            this.tsbDraw1 = new System.Windows.Forms.ToolStripButton();
            this.tsbSideBoard = new System.Windows.Forms.ToolStripButton();
            this.tsbar = new System.Windows.Forms.ToolStripProgressBar();
            this.lblprompt = new System.Windows.Forms.Label();
            this.lbldeckName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picSpike)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstDeck
            // 
            this.lstDeck.FormattingEnabled = true;
            this.lstDeck.Location = new System.Drawing.Point(27, 81);
            this.lstDeck.Name = "lstDeck";
            this.lstDeck.Size = new System.Drawing.Size(255, 381);
            this.lstDeck.TabIndex = 0;
            this.lstDeck.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstDeck_MouseDoubleClick);
            // 
            // lstUsed
            // 
            this.lstUsed.FormattingEnabled = true;
            this.lstUsed.Location = new System.Drawing.Point(570, 81);
            this.lstUsed.Name = "lstUsed";
            this.lstUsed.Size = new System.Drawing.Size(255, 381);
            this.lstUsed.TabIndex = 1;
            this.lstUsed.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstUsed_MouseDoubleClick);
            // 
            // picSpike
            // 
            this.picSpike.Image = ((System.Drawing.Image)(resources.GetObject("picSpike.Image")));
            this.picSpike.Location = new System.Drawing.Point(305, 62);
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
            this.lblDeck.Location = new System.Drawing.Point(107, 42);
            this.lblDeck.Name = "lblDeck";
            this.lblDeck.Size = new System.Drawing.Size(50, 20);
            this.lblDeck.TabIndex = 3;
            this.lblDeck.Text = "Deck:";
            // 
            // lblUsed
            // 
            this.lblUsed.AutoSize = true;
            this.lblUsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsed.Location = new System.Drawing.Point(671, 42);
            this.lblUsed.Name = "lblUsed";
            this.lblUsed.Size = new System.Drawing.Size(51, 20);
            this.lblUsed.TabIndex = 4;
            this.lblUsed.Text = "Used:";
            // 
            // lblDeckCount
            // 
            this.lblDeckCount.AutoSize = true;
            this.lblDeckCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeckCount.Location = new System.Drawing.Point(67, 474);
            this.lblDeckCount.Name = "lblDeckCount";
            this.lblDeckCount.Size = new System.Drawing.Size(51, 20);
            this.lblDeckCount.TabIndex = 5;
            this.lblDeckCount.Text = "label3";
            // 
            // lblUsedCount
            // 
            this.lblUsedCount.AutoSize = true;
            this.lblUsedCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsedCount.Location = new System.Drawing.Point(617, 474);
            this.lblUsedCount.Name = "lblUsedCount";
            this.lblUsedCount.Size = new System.Drawing.Size(51, 20);
            this.lblUsedCount.TabIndex = 6;
            this.lblUsedCount.Text = "label4";
            // 
            // lblNext
            // 
            this.lblNext.AutoSize = true;
            this.lblNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNext.Location = new System.Drawing.Point(288, 282);
            this.lblNext.Name = "lblNext";
            this.lblNext.Size = new System.Drawing.Size(102, 13);
            this.lblNext.TabIndex = 7;
            this.lblNext.Text = "Probable Next Card:";
            // 
            // lblLeast
            // 
            this.lblLeast.AutoSize = true;
            this.lblLeast.Location = new System.Drawing.Point(288, 341);
            this.lblLeast.Name = "lblLeast";
            this.lblLeast.Size = new System.Drawing.Size(81, 13);
            this.lblLeast.TabIndex = 8;
            this.lblLeast.Text = "Least Probable:";
            // 
            // lblLastAction
            // 
            this.lblLastAction.AutoSize = true;
            this.lblLastAction.Location = new System.Drawing.Point(288, 384);
            this.lblLastAction.Name = "lblLastAction";
            this.lblLastAction.Size = new System.Drawing.Size(63, 13);
            this.lblLastAction.TabIndex = 9;
            this.lblLastAction.Text = "Last Action:";
            // 
            // lblOutLasttAction
            // 
            this.lblOutLasttAction.AutoSize = true;
            this.lblOutLasttAction.Location = new System.Drawing.Point(302, 397);
            this.lblOutLasttAction.Name = "lblOutLasttAction";
            this.lblOutLasttAction.Size = new System.Drawing.Size(32, 13);
            this.lblOutLasttAction.TabIndex = 12;
            this.lblOutLasttAction.Text = "xxxxx";
            // 
            // cmbNext
            // 
            this.cmbNext.FormattingEnabled = true;
            this.cmbNext.Location = new System.Drawing.Point(414, 308);
            this.cmbNext.Name = "cmbNext";
            this.cmbNext.Size = new System.Drawing.Size(121, 21);
            this.cmbNext.TabIndex = 13;
            // 
            // cmbLeast
            // 
            this.cmbLeast.FormattingEnabled = true;
            this.cmbLeast.Location = new System.Drawing.Point(414, 364);
            this.cmbLeast.Name = "cmbLeast";
            this.cmbLeast.Size = new System.Drawing.Size(121, 21);
            this.cmbLeast.TabIndex = 14;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnRestart,
            this.tsbtnSample,
            this.tsbDraw1,
            this.tsbSideBoard,
            this.tsbar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(843, 25);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnRestart
            // 
            this.tsbtnRestart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnRestart.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnRestart.Image")));
            this.tsbtnRestart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnRestart.Name = "tsbtnRestart";
            this.tsbtnRestart.Size = new System.Drawing.Size(23, 22);
            this.tsbtnRestart.Text = "restart";
            this.tsbtnRestart.Click += new System.EventHandler(this.tsbtnRestart_Click);
            // 
            // tsbtnSample
            // 
            this.tsbtnSample.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnSample.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSample.Image")));
            this.tsbtnSample.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSample.Name = "tsbtnSample";
            this.tsbtnSample.Size = new System.Drawing.Size(23, 22);
            this.tsbtnSample.Text = "Draw hand";
            this.tsbtnSample.Click += new System.EventHandler(this.tsbtnSample_Click);
            // 
            // tsbDraw1
            // 
            this.tsbDraw1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDraw1.Image = ((System.Drawing.Image)(resources.GetObject("tsbDraw1.Image")));
            this.tsbDraw1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDraw1.Name = "tsbDraw1";
            this.tsbDraw1.Size = new System.Drawing.Size(23, 22);
            this.tsbDraw1.Text = "Draw 1 random card";
            this.tsbDraw1.Click += new System.EventHandler(this.tsbDraw1_Click);
            // 
            // tsbSideBoard
            // 
            this.tsbSideBoard.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSideBoard.Image = ((System.Drawing.Image)(resources.GetObject("tsbSideBoard.Image")));
            this.tsbSideBoard.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSideBoard.Name = "tsbSideBoard";
            this.tsbSideBoard.Size = new System.Drawing.Size(23, 22);
            this.tsbSideBoard.Text = "SideBoard it!";
            this.tsbSideBoard.Click += new System.EventHandler(this.tsbSideBoard_Click);
            // 
            // tsbar
            // 
            this.tsbar.Name = "tsbar";
            this.tsbar.Size = new System.Drawing.Size(100, 22);
            // 
            // lblprompt
            // 
            this.lblprompt.AutoSize = true;
            this.lblprompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprompt.Location = new System.Drawing.Point(226, 34);
            this.lblprompt.Name = "lblprompt";
            this.lblprompt.Size = new System.Drawing.Size(233, 25);
            this.lblprompt.TabIndex = 16;
            this.lblprompt.Text = "You are Playing with....";
            // 
            // lbldeckName
            // 
            this.lbldeckName.AutoSize = true;
            this.lbldeckName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldeckName.Location = new System.Drawing.Point(362, 71);
            this.lbldeckName.Name = "lbldeckName";
            this.lbldeckName.Size = new System.Drawing.Size(84, 25);
            this.lbldeckName.TabIndex = 17;
            this.lbldeckName.Text = "??????";
            // 
            // LetsPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(843, 501);
            this.Controls.Add(this.lbldeckName);
            this.Controls.Add(this.lblprompt);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.cmbLeast);
            this.Controls.Add(this.cmbNext);
            this.Controls.Add(this.lblOutLasttAction);
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
            this.Name = "LetsPlay";
            this.Text = "Lets Pwn";
            ((System.ComponentModel.ISupportInitialize)(this.picSpike)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
        private System.Windows.Forms.Label lblOutLasttAction;
        private System.Windows.Forms.ComboBox cmbNext;
        private System.Windows.Forms.ComboBox cmbLeast;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnRestart;
        private System.Windows.Forms.ToolStripButton tsbtnSample;
        private System.Windows.Forms.ToolStripProgressBar tsbar;
        private System.Windows.Forms.ToolStripButton tsbDraw1;
        private System.Windows.Forms.Label lblprompt;
        private System.Windows.Forms.Label lbldeckName;
        private System.Windows.Forms.ToolStripButton tsbSideBoard;
    }
}
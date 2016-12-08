namespace SpikeHelper
{
    partial class Initial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Initial));
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnLetsPlay = new System.Windows.Forms.Button();
            this.btnBuild = new System.Windows.Forms.Button();
            this.picbox = new System.Windows.Forms.PictureBox();
            this.ofdLetsPlay = new System.Windows.Forms.OpenFileDialog();
            this.btnAbout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(13, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(175, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Welcome Spike";
            // 
            // btnLetsPlay
            // 
            this.btnLetsPlay.Location = new System.Drawing.Point(64, 57);
            this.btnLetsPlay.Name = "btnLetsPlay";
            this.btnLetsPlay.Size = new System.Drawing.Size(75, 23);
            this.btnLetsPlay.TabIndex = 1;
            this.btnLetsPlay.Text = "Lets Play";
            this.btnLetsPlay.UseVisualStyleBackColor = true;
            this.btnLetsPlay.Click += new System.EventHandler(this.btnLetsPlay_Click);
            // 
            // btnBuild
            // 
            this.btnBuild.Location = new System.Drawing.Point(64, 98);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(75, 23);
            this.btnBuild.TabIndex = 2;
            this.btnBuild.Text = "Build Deck";
            this.btnBuild.UseVisualStyleBackColor = true;
            this.btnBuild.Click += new System.EventHandler(this.btnBuild_Click);
            // 
            // picbox
            // 
            this.picbox.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picbox.ErrorImage")));
            this.picbox.Image = ((System.Drawing.Image)(resources.GetObject("picbox.Image")));
            this.picbox.ImageLocation = "C:\\Users\\NGU0313\\Documents\\Visual Studio 2013\\Projects\\SpikeHelper\\SpikeHelper\\th" +
    "eSpike.png";
            this.picbox.InitialImage = ((System.Drawing.Image)(resources.GetObject("picbox.InitialImage")));
            this.picbox.Location = new System.Drawing.Point(215, 13);
            this.picbox.Name = "picbox";
            this.picbox.Size = new System.Drawing.Size(250, 152);
            this.picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbox.TabIndex = 3;
            this.picbox.TabStop = false;
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(64, 138);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 23);
            this.btnAbout.TabIndex = 4;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Project By Philips Nguyen";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(381, 168);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(57, 13);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "To Github!";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Initial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(480, 186);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.picbox);
            this.Controls.Add(this.btnBuild);
            this.Controls.Add(this.btnLetsPlay);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Initial";
            this.Text = "Spike Helper vC#";
            ((System.ComponentModel.ISupportInitialize)(this.picbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnLetsPlay;
        private System.Windows.Forms.Button btnBuild;
        private System.Windows.Forms.PictureBox picbox;
        private System.Windows.Forms.OpenFileDialog ofdLetsPlay;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}


namespace SpikeHelper
{
    partial class SideBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SideBoard));
            this.lstSB = new System.Windows.Forms.ListBox();
            this.lblPromptCard = new System.Windows.Forms.Label();
            this.txtCard = new System.Windows.Forms.TextBox();
            this.lblSBSize = new System.Windows.Forms.Label();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnSBNotes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstSB
            // 
            this.lstSB.FormattingEnabled = true;
            this.lstSB.Location = new System.Drawing.Point(302, 12);
            this.lstSB.Name = "lstSB";
            this.lstSB.Size = new System.Drawing.Size(231, 394);
            this.lstSB.TabIndex = 0;
            this.lstSB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstSB_MouseClick);
            this.lstSB.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstSB_MouseDoubleClick);
            // 
            // lblPromptCard
            // 
            this.lblPromptCard.AutoSize = true;
            this.lblPromptCard.Location = new System.Drawing.Point(12, 137);
            this.lblPromptCard.Name = "lblPromptCard";
            this.lblPromptCard.Size = new System.Drawing.Size(109, 13);
            this.lblPromptCard.TabIndex = 1;
            this.lblPromptCard.Text = "Add SideBoard Card: ";
            // 
            // txtCard
            // 
            this.txtCard.Location = new System.Drawing.Point(138, 134);
            this.txtCard.Name = "txtCard";
            this.txtCard.Size = new System.Drawing.Size(100, 20);
            this.txtCard.TabIndex = 2;
            this.txtCard.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCard_KeyDown);
            // 
            // lblSBSize
            // 
            this.lblSBSize.AutoSize = true;
            this.lblSBSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSBSize.Location = new System.Drawing.Point(299, 409);
            this.lblSBSize.Name = "lblSBSize";
            this.lblSBSize.Size = new System.Drawing.Size(165, 16);
            this.lblSBSize.TabIndex = 3;
            this.lblSBSize.Text = "Total Cards in SideBoard: ";
            // 
            // btnDone
            // 
            this.btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.Location = new System.Drawing.Point(83, 249);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(101, 47);
            this.btnDone.TabIndex = 4;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnSBNotes
            // 
            this.btnSBNotes.Location = new System.Drawing.Point(83, 334);
            this.btnSBNotes.Name = "btnSBNotes";
            this.btnSBNotes.Size = new System.Drawing.Size(101, 45);
            this.btnSBNotes.TabIndex = 5;
            this.btnSBNotes.Text = "SB Notes";
            this.btnSBNotes.UseVisualStyleBackColor = true;
            this.btnSBNotes.Click += new System.EventHandler(this.btnSBNotes_Click);
            // 
            // SideBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(545, 459);
            this.Controls.Add(this.btnSBNotes);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.lblSBSize);
            this.Controls.Add(this.txtCard);
            this.Controls.Add(this.lblPromptCard);
            this.Controls.Add(this.lstSB);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SideBoard";
            this.Text = "SideBoard Builder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstSB;
        private System.Windows.Forms.Label lblPromptCard;
        private System.Windows.Forms.TextBox txtCard;
        private System.Windows.Forms.Label lblSBSize;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnSBNotes;
    }
}
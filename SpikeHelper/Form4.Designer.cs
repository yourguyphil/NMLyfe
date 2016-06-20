namespace SpikeHelper
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.lstStats = new System.Windows.Forms.ListBox();
            this.lblStatement = new System.Windows.Forms.Label();
            this.lblCardName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lstCustom = new System.Windows.Forms.ListBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstStats
            // 
            this.lstStats.FormattingEnabled = true;
            this.lstStats.Location = new System.Drawing.Point(291, 16);
            this.lstStats.Name = "lstStats";
            this.lstStats.Size = new System.Drawing.Size(224, 407);
            this.lstStats.TabIndex = 0;
            this.lstStats.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstStats_MouseDoubleClick);
            this.lstStats.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstStats_MouseDown);
            // 
            // lblStatement
            // 
            this.lblStatement.AutoSize = true;
            this.lblStatement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatement.Location = new System.Drawing.Point(12, 38);
            this.lblStatement.Name = "lblStatement";
            this.lblStatement.Size = new System.Drawing.Size(103, 20);
            this.lblStatement.TabIndex = 1;
            this.lblStatement.Text = "Probability of ";
            // 
            // lblCardName
            // 
            this.lblCardName.AutoSize = true;
            this.lblCardName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardName.Location = new System.Drawing.Point(119, 38);
            this.lblCardName.Name = "lblCardName";
            this.lblCardName.Size = new System.Drawing.Size(72, 20);
            this.lblCardName.TabIndex = 2;
            this.lblCardName.Text = "???????";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "in starting hand of.......";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.Location = new System.Drawing.Point(16, 98);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(42, 20);
            this.lbl5.TabIndex = 4;
            this.lbl5.Text = "Five:";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl6.Location = new System.Drawing.Point(16, 129);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(34, 20);
            this.lbl6.TabIndex = 5;
            this.lbl6.Text = "Six:";
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl7.Location = new System.Drawing.Point(16, 161);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(58, 20);
            this.lbl7.TabIndex = 6;
            this.lbl7.Text = "Seven:";
            // 
            // lstCustom
            // 
            this.lstCustom.FormattingEnabled = true;
            this.lstCustom.Location = new System.Drawing.Point(20, 262);
            this.lstCustom.Name = "lstCustom";
            this.lstCustom.Size = new System.Drawing.Size(211, 121);
            this.lstCustom.TabIndex = 7;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(33, 241);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(186, 18);
            this.lblInfo.TabIndex = 8;
            this.lblInfo.Text = "Custom Hyper Geometrics";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(156, 389);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 9;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "How many?";
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(74, 392);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(76, 20);
            this.txtnum.TabIndex = 11;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(536, 435);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lstCustom);
            this.Controls.Add(this.lbl7);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCardName);
            this.Controls.Add(this.lblStatement);
            this.Controls.Add(this.lstStats);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Text = "Stats at a Glance!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstStats;
        private System.Windows.Forms.Label lblStatement;
        private System.Windows.Forms.Label lblCardName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.ListBox lstCustom;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnum;
    }
}
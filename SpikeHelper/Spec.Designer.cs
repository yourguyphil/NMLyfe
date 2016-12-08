namespace SpikeHelper
{
    partial class Spec
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
            this.lstViewSpec = new System.Windows.Forms.ListView();
            this.lblSpecCard = new System.Windows.Forms.Label();
            this.lblCardName = new System.Windows.Forms.Label();
            this.lblPromptField = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInputSpec = new System.Windows.Forms.TextBox();
            this.txtSubSpec = new System.Windows.Forms.TextBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAddSpec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstViewSpec
            // 
            this.lstViewSpec.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lstViewSpec.Location = new System.Drawing.Point(276, 12);
            this.lstViewSpec.Name = "lstViewSpec";
            this.lstViewSpec.Size = new System.Drawing.Size(186, 316);
            this.lstViewSpec.TabIndex = 0;
            this.lstViewSpec.UseCompatibleStateImageBehavior = false;
            // 
            // lblSpecCard
            // 
            this.lblSpecCard.AutoSize = true;
            this.lblSpecCard.Location = new System.Drawing.Point(66, 12);
            this.lblSpecCard.Name = "lblSpecCard";
            this.lblSpecCard.Size = new System.Drawing.Size(131, 13);
            this.lblSpecCard.TabIndex = 1;
            this.lblSpecCard.Text = "Special Field Edit for Card:";
            // 
            // lblCardName
            // 
            this.lblCardName.AutoSize = true;
            this.lblCardName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardName.Location = new System.Drawing.Point(112, 25);
            this.lblCardName.Name = "lblCardName";
            this.lblCardName.Size = new System.Drawing.Size(0, 18);
            this.lblCardName.TabIndex = 2;
            // 
            // lblPromptField
            // 
            this.lblPromptField.AutoSize = true;
            this.lblPromptField.Location = new System.Drawing.Point(12, 67);
            this.lblPromptField.Name = "lblPromptField";
            this.lblPromptField.Size = new System.Drawing.Size(92, 13);
            this.lblPromptField.TabIndex = 3;
            this.lblPromptField.Text = "Add Special Field:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Add a Sub Special Field:";
            // 
            // txtInputSpec
            // 
            this.txtInputSpec.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtInputSpec.Location = new System.Drawing.Point(115, 67);
            this.txtInputSpec.Name = "txtInputSpec";
            this.txtInputSpec.Size = new System.Drawing.Size(100, 20);
            this.txtInputSpec.TabIndex = 5;
            this.txtInputSpec.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInputSpec_KeyDown);
            // 
            // txtSubSpec
            // 
            this.txtSubSpec.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtSubSpec.Location = new System.Drawing.Point(141, 133);
            this.txtSubSpec.Name = "txtSubSpec";
            this.txtSubSpec.Size = new System.Drawing.Size(100, 20);
            this.txtSubSpec.TabIndex = 6;
            this.txtSubSpec.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSubSpec_KeyDown);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(95, 242);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 7;
            this.btnDel.Text = "Delete All";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAddSpec
            // 
            this.btnAddSpec.Location = new System.Drawing.Point(69, 200);
            this.btnAddSpec.Name = "btnAddSpec";
            this.btnAddSpec.Size = new System.Drawing.Size(120, 23);
            this.btnAddSpec.TabIndex = 8;
            this.btnAddSpec.Text = "Add Specials";
            this.btnAddSpec.UseVisualStyleBackColor = true;
            this.btnAddSpec.Click += new System.EventHandler(this.btnAddSpec_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(474, 356);
            this.Controls.Add(this.btnAddSpec);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.txtSubSpec);
            this.Controls.Add(this.txtInputSpec);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPromptField);
            this.Controls.Add(this.lblCardName);
            this.Controls.Add(this.lblSpecCard);
            this.Controls.Add(this.lstViewSpec);
            this.Name = "Form7";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Specials";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstViewSpec;
        private System.Windows.Forms.Label lblSpecCard;
        private System.Windows.Forms.Label lblCardName;
        private System.Windows.Forms.Label lblPromptField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInputSpec;
        private System.Windows.Forms.TextBox txtSubSpec;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAddSpec;
    }
}
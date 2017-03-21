namespace Word_Reversal_Main_Project
{
    partial class WordReversal
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
            this.txtWordsOfSentancesToBeReversed = new System.Windows.Forms.TextBox();
            this.btnWordsToBeReversed = new System.Windows.Forms.Button();
            this.lblDisplayReversedSentence = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtWordsOfSentancesToBeReversed
            // 
            this.txtWordsOfSentancesToBeReversed.Location = new System.Drawing.Point(69, 63);
            this.txtWordsOfSentancesToBeReversed.Multiline = true;
            this.txtWordsOfSentancesToBeReversed.Name = "txtWordsOfSentancesToBeReversed";
            this.txtWordsOfSentancesToBeReversed.Size = new System.Drawing.Size(508, 98);
            this.txtWordsOfSentancesToBeReversed.TabIndex = 0;
            // 
            // btnWordsToBeReversed
            // 
            this.btnWordsToBeReversed.Location = new System.Drawing.Point(69, 168);
            this.btnWordsToBeReversed.Name = "btnWordsToBeReversed";
            this.btnWordsToBeReversed.Size = new System.Drawing.Size(110, 23);
            this.btnWordsToBeReversed.TabIndex = 1;
            this.btnWordsToBeReversed.Text = "Reverse the words";
            this.btnWordsToBeReversed.UseVisualStyleBackColor = true;
            this.btnWordsToBeReversed.Click += new System.EventHandler(this.btnWordsToBeReversed_Click);
            // 
            // lblDisplayReversedSentence
            // 
            this.lblDisplayReversedSentence.AutoSize = true;
            this.lblDisplayReversedSentence.Location = new System.Drawing.Point(69, 207);
            this.lblDisplayReversedSentence.Name = "lblDisplayReversedSentence";
            this.lblDisplayReversedSentence.Size = new System.Drawing.Size(0, 13);
            this.lblDisplayReversedSentence.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please Enter Sentence";
            // 
            // WordReversal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDisplayReversedSentence);
            this.Controls.Add(this.btnWordsToBeReversed);
            this.Controls.Add(this.txtWordsOfSentancesToBeReversed);
            this.Name = "WordReversal";
            this.Text = "Word Reversal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtWordsOfSentancesToBeReversed;
        private System.Windows.Forms.Button btnWordsToBeReversed;
        private System.Windows.Forms.Label lblDisplayReversedSentence;
        private System.Windows.Forms.Label label1;
    }
}


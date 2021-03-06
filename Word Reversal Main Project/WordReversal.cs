﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Word_Reversal_Main_Project
{
    public partial class WordReversal : Form
    {
        public WordReversal()
        {
            InitializeComponent();
        }

        private void btnWordsToBeReversed_Click(object sender, EventArgs e)
        {
            StringBuilder finalString = GetReversedString(txtWordsOfSentancesToBeReversed.Text.Split(' '));
            lblDisplayReversedSentence.Text = finalString.ToString();
        }

        private static StringBuilder GetReversedString(string[] words)
        {
            StringBuilder finalString = new StringBuilder();

            //only 1  object created using stringbuilder
            StringBuilder builder = new StringBuilder();

            foreach (var word in words)
            {
                if (builder.ToString().Length > 0)
                    builder.Remove(0, builder.ToString().Length);
                for (int charIndexOfword = word.Length - 1; charIndexOfword >= 0; charIndexOfword--)
                {
                    //does not create new object in memory as it is using stringbuilder which is mutable
                    builder.Append(word[charIndexOfword]);
                }
                //this is again stringbuilder object to avoid multiple copies of object creation in memory
                finalString.Append(builder.ToString() + " ");
            }

            return finalString;
        }
    }
}

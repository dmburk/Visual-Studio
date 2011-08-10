using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Debugging
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int LetterCount = 0;
            string strText = "Debugging";
            string letter;

            for (int i = 0; i < strText.Length; i++)
            {
                letter = strText.Substring(i, 1);

                if (letter == "g")
                {
                    LetterCount++;
                }
            }

            textBox1.Text = "g appears " + LetterCount + " times";
        }
    }
}

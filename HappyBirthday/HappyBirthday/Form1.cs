using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        HappyBirthday birthdayMessage = new HappyBirthday();

        private void button1_Click(object sender, EventArgs e)
        {
            //HappyBirthday birthdayMessage;
            //birthdayMessage = new HappyBirthday();
            // You can do the above in one line.
            // HappyBirthday birthdayMessage = new HappyBirthday();

            // MessageBox.Show(birthdayMessage.getMessage("Mike"));

            birthdayMessage.PresentCount = 5;
            birthdayMessage.MyProperty = "Mike";
            

            string returnedMessage;
            returnedMessage = birthdayMessage.MyProperty;
            MessageBox.Show(returnedMessage);
        }

        private void party_CheckedChanged(object sender, EventArgs e)
        {
            if (party.Checked)
            {
                birthdayMessage.HaveParty = true;
            }
            else
            {
                birthdayMessage.HaveParty = false;
            }
        }
    }
}

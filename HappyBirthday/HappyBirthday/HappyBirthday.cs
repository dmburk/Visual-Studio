using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class HappyBirthday
    {
        //===================
        //  CLASS VARIABLES
        //===================
        private int numberOfPresents;
        private string birthdayMessage;
        private bool havingParty;

        //=======================
        //  DEFAULT CONSTRUCTOR
        //=======================
        public HappyBirthday()
        {
            numberOfPresents = 0;
            havingParty = false;
        }


        //=========================
        //      METHOD
        //=========================
        private string getMessage(string givenName)
        {
            string theMessage;

            theMessage = "Happy Birthday " + givenName + "\n";
            theMessage += "Number of presents = " + numberOfPresents.ToString() + "\n";

            if (havingParty == true)
            {
                theMessage += "Hope you enjoy the party!";
            }
            else
            {
                theMessage += "No party = sorry!";
            }

            return theMessage;
        }


        //===============================
        //      READ AND WRITE PROPERTY
        //===============================
        public string MyProperty 
        { 
            get { return birthdayMessage; }

            set { birthdayMessage = getMessage(value); }
        }

        //============================
        //      WRITE-ONLY PROPERTIES
        //============================
        public int PresentCount
        {
            set { numberOfPresents = value; }
        }

        public bool HaveParty
        {
            set { havingParty = value; }
        }
    }
}

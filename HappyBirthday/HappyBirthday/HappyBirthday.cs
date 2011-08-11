using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class HappyBirthday
    {
        public HappyBirthday()
        {
            numberOfPresents = 0;
        }

        private string getMessage(string givenName)
        {
            string theMessage;

            theMessage = "Happy Birthday " + givenName + "\n";
            theMessage += "Number of presents =" + numberOfPresents.ToString();

            return theMessage;
        }

        private string birthdayMessage;
        public string MyProperty 
        { 
            get { return birthdayMessage; }
            set { birthdayMessage = getMessage(value); }
        }

        private int numberOfPresents;

        public int PresentCount
        {
            set { numberOfPresents = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string changeCase = Form1.tb.Text;

            if (rbtnLowerCase.Checked == true)
            {
                changeCase = changeCase.ToLower();
            }
            else if (rbtnUpperCase.Checked == true)
            {
                changeCase = changeCase.ToUpper();
            }
            else if (rbtnProperCase.Checked == true)
            {
                CultureInfo properCase = Thread.CurrentThread.CurrentCulture;
                TextInfo textInfoObject = properCase.TextInfo;

                changeCase = textInfoObject.ToTitleCase(changeCase);
            }

            Form1.tb.Text = changeCase;

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}

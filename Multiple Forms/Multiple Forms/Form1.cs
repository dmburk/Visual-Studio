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

        Form2 secondForm = new Form2();
        public static TextBox tb = new TextBox();

        private void btnFormTwo_Click(object sender, EventArgs e)
        {            
            secondForm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tb = txtChangeCase;
        }
    }
}

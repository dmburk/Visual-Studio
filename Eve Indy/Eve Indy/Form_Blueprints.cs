using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Eve_Indy
{
    public partial class Form_Blueprints : Form
    {
        public Form_Blueprints()
        {
            InitializeComponent();
        }

        Form_Materials materialsForm = new Form_Materials();

        private void btnMaterials_Click(object sender, EventArgs e)
        {
            materialsForm.ShowDialog();
        }

        private void Form_Blueprints_Load(object sender, EventArgs e)
        {

        }
    }
}

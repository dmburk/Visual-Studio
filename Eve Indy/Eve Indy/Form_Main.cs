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
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        // Setting up variables for SQL Connection, DataAdapter, and Dataset.
        System.Data.SqlClient.SqlConnection con;
        System.Data.SqlClient.SqlDataAdapter da;
        DataSet ds1;
        

        // Creates a new blueprints form object.
        Form_Blueprints blueprintsForm = new Form_Blueprints();
        frmPaM PaMform = new frmPaM();

        private void Form_Main_Load(object sender, EventArgs e)
        {
            // Create new instance of SQL Connection and Dataset.
            con = new System.Data.SqlClient.SqlConnection();
            ds1 = new DataSet();

            con.ConnectionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\EveIndy.mdf;Integrated Security=True;User Instance=True";

            // This won't be used. I am just setting this up to look back at as an
            // example later in the project.
            string sql = "SELECT * from tblBlueprints";
            da = new System.Data.SqlClient.SqlDataAdapter(sql, con);

            con.Open();

            da.Fill(ds1, "Blueprints");

            con.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            blueprintsForm.ShowDialog();
        }

        private void btnPM_Click(object sender, EventArgs e)
        {
            PaMform.ShowDialog();
        }

    }
}

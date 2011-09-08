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
    public partial class frmPaM : Form
    {
        public frmPaM()
        {
            InitializeComponent();
        }
        
        // Initialize variables for SQL Connection, DataAdapter, and Dataset.
        System.Data.SqlClient.SqlConnection conn;
        System.Data.SqlClient.SqlDataAdapter da;
        DataSet dsMaterials;

        Form_Materials materialsForm = new Form_Materials();

        private void frmPaM_Load(object sender, EventArgs e)
        {
            conn = new System.Data.SqlClient.SqlConnection();
            dsMaterials = new DataSet();

            // Set database connection string
            // Set sql query and load data into the data adapter.
            conn.ConnectionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\EveIndy.mdf;Integrated Security=True;User Instance=True";
            string sql = "SELECT * from tblMaterials";
            da = new System.Data.SqlClient.SqlDataAdapter(sql, conn);

            // Connect to database and fill the dataset with 
            // data from the data adapter.
            conn.Open();
            da.Fill(dsMaterials, "Materials");
            conn.Close();

            LoadMaterials();
        }

        private void LoadMaterials()
        {
            // Clear listbox
            lbMaterials.Items.Clear();
            // Load listbox with materials
            int matcount = MatCount();
            for (int i = 0; i != matcount; i++)
            {
                lbMaterials.Items.Add(dsMaterials.Tables["Materials"].Rows[i].ItemArray.GetValue(2).ToString());
            }
        }

        private int MatCount()
        {
            int numRows = dsMaterials.Tables["Materials"].Rows.Count;
            return numRows;
        }

        private void lbMaterials_SelectedIndexChanged(object sender, EventArgs e)
        {
            materialsForm.ShowDialog();
        }
    }
}

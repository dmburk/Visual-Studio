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
    public partial class Form_Materials : Form
    {
        public Form_Materials()
        {
            InitializeComponent();
        }

        // Initialize variables for SQL Connection, DataAdapter, and Dataset.
        System.Data.SqlClient.SqlConnection conn;
        System.Data.SqlClient.SqlDataAdapter da;
        DataSet ds1;
        int matid;

        private void Form_Materials_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eveIndyDataSet.tblMaterials' table. You can move, or remove it, as needed.
            this.tblMaterialsTableAdapter.Fill(this.eveIndyDataSet.tblMaterials);
            // Create new instance of SQL Connection and Dataset.
            conn = new System.Data.SqlClient.SqlConnection();
            ds1 = new DataSet();
            
            // Set database connection string
            // Set sql query and load data into the data adapter.
            conn.ConnectionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=|DataDirectory|\\EveIndy.mdf;Integrated Security=True;User Instance=True";
            string sql = "SELECT * from tblMaterials";
            da = new System.Data.SqlClient.SqlDataAdapter(sql, conn);

            // Connect to database and fill the dataset with 
            // data from the data adapter.
            conn.Open();
            da.Fill(ds1, "Materials");
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
                lbMaterials.Items.Add(ds1.Tables["Materials"].Rows[i].ItemArray.GetValue(2).ToString());
            }
        }

        private int MatCount()
        {
            int numRows = ds1.Tables["Materials"].Rows.Count;
            return numRows;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            tbName.Clear();
            tbCategory.Clear();            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Connection builder to reconnect to database.
            System.Data.SqlClient.SqlCommandBuilder cb;
            cb = new System.Data.SqlClient.SqlCommandBuilder(da);

            // Set a new datarow
            DataRow dRow = ds1.Tables["Materials"].NewRow();
            // Set data to the new row.
            dRow[2] = tbName.Text;
            dRow[1] = tbCategory.Text;
            // Add the datarow to the dataset.
            ds1.Tables["Materials"].Rows.Add(dRow);
            // Update database with dataset.
            da.Update(ds1, "Materials");

            MessageBox.Show("Entry Added");
            LoadMaterials();
        }

        private void lbMaterials_SelectedIndexChanged(object sender, EventArgs e)
        {
            int matcount = MatCount();
            for (int i = 0; i != matcount; i++)
            {
                if (lbMaterials.SelectedIndex == i)
                {
                    tbName.Text = ds1.Tables["Materials"].Rows[i].ItemArray.GetValue(2).ToString();
                    tbCategory.Text = ds1.Tables["Materials"].Rows[i].ItemArray.GetValue(1).ToString();
                    matid = Convert.ToInt32(ds1.Tables["Materials"].Rows[i].ItemArray.GetValue(0));
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlCommandBuilder cb;
            cb = new System.Data.SqlClient.SqlCommandBuilder(da);

            System.Data.DataRow dRow2 = ds1.Tables["Materials"].Rows[matid];
            

            dRow2[0] = matid;
            dRow2[1] = tbCategory.Text;
            dRow2[2] = tbName.Text;

            da.Update(ds1, "Materials");
            MessageBox.Show("Data Updated!");

            
        }
    }
}

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
        
        System.Data.SqlClient.SqlConnection con;
        DataSet ds1;
        System.Data.SqlClient.SqlDataAdapter da;

        int MaxRows = 0;
        int inc = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new System.Data.SqlClient.SqlConnection();
            ds1 = new DataSet();
            con.ConnectionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=C:\\Projects\\MyWorkers.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            
            con.Open();

            string sql = "SELECT * From tblWorkers";
            da = new System.Data.SqlClient.SqlDataAdapter(sql, con);
            da.Fill(ds1, "Workers");
            MaxRows = ds1.Tables["Workers"].Rows.Count;
            NavigateRecords();
            
            con.Close();

            //con.Dispose();
        }

        private void NavigateRecords()
        {
            DataRow dRow = ds1.Tables["Workers"].Rows[inc];

            textBox1.Text = dRow.ItemArray.GetValue(1).ToString();
            textBox2.Text = dRow.ItemArray.GetValue(2).ToString();
            textBox3.Text = dRow.ItemArray.GetValue(3).ToString();

            RecordViewer();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (inc != MaxRows - 1)
            {
                inc++;
                NavigateRecords();
            }
            else
            {
                MessageBox.Show("No more rows!");
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (inc > 0)
            {
                inc--;
                NavigateRecords();
            }
            else
            {
                MessageBox.Show("First record!");
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlCommandBuilder cb;
            cb = new System.Data.SqlClient.SqlCommandBuilder(da);

            DataRow dRow = ds1.Tables["Workers"].NewRow();

            dRow[1] = textBox1.Text;
            dRow[2] = textBox2.Text;
            dRow[3] = textBox3.Text;

            ds1.Tables["Workers"].Rows.Add(dRow);

            MaxRows = MaxRows + 1;
            inc = MaxRows - 1;

            da.Update(ds1, "Workers");

            NavigateRecords();

            MessageBox.Show("Entry Added!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlCommandBuilder cb;
            cb = new System.Data.SqlClient.SqlCommandBuilder(da);

            System.Data.DataRow dRow2 = ds1.Tables["Workers"].Rows[inc];

            dRow2[1] = textBox1.Text;
            dRow2[2] = textBox2.Text;
            dRow2[3] = textBox3.Text;

            da.Update(ds1, "Workers");

            MessageBox.Show("Data Updated!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            System.Data.SqlClient.SqlCommandBuilder cb;
            cb = new System.Data.SqlClient.SqlCommandBuilder(da);

            ds1.Tables["Workers"].Rows[inc].Delete();
            MaxRows--;
            inc = 0;
            NavigateRecords();

            da.Update(ds1, "Workers");

            MessageBox.Show("Record Deleted.");
        }

        private void RecordViewer()
        {
            int record = inc + 1;
            
            labRecordNumber.Text = "Record " + record.ToString() + " of " + MaxRows.ToString();
        }
    }
}

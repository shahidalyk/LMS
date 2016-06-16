using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Add_New_Books
{
    public partial class Search_book : Form
    {
        public Search_book()
        {
            InitializeComponent();
            txt_id2.Hide();
            label3.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 Main_menu = new Form2();
            Main_menu.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            String field = "sdsd";
            String query = "sdsd";
            if (comboBox1.Text == "Isbn")
            {
                txt_id2.Hide();
                label3.Hide();
                field = "Isbn";
                query = "Select * from Books where "+ field +" = " + txt_id.Text.ToString() + ";";
            }
            if (comboBox1.Text == "Book Title")
            {
                txt_id2.Hide();
                label3.Hide();
                field = "Book_title";
                query = "Select * from Books where " + field + " like '%" + txt_id.Text.ToString() + "%';";
            }
            if (comboBox1.Text == "Book Author")
            {
                txt_id2.Hide();
                label3.Hide();
                field = "Book_Author";
                query = "Select * from Books where " + field + " like '%" + txt_id.Text.ToString() + "%';";
            }

            if (comboBox1.Text == "Available Quantity")
            {
                field = "Available_qty";
                query = "Select * from Books where " + field + " = " + txt_id.Text.ToString() + ";";
            } 
            if (comboBox1.Text == "Price")
            {
                field = "Price";
                query = "Select * from Books where " + field + " = " + txt_id.Text.ToString() + ";";
            } 
               
            if (comboBox1.Text == "Edition")
            {
                field = "Edition";
                query = "Select * from Books where " + field + " = " + txt_id.Text.ToString() + ";";
            }
            if (comboBox1.Text == "Category") 
            {
                txt_id2.Hide();
                label3.Hide();
                field = "Category";
                query = "Select * from Books where " + field + " like '" + txt_id.Text.ToString() + "';";
            }
            
                
            
            
            OleDbConnection connection = new OleDbConnection();

            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            AppDomain.CurrentDomain.SetData("DataDirectory", path);
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|/LMS.accdb";
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(query , connection);
            connection.Open();
            da.Fill(dt);
            
           // sql = ("Select * from Books where Book_ID like "+txt_id.Text,connection);
            //da = new OleDbDataAdapter(sql, connection);
            //da.Fill(ds, "Admin records");
            dataGridView1.DataSource = dt;
            
            connection.Close();

        }

        private void Search_book_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}

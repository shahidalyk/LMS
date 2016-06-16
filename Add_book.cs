using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
//using System.Data.OleDb;

namespace Add_New_Books
{
    public partial class Add_book : Form
    {
      

        public Add_book()
        {
            
            InitializeComponent();
        }

        public void Insert(string query)
        {

             OleDbConnection connection = new OleDbConnection();
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            AppDomain.CurrentDomain.SetData("DataDirectory", path);
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|/LMS.accdb";
        OleDbCommand command;

            command = connection.CreateCommand();
            try
            {
                command.CommandText = query;
                command.CommandType = CommandType.Text;
                connection.Open();
                //SqlCommand comm = new SqlCommand(query, connection);

                command.ExecuteNonQuery();

            }
            catch (Exception)
            {
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 Main_menu = new Form2();
            Main_menu.Show();
        }

        private void Add_book_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String query = "insert into Books (Isbn,Book_title,Book_author,Edition,Category,Available_qty,Price,Issued_status) values(" + txtIsbn.Text + ",'" + txtTitle.Text + "','" + txtAuthor.Text + "'," + txtEdition.Text + ",'" + txtCategory.Text + "'," + txtAvailableQty.Text + "," + txtPrice.Text + ",1);";
            Insert(query);

            this.Hide();
            Form2 Main_menu = new Form2();
            Main_menu.Show();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

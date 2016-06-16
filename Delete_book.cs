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
    public partial class Delete_book : Form
    {
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/Majid Ali/Desktop/LMS.accdb");
        OleDbCommand command;
        

        public Delete_book()
        {
            InitializeComponent();
            label.Hide();
            
            textBox.Hide();
           
        }
        public void Delete(string query)
        {
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

        private void Delete_book_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Members")
            {

                label.Show();

                label.Text = "Enter Member ID :";

                textBox.Show();

            }

            if (comboBox1.Text == "Books")
            {
                label.Show();

                label.Text = "Enter Book Isbn :";

                textBox.Show();
                

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Members")
            {
                String query = "Delete from Members where Member_ID = 'LIBMEM"+ textBox.Text +"';";
                Delete(query);

                this.Hide();
                Form2 Main_menu = new Form2();
                Main_menu.Show();

            }

            if (comboBox1.Text == "Books")
            {
                String query = "Delete from Books where Isbn = "+ textBox.Text +";";
                Delete(query);

                this.Hide();
                Form2 Main_menu = new Form2();
                Main_menu.Show();

            }
            

            
        }
    }
}
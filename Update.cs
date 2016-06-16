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

namespace Add_New_Books
{
    public partial class Update : Form
    {
        
        

        public Update()
        {
            InitializeComponent();

            label2.Hide();
            comboBox2.Hide();

            label3.Hide();
            textBox1.Hide();


        }

        public void update(string query)
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Books") {
                label2.Show();
                comboBox2.Show();

                label3.Show();
                textBox1.Show();

                comboBox2.Items[0] = "Book ID";
                comboBox2.Items[1] = "Book Name";
                comboBox2.Items[2] = "Book Author";
                comboBox2.Items[3] = "ISBN";
                comboBox2.Items[4] = "Available Quantity";
                comboBox2.Items[5] = "Price";
                comboBox2.Items[6] = "Edition";
                comboBox2.Items[7] = "Category";
            
            }

            if(comboBox1.Text == "Members"){
                
                label2.Show();
                comboBox2.Show();

                label3.Show();
                textBox1.Show();

                //comboBox2.Items = {"Member ID","Member Name","City","Contact Number","Join Date","Email"};
                comboBox2.Items[0] = "Member ID";
                comboBox2.Items[1] = "Member Name";
                comboBox2.Items[2] = "City";
                comboBox2.Items[3] = "Contact Number";
                comboBox2.Items[4] = "Join Date";
                comboBox2.Items[5] = "Email";
            }
        }

        private void Update_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String field = "sdsd";
            if ( comboBox2.Text == "Book ID")
                field = "Book_ID";
            if ( comboBox2.Text == "Book Name")
                field = "Book_title";
            if ( comboBox2.Text == "Book Author")
                field = "Book_Author";
            if ( comboBox2.Text == "ISBN")
                field = "ISBN";
            if ( comboBox2.Text == "Available Quantity")
                field = "Available_qty";
            if ( comboBox2.Text == "Price")
                field = "Price";
            if ( comboBox2.Text == "Edition")
                field = "Edition";
            if (comboBox2.Text == "Category")
                field = "Category";
            if (comboBox2.Text == "Member ID")
                field = "member_id";
            if (comboBox2.Text == "Member Name")
                field = "m_name";
            if (comboBox2.Text == "City")
                field = "city";
            if (comboBox2.Text == "Contact Number")
                field = "contact_no";
            if (comboBox2.Text == "Join Date")
                field = "join_date";
            if (comboBox2.Text == "Email")
                field = "email";
            
            if (comboBox1.Text == "Members") {
                string query = "update member set "+ field +" = '"+ textBox1.Text +"' where book_ID = "+ textBox2.Text +";";
                update(query);
            }
            
            if (comboBox1.Text == "Books") {
                string query = "update Books set " + field + " = '" + textBox1.Text + "' where book_ID = " + textBox2.Text + ";";
                //string query = "update Books set Book_title='jsdnjsdnsjnd' where Book_ID = 101;";
                update(query);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 Main_menu = new Form2();
            Main_menu.Show();
        }
    }
}

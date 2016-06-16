using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
//using System;
using System.Data.SqlClient;

namespace Add_New_Books
{
    public partial class Add_member : Form
    {
       

        
        
        public Add_member()
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
            finally {
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



        private void button2_Click(object sender, EventArgs e)
        {
            /*DateTime datenow = new DateTime();
            datenow = DateTime.Today;
            string date = datenow.ToString();
            MessageBox.Show(date);*/
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            MessageBox.Show(dateTimePicker1.Text);
            //string query = "insert into Members (Member_ID,Member_name,City,Contact_no,Join_date,Email) values('LIB-MEM-" + txtID.Text + "','" + txtName.Text + "','" + txtAddress.Text + "','" + txtContact.Text + "',TOCHAR(SYSDATE),'" + txtEmail.Text + "');";
            String query = "insert into Members (Member_ID,Member_name,City,Contact_no,Join_date,Email) values('LIBMEM" + txtID.Text + "','" + txtName.Text + "','" + txtAddress.Text + "','" + txtContact.Text + "','"+ dateTimePicker1.Text +"','" + txtEmail.Text + "');";
            Insert(query);

            this.Hide();
            Form2 Main_menu = new Form2();
            Main_menu.Show();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_member_Load(object sender, EventArgs e)
        {

        }

    }
}
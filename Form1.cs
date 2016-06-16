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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            DataSet ds = new DataSet();
            OleDbDataAdapter da;
            String sql;
            OleDbConnection connection = new OleDbConnection();
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            AppDomain.CurrentDomain.SetData("DataDirectory", path);
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|/LMS.accdb";

            connection.Open();

            sql = "Select * from Admin;";
            da = new OleDbDataAdapter(sql,connection);
            
            //MessageBox.Show("DATABASE IS NOW OPEN");

            da.Fill(ds, "Admin records");

            //textBox1.Text = (String)ds.Tables["Student records"].Rows[0]["Reg#"];

            if ((textBox1.Text == (String)ds.Tables["Admin records"].Rows[0]["username"]
                &&
                textBox2.Text == (String)ds.Tables["Admin records"].Rows[0]["password"])
                ||
                (textBox1.Text == (String)ds.Tables["Admin records"].Rows[1]["username"]
                &&
                textBox2.Text == (String)ds.Tables["Admin records"].Rows[1]["password"])
                ||
                (textBox1.Text == (String)ds.Tables["Admin records"].Rows[2]["username"]
                &&
                textBox2.Text == (String)ds.Tables["Admin records"].Rows[2]["password"])
                ||
                (textBox1.Text == (String)ds.Tables["Admin records"].Rows[3]["username"]
                &&
                textBox2.Text == (String)ds.Tables["Admin records"].Rows[3]["password"])
                )
            {
                MessageBox.Show("Access Granted");
                this.Hide();
                Form2 main_menu = new Form2();
                main_menu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Access Denied");
            }





            connection.Close();

            //MessageBox.Show("DATABASE IS NOW CLOSE");
             


        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

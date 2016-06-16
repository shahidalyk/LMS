using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Add_New_Books
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Add_member form_Add_member = new Add_member();
            form_Add_member.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Add_book form_Add_book = new Add_book();
            form_Add_book.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Search_book form_Search_book = new Search_book();
            form_Search_book.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Delete_book form_Delete_book = new Delete_book();
            form_Delete_book.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Update form_Update = new Update();
            form_Update.Show();
        }
    }
}

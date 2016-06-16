using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Add_New_Books{

    public class Student
    {
        private int reg_no;
        private string s_name;
        private int dept;
        private string address;
        private int contact_no;

            public int Reg {
                get { return reg_no; }
                set { reg_no = value; }
            }

            public string Name {
                get { return s_name; }
                set { s_name = value; }
            }
            
            public int Dept {
                get { return dept; }
                set { dept = value;}
            }
            public string Address {
                get { return address;}
                set { address = value;}
            }
            public int Contact{
                get { return contact_no;}
                set { contact_no = value;}
            }
    }


    public class Books {
        int book_id;
        string book_title;
        string book_author;
        int isbn;
        int edition;
        string category;
        int available_qty;
        int price;

        public int Book_id{
            get { return book_id;}
            set { book_id = value; }
        }
        public string Title{
            get { return book_title;}
            set { book_title = value; }
        }
        public string Author{
            get { return book_author;}
            set { book_author = value; }
        }
        public int Isbn{
            get { return isbn;}
            set { isbn = value; }
        }
        public int Edition{
            get { return edition;}
            set { edition = value;}
        }
        public string Category{
            get { return category;}
            set { category = value; }
        }
        public int Available_qty
        {
            get { return available_qty; }
            set { available_qty = value; }
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }

    }

    public class Admin{
        string username;
        string password;

        public string Username {
            get { return username; }
            set { username = value; }
        }
        public string Password {
            get { return password; }
            set { password = value; }
        }
    }

    //public class Update
    
        //string 
        /*
        public void add_member(Student s)
        {
        try
        {
        command.CommandText="INSERT INTO Student (reg_no,S_name,Address,contact_no) VALUES('"+ s.Reg +"','"+s.Name+"','"+s.Address+"','"s.Contact"')";
        }
        catch(Exception)
        {
        throw;
        }
        }//add_member ends
        */
   
}//namespace ends

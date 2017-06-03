using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PhoneBook
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection("Data Source=DESKTOP-58TQHKQ;Initial Catalog=phonebook;Integrated Security=True");

        public void logincheck()
        {
            try
            {
                connect.Open();
            }
            catch(SqlException T)
            {
                MessageBox.Show("Error in establishing connection with database. + " T.Message);
            }
            
            SqlCommand commander = new SqlCommand("SELECT * FROM table_login WHERE username='@username' and password='@password'", connect);

            commander.Parameters.AddWithValue("@username", txt_username.Text);
            commander.Parameters.AddWithValue("@passowrd", txt_password.Text);

            SqlDataReader reader = commander.ExecuteReader();

            string username = null;
            string password = null;


            if (reader.HasRows)
            {
                while (reader.Read ())
                {
                    username = reader["username"].ToString();
                    password = reader["password"].ToString();
                }

                connect.Close();
                this.Hide();

                Form1 frm = new Form1();
                frm.Show();


             } else
            {
                MessageBox.Show("login failed");
                this.Show();
                Form1 frm = new Form1();
                frm.Hide();

            }
            connect.Close();

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            logincheck();
        }
    }
}

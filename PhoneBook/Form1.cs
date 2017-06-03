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
        public partial class Form1 : Form
        {
            public Form1()
            {
                InitializeComponent();
            }
            try 
            {	             
                SqlConnection connect = new SqlConnection("Data Source=DESKTOP-58TQHKQ;Initial Catalog=phonebook;Integrated Security=True; MultipleActiveResultSets=True");  
            
            }
            catch (SqlException  T)
            {
                MessageBox.Show("Error in establishing connection to database. " + T.Message);
            }   
            

            
            public void necessary_ending_dbactions()
            {
                connect.Close();
                listviewdatabase.Items.Clear();
                txt_id.Text = "";
                txt_name.Text = "";
                txt_surname.Text = "";
                txt_phonenumber.Text = "";
                database_display();
            }

            public void database_display()
            {
                connect.Open();
                listviewdatabase.Items.Clear();

               try
               {
                    using (SqlCommand db_displayer = new SqlCommand("SELECT *FROM phone_table", connect))
                {
                    
                    SqlDataReader reader = db_displayer.ExecuteReader();

                    var items = new List<ListViewItem>();

                    while (reader.Read())
                    {
                        ListViewItem adder = new ListViewItem(reader["id"].ToString());
                        adder.SubItems.Add(reader["name"].ToString());
                        adder.SubItems.Add(reader["surname"].ToString());
                        adder.SubItems.Add(reader["phonenumber"].ToString());
                        items.Add(adder);
                    }

                    listviewdatabase.Items.AddRange(items.ToArray());
                    
                }
                connect.Close();
               }
               catch(SqlException Y)
               {
                   MessageBox.Show("Something went wrong there is an error in displaying data. " + Y.Message);

               }
                                    
            }

            public void database_save()
            {
                try
                {
                    using (SqlCommand db_saver = new SqlCommand("INSERT INTO phone_table (id,name,surname,phonenumber) values (@id,@name,@surname,@phonenumber)", connect))
                {
                    connect.Open();
                    
                    db_saver.Parameters.AddWithValue("@id", txt_id.Text);
                    db_saver.Parameters.AddWithValue("@name", txt_name.Text);
                    db_saver.Parameters.AddWithValue("@surname", txt_surname.Text);
                    db_saver.Parameters.AddWithValue("@phonenumber", txt_phonenumber.Text);
                    db_saver.ExecuteNonQuery();
                }
                connect.Close();
                necessary_ending_dbactions();
                }
                catch(SqlException H)
                {
                    MessageBox.Show("Something went wrong. And we cant save the data. " + H.Message)
                }
            }

            public void database_update()
            {
                

                String query = "UPDATE phone_table SET id=@id, name=@name, surname=@surname, phonenumber=@phonenumber WHERE id=@id";
                
                try
                {
                    using (SqlCommand db_updater = new SqlCommand(query, connect))
                {
                    db_updater.Parameters.Clear();

                    db_updater.Parameters.AddWithValue("@id",txt_id.Text);
                    db_updater.Parameters.AddWithValue("@name", txt_name.Text);
                    db_updater.Parameters.AddWithValue("@surname", txt_surname.Text);
                    db_updater.Parameters.AddWithValue("@phonenumber",txt_phonenumber.Text);

                    connect.Open();

                    db_updater.ExecuteNonQuery();                
                }           
                necessary_ending_dbactions();
                }
                catch(SqlException T)
                {
                    MessageBox.Show("Something went wrong. We cant update the data. " + T.Message)
                }
            }

            public void database_delete()
            {
                connect.Open();
                try
                {
                using (SqlCommand eraser = new SqlCommand("DELETE FROM phone_table WHERE id=@id and name=@name and surname=@surname and phonenumber=@phonenumber",connect))
                {
                    eraser.Parameters.AddWithValue("@id", txt_id.Text);
                    eraser.Parameters.AddWithValue("@name", txt_name.Text);
                    eraser.Parameters.AddWithValue("@surname", txt_surname.Text);
                    eraser.Parameters.AddWithValue("@phonenumber", txt_phonenumber.Text);
                    eraser.ExecuteNonQuery();
                
                }
                necessary_ending_dbactions();
                }
                catch(SqlException K)
                {
                    MessageBox.Show("Something went wrong. We cant delete the data. " + K.Message);
                }

            }

            private void button_display_Click(object sender, EventArgs e)
            {
                database_display();
            }

            private void button_save_Click(object sender, EventArgs e)
            {
                database_save();
            }

            private void listviewdatabase_MouseClick(object sender, MouseEventArgs e)
            {
                txt_id.Text = listviewdatabase.SelectedItems[0].SubItems[0].Text;
                txt_name.Text = listviewdatabase.SelectedItems[0].SubItems[1].Text;
                txt_surname.Text = listviewdatabase.SelectedItems[0].SubItems[2].Text;
                txt_phonenumber.Text = listviewdatabase.SelectedItems[0].SubItems[3].Text;
            }

            private void button_update_Click(object sender, EventArgs e)
            {
                database_update();
            }

            private void button_delete_Click(object sender, EventArgs e)
            {
                database_delete();
            }
        }
    }

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Venue_management__last_time_
{
    public partial class Form8 : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;user id=duniyascam;database=venuemanagement;password=Wasd1109");
        public Form8()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 frm9 = new Form9();
            frm9.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            conn.Open();
            DataTable dt = new DataTable();
            MySqlDataReader dr;
            MySqlCommand comm = new MySqlCommand("Select * from owner_login where username='" + textBox1.Text + "'and password='" + textBox2.Text + "'", conn);
            MySqlCommand comm2 = new MySqlCommand("Insert into get_owner_username(username) values('" + textBox1.Text + "');", conn);
            dr = comm.ExecuteReader();

            if (dr.Read())
            {

                this.Hide();
                Form6 frm6 = new Form6();
                frm6.Show();
            }
            else
            {
                if (username.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Your Username!");
                }
                else if (password.Trim().Equals(""))
                {
                    MessageBox.Show("Enter your Password!");
                }
                else
                {
                    MessageBox.Show("Incorrect Password or username!");
                }
            }
            conn.Close();
            conn.Open();
            comm2.ExecuteNonQuery();
            conn.Close();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }
    }
}

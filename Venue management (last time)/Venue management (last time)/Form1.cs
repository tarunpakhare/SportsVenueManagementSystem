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
    public partial class Form1 : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;user id=duniyascam;database=venuemanagement;password=Wasd1109");
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
            //this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            conn.Open();
            DataTable dt = new DataTable();
            MySqlDataReader dr;
            MySqlCommand comm = new MySqlCommand("Select * from login where username='" + textBox1.Text + "'and password='"+textBox2.Text + "'", conn);
            MySqlCommand comm2 = new MySqlCommand("Insert into get_username(username) values('" + textBox1.Text + "');",conn);
            //comm.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;
            //comm.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password;
            dr = comm.ExecuteReader();
            
            if (dr.Read())
            {
               
                this.Hide();
                Form3 frm3 = new Form3();
                frm3.Show();
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Enter Username";
            
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(textBox1.Text=="Enter Username" )
            {
                textBox1.Text = "";
                

            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 frm8 = new Form8();
            frm8.Show();
        }
    }
}

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
    public partial class Form9 : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;user id=duniyascam;database=venuemanagement;password=Wasd1109");
        public Form9()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 frm8 = new Form8();
            frm8.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ins_val = "insert into owner_signup values ('" + textBox3.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + maskedTextBox1.Text + "','" + textBox5.Text + "');";
            string ins_login = "insert into owner_login values('" + textBox3.Text + "','" + textBox5.Text + "');";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand (ins_val, conn);
            MySqlCommand cmd2 = new MySqlCommand(ins_login, conn);
            if (textBox5.Text.Equals(textBox6.Text))
            {
                if (cmd.ExecuteNonQuery() == 1 && cmd2.ExecuteNonQuery() == 1)
                {
                    
                    MessageBox.Show("Your Account has been created.");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                    maskedTextBox1.Clear();

                }
                else
                {
                    MessageBox.Show("Error in inserting");
                }
            }
            else
            {
                MessageBox.Show("Passwords don't match.");
            }
            conn.Close();
        }
    }
}

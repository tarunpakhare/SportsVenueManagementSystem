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
    public partial class Form6 : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;user id=duniyascam;database=venuemanagement;password=Wasd1109");
        public Form6()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("insert into venue_name(ven_name,city_id) values('"  + textBox3.Text + "','" + textBox1.Text + "');",conn);
            conn.Open();
            if (cmd.ExecuteNonQuery()==1)
            {
                MessageBox.Show("Added Successfully!");
            }
            else
            {
                MessageBox.Show("Error!");
            }
            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 frm7 = new Form7();
            frm7.Show();
        }
    }
}

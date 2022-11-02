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
    public partial class Form5 : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;user id=duniyascam;database=venuemanagement;password=Wasd1109");
        public Form5()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 frm3 = new Form3();
            frm3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 frm4 = new Form4();
            frm4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to Signout?", "SignOut Box", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                this.Hide();
                Form1 frm1 = new Form1();
                frm1.Show();
            }
            else if (dialog == DialogResult.No)
            {
                this.Show();
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("Select username from disp_username;",conn);
            conn.Open();
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                label2.Text = dr.GetValue(0).ToString();
            }
            else
            {
                MessageBox.Show("Error!");
            }
            conn.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to Signout?", "SignOut Box", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                this.Hide();
                Form1 frm1 = new Form1();
                frm1.Show();
            }
            else if (dialog == DialogResult.No)
            {
                this.Show();
            }
        }
    }
}

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
    public partial class Form4 : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;user id=duniyascam;database=venuemanagement;password=Wasd1109");
        public Form4()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            MySqlDataAdapter da = new MySqlDataAdapter("Select venue,book_date,timing from venuemanagement.my_bookings",conn);
            conn.Open();
            DataSet ds = new DataSet();
            da.Fill(ds,"my_bookings");
            dataGridView1.DataSource = ds.Tables["my_bookings"];
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 frm3 = new Form3();
            frm3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 frm5 = new Form5();
            frm5.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

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
//using System.Web.UI;

namespace Venue_management__last_time_
{
    public partial class Form3 : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost;user id=duniyascam;database=venuemanagement;password=Wasd1109");
        public void bind_City()
       {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("Select city,city_id from venue_city", conn);
            
            MySqlDataReader dr = cmd.ExecuteReader();
            comboBox1.DisplayMember = "city";
            comboBox1.ValueMember = "city_id";
            while (dr.Read())
            {
                comboBox1.Items.Add(dr.GetString("city"));
            }
            conn.Close();
         //    conn.Open();
         //    dr = cmd.ExecuteReader();
         //    comboBox1.DataSource = dr;
         //    comboBox1.Items.Clear();
         //    comboBox1.Items.Add("--Please Select City--");
            //comboBox1.
            
            

        }
        public void bind_Venue()
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("Select distinct venue_id,ven_name from venue_name "  , conn);
            
                
               // MySqlCommand cmd = new MySqlCommand("Select distinct venue_id,ven_name from venue_name where city_id='101'");
            MySqlDataReader dr1 = cmd.ExecuteReader();
            comboBox2.Items.Clear();
            while (dr1.Read())
            {
                comboBox2.Items.Add(dr1.GetString("ven_name"));
            }

                
            
            conn.Close();
        }


            public Form3()
        {
            InitializeComponent();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            bind_City();
            
            comboBox3.Items.Add("Cricket");
            comboBox3.Items.Add("Badminton");
            comboBox3.Items.Add("Football");

            comboBox4.Items.Add("6am-7am");
            comboBox4.Items.Add("7am-8am");
            comboBox4.Items.Add("8am-9am");
            comboBox4.Items.Add("9am-10am");
            comboBox4.Items.Add("10am-11am");
            comboBox4.Items.Add("11am-12pm");
            comboBox4.Items.Add("12pm-1pm");
            comboBox4.Items.Add("1pm-2pm");
            comboBox4.Items.Add("2pm-3pm");
            comboBox4.Items.Add("3pm-4pm");
            comboBox4.Items.Add("4pm-5pm");
            comboBox4.Items.Add("5pm-6pm");
            comboBox4.Items.Add("6pm-7pm");
            comboBox4.Items.Add("7pm-8pm");
            comboBox4.Items.Add("8pm-9pm");
            comboBox4.Items.Add("9pm-10pm");


        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 frm5 = new Form5();
            frm5.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bind_Venue();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 frm4 = new Form4();
            frm4.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ins_values = "insert into bookings(city,venue,sport,book_date,timing) values ('" + comboBox1.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "','" + dateTimePicker1.Text + "','" + comboBox4.Text + "'); ";
            conn.Open();
            //string datet = dateTimePicker1.Text;
            //string time = comboBox1.Text;
            //DataTable dt = new DataTable();
            //MySqlDataReader dr;
            MySqlCommand cmd = new MySqlCommand(ins_values, conn);
            //MySqlCommand cmd2 = new MySqlCommand("Select book_date,timing from bookings where book_date='" + dateTimePicker1.Text + "'and timing='" + comboBox4.Text + "'", conn);

            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Booking Confirmed");
            }
            else
            {
                MessageBox.Show("Booking Error");
            }
            conn.Close();
            

        }

        private void button6_Click(object sender, EventArgs e)
        {
            conn.Open();
            MySqlCommand cmd2 = new MySqlCommand("Select book_date,timing from bookings where book_date='" + dateTimePicker1.Text + "'and timing='" + comboBox4.Text + "'", conn);
            MySqlDataReader dr;
            dr = cmd2.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Already Booked! Please choose a different timing");
            }
            else
            {
                MessageBox.Show("Available!");
            }
            conn.Close();
        }
    }
}

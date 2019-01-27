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

namespace CalculationOfCaloriSystem
{
    public partial class CaloriCalculator : Form
    {
        public CaloriCalculator()
        {
            InitializeComponent();
            //SqlConnection con = new SqlConnection("server=LAPTOP-IHFVGFKG\\SQL_2014;Database=Kalori;Integrated Security=True");
            //con.Open();
            //SqlCommand cmd = new SqlCommand("Select ID from Login" + "(ID) values (@ID)", con);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection("server=LAPTOP-IHFVGFKG\\SQL_2014;Database=Kalori;Integrated Security=True");

            //con.Open();
            //SqlCommand cmd = new SqlCommand("insert into Tablo" + "(VKI) values (@VKI)", con);

            decimal a = numericUpDown1.Value;
            decimal b = numericUpDown2.Value;
            decimal c = 0;


            if (a == 0)
            {
                MessageBox.Show("boy veya kilo 0 olamaz");

            }
            if (b == 0)
            { MessageBox.Show("boy veya kilo 0 olamaz"); }

            else

                c = (a * a);
            c = b / c;
            //cmd.Parameters.AddWithValue("@VKI", c);
            //cmd.ExecuteNonQuery();

            MessageBox.Show("Vücut Kitle İndeksi " + c);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection("server=LAPTOP-IHFVGFKG\\SQL_2014;Database=Kalori;Integrated Security=True");

            //con.Open();
            //SqlCommand cmd = new SqlCommand("insert into Tablo" + "(BMH) values (@BMH)", con);
            decimal a = numericUpDown1.Value;
            decimal b = numericUpDown2.Value;
            decimal c = 0;
            decimal d = numericUpDown3.Value;

            if (a == 0)
            { MessageBox.Show("boy veya kilo 0 olamaz"); }
            if (b == 0)
            { MessageBox.Show("boy veya kilo 0 olamaz"); }

            else
                //  if(comboBox1.Text=="Bay")
                if (comboBox1.Text == "Bay")
            {
                c = 660 + (138 * b / 10) + (500 * a) - (68 * d / 10);
                MessageBox.Show("Bazal Metabolizma Hızı: " + c);
                //cmd.Parameters.AddWithValue("@BMH", c);
                //cmd.ExecuteNonQuery();
            }
            else if (comboBox1.Text == "Bayan")
            {
                c = 655 + (96 * b / 10) + (180 * a) - (47 * d / 10);
                MessageBox.Show("Bazal Metabolizma Hızı: " + c);
                //cmd.Parameters.AddWithValue("@BMH", c);
                //cmd.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Cinsiyet Boş Olamaz");

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            

            decimal a = numericUpDown1.Value;
            decimal b = numericUpDown2.Value;
            decimal c = 0;
            decimal d = numericUpDown3.Value;
            //  decimal g;





            if (a <= 0)
            {
                MessageBox.Show("boy veya kilo 0 olamaz");
            }
            if (b <= 0)
            { MessageBox.Show("boy veya kilo 0 olamaz"); }

            else

                if (comboBox1.Text == "Bay")
            {
                if (comboBox2.Text == "Az")
                {
                    //   g = 1375 / 1000;
                    c = 660 + (138 * b / 10) + (500 * a) - (68 * d / 10);
                    c = c * 1375 / 1000;
                    MessageBox.Show("Günlük Kalori İhtiyacı: " + c);
                    // cmd.Parameters.AddWithValue("@GKI", c);
                    // cmd.ExecuteNonQuery();

                }

                else if (comboBox2.Text == "Orta")
                {
                    //  g= 1500 / 1000;
                    c = 660 + (138 * b / 10) + (500 * a) - (68 * d / 10);
                    c = c * 1500 / 1000;
                    MessageBox.Show("Günlük Kalori İhtiyacı: " + c);
                    // cmd.Parameters.AddWithValue("@GKI", c);
                    // cmd.ExecuteNonQuery();

                }

                else if (comboBox2.Text == "Çok")
                {
                    // g = 1700 / 1000;
                    c = 660 + (138 * b / 10) + (500 * a) - (68 * d / 10);
                    c = c * 1700 / 1000;
                    MessageBox.Show("Günlük Kalori İhtiyacı: " + c);
                    // cmd.Parameters.AddWithValue("@GKI", c);
                    //  cmd.ExecuteNonQuery();
                }

            }
            else if (comboBox1.Text == "Bayan")
            {
                if (comboBox2.Text == "Az")
                {
                    // g = 1375 / 1000;
                    c = 660 + (138 * b / 10) + (500 * a) - (68 * d / 10);
                    c = c * 1375 / 1000;

                    MessageBox.Show("Günlük Kalori İhtiyacı: " + c);
                    // cmd.Parameters.AddWithValue("@GKI", c);
                    //cmd.ExecuteNonQuery();
                }

                else if (comboBox2.Text == "Orta")
                {
                    //  g = 1500 / 1000;
                    c = 660 + (138 * b / 10) + (500 * a) - (68 * d / 10);
                    c = c * 1500 / 1000;

                    MessageBox.Show("Günlük Kalori İhtiyacı: " + c);
                    // cmd.Parameters.AddWithValue("@GKI", c);
                    // cmd.ExecuteNonQuery();


                }
                else if (comboBox2.Text == "Çok")
                {
                    // g = 1700 / 1000;
                    c = 660 + (138 * b / 10) + (500 * a) - (68 * d / 10);
                    c = c * 1700 / 1000;

                    MessageBox.Show("Günlük Kalori İhtiyacı: " + c);
                    //cmd.Parameters.AddWithValue("@GKI", c);
                    //cmd.ExecuteNonQuery();

                }

            }

            else
            {
                MessageBox.Show("Cinsiyet Boş Olamaz");

            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}

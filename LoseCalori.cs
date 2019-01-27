using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using ExcelDataReader;
using System.Data.SqlClient;



namespace CalculationOfCaloriSystem
{
    public partial class LoseCalori : Form
    {

        public LoseCalori()
        {
            InitializeComponent();
            
        }

        

        private void LoseCalori_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source =DESKTOP-EIMC7M0\\EMIR1907; Initial Catalog = Kalori; Integrated Security = True");

            DataTable dtoneri = new DataTable();
            SqlDataAdapter daoneri = new SqlDataAdapter("SELECT * FROM Oneri", baglanti);

            daoneri.Fill(dtoneri);
            comboBox1.ValueMember = "Kalori";
            comboBox1.DisplayMember = "oneri";
            comboBox1.DataSource = dtoneri;
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = (Convert.ToInt32(textBox1.Text) / Convert.ToInt32(comboBox1.SelectedValue)).ToString();
            label3.Visible = true;
            label5.Visible = true;
            label4.Visible = true;
            
        }

     

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int ID = r.Next(1, 20);


            SqlConnection baglanti = new SqlConnection("Data Source =DESKTOP-EIMC7M0\\EMIR1907; Initial Catalog = Kalori; Integrated Security = True");
            SqlCommand komut = new SqlCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "SELECT * FROM Oneri Where ID='" + ID + "'";
           
            komut.ExecuteNonQuery();
            SqlDataReader dr = komut.ExecuteReader();
         
            if (dr.Read())
            {
                textBox3.Text = dr["Kalori"].ToString();
               label6.Text = dr["oneri"].ToString();
                label8.Text = (Convert.ToInt32(textBox1.Text) / Convert.ToInt32(textBox3.Text)).ToString();
                label6.Visible = true;
                label8.Visible = true;
                label7.Visible = true;
            }

           
            

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}

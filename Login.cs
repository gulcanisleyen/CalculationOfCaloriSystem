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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("server=DESKTOP-EIMC7M0\\EMIR1907;Database=Kalori;Integrated Security=True");
            con.Open();
            string ad = TextBox1.Text;
            string sifre = TextBox2.Text;
            SqlCommand com = new SqlCommand("SELECT * FROM Login Where Ad='" + ad + "' and Sifre='" + sifre + "'", con);
            SqlDataReader oku = com.ExecuteReader();
            if (oku.Read())
            {

                MainPage f2 = new MainPage();
                f2.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ya da şifre yanlış");

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Register r = new Register();
            r.Show();
            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {
    



        }

       
            

        }
    }

